import os
import copy

def LoadData(folder):
    print("Loading Data...")
    onlyfiles = [f for f in os.listdir(folder) if os.path.isfile(os.path.join(folder, f))]
    data = {}
    for f in onlyfiles:
        data[f[0:-3]] = []

        with open(folder+f, "r") as file:
            Lines = file.readlines()
            print("Reading File:  "+f)
            currentLine = 0
            while currentLine < len(Lines):
                line = Lines[currentLine]
                if "[Token(" in line:
                    while line.replace("    ", "").strip()[0] == "[":
                        currentLine += 1
                        line = Lines[currentLine]
                    data.get(f[0:-3]).append(line.replace("    ", "").strip())
                currentLine += 1

    print("Loaded Data Folder")
    return data

obfuscatedData = LoadData("NewMethods/")
deobfuscatedData = LoadData("OldMethods/")

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

def ReverseEngineer(methods):
    filteredData = dict(copy.deepcopy(obfuscatedData))

    results = {}
    for className in filteredData:
        results[className] = 0
        for testMethod in methods:
            for method in filteredData[className]:
                if testMethod in method:
                    results[className] += 1
                    filteredData[className].remove(method)
                    break

    sortedResults = sorted(results.items(), key=lambda x:x[1], reverse=True)

    if sortedResults[0][1] > sortedResults[1][1]:
        return str(sortedResults[0][0])
    elif sortedResults[0][1] > 0:
        score = sortedResults[0][1]
        couldBe = []
        for result in sortedResults:
            if result[1] == score:
                couldBe.append(result)
            else:
                break
        
        string = ""
        for result in couldBe:
            string += result[0] + ", "
        return string
    else:
        return "Unknown Class"

os.system("cls")

shouldPrintValidated = int(input("Should print validated classes (Yes 1, No 0, Default 1):  "))
shouldPrintUnsure = int(input("Should print unsure classes (Yes 1, No 0, Default 1):  "))
shouldPrintUnknown = int(input("Should print unknown classes (Yes 1, No 0, Default 1):  "))
shouldPrintDontExist = int(input("Should print classes that dont exist anymore (Yes 1, No 0, Default 1):  "))

for method in deobfuscatedData:
    output = ReverseEngineer(deobfuscatedData[method])
    if (method in output) and (shouldPrintValidated == 0): continue
    if (", " in output) and (shouldPrintUnsure == 0): continue
    if ("Unknown Class" in output) and (shouldPrintUnknown == 0): continue
    if (method in dontExist) and (shouldPrintDontExist == 0): continue
    print(method + " -> " + output)
    print()