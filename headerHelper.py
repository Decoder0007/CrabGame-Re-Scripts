import os
import pyperclip

def LoadData(folder):
    print("Loading Data...")
    onlyfiles = [f for f in os.listdir(folder) if os.path.isfile(os.path.join(folder, f))]
    data = {}
    for f in onlyfiles:
        data[f[0:-3]] = []
        with open(folder+f, "r") as file:
            Lines = file.readlines()
            print("Reading File:  "+f)
            for line in Lines:
                data.get(f[0:-3]).append(line.replace("    ", "").strip())

    print("Loaded Data Folder")
    return data

data = LoadData("NewMethods/")

dontExist = [
    "Client",
    "GameState",
    "IInteractPrompt",
    "IInteractUp",
    "KillCheater",
    "LinkOpener",
    "ListExtensions",
    "NetworkingConstants",
    "OnlineSpectator",
    "PacketUtility",
    "RaycastExtensions",
    "ServerConfig",
    "TextureUtility",
    "VectorExtensions",
    "zzTransparencyCapture"
]

def GetRVA(line) -> str:
    RVAStart = line.find("RVA") + len("RVA = ") + 1
    RVAEnd = line.find(",", RVAStart)
    RVA = line[RVAStart:RVAEnd-1]
    return RVA

def GetOffset(line) -> str:
    offsetStart = line.find("Offset") + 17
    offsetEnd = line.find(",", offsetStart)
    if offsetEnd == -1:
        offsetEnd = line.find(")", offsetStart)
    offset = line[offsetStart:offsetEnd-1]
    return offset

def IsObfuscatedString(line) -> bool:
    goodChars = [
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
        'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D',
        'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
        'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
        '8', '9', "_", " ", ";", "(", ")"]

    return any(not c in goodChars for c in line)

def ParseMethod(line : str):
    methodName = line.split("(")[0].split()[-1]
    if IsObfuscatedString(methodName): return "OBFUSCATED"
    else: return methodName

def ParseFeild(line):
    fieldName = line[0:-1].split()[-1]
    if IsObfuscatedString(fieldName): return "OBFUSCATED"
    else: return fieldName

def ParseLine(key, line, addrLine):
    protections = ["public", "private", "protected"]
    if not key in line:
        if any(p in line for p in protections):
            if ";" in line:
                fieldName = ParseFeild(line)
                if fieldName == "OBFUSCATED": return ""
                return str("    craboffset " + fieldName + " = " + GetOffset(addrLine) + ";\n")
            else:
                methodName = ParseMethod(line)
                if methodName == "OBFUSCATED": return ""
                return str("    crabaddr " + methodName + " = " + GetRVA(addrLine) + ";\n")
    
    return ""

os.system("cls")
print("Generating Namespaces")
output = "#pragma once\n#include \"includes.h\"\n\n"
for key in data.keys():
    if key in dontExist or IsObfuscatedString(key): continue
    output += str("namespace "+key+" {\n")
    currentLine = 0
    while currentLine < len(data.get(key)):
        line = list(data.get(key))[currentLine]
        if "sealed" in line: break
        if "Offset = " in line and not "Attribute" in line and not "DebuggerHidden" in line and not key in data.get(key)[currentLine+1]:
            if "Attibute" in data.get(key)[currentLine+1]:
                output += ParseLine(key, data.get(key)[currentLine+2], data.get(key)[currentLine])
                currentLine += 2
            else:
                output += ParseLine(key, data.get(key)[currentLine+1], data.get(key)[currentLine])
                currentLine += 1
        else:
            currentLine += 1
        
    output += str("};\n\n")

print(output)
pyperclip.copy(output)
print("Namespaces Copied to Clipboard")