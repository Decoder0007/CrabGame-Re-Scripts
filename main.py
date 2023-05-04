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

obfuscatedData = LoadData("Methods/")
deobfuscatedData = LoadData("Methods Deobfuscated/")

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
        print(str(sortedResults[0][0]))
    elif sortedResults[0][1] > 0:
        score = sortedResults[0][1]
        couldBe = []
        for result in sortedResults:
            if result[1] == score:
                couldBe.append(result)
            else:
                break
        
        for result in couldBe:
            print(result[0] + ", ", end="")
        print()
    else:
        print("Unknown Class")

os.system("cls")

for method in deobfuscatedData:
    print(method + " -> ", end="")
    ReverseEngineer(deobfuscatedData[method])