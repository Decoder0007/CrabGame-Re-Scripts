import os

def LoadData():
    print("Loading Data...")
    onlyfiles = [f for f in os.listdir("Methods/") if os.path.isfile(os.path.join("Methods/", f))]
    data = {}
    for f in onlyfiles:
        data[f[0:-3]] = []

        with open("Methods/"+f, "r") as file:
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

    print("All data has been loaded")
    return data

data = LoadData()

def ReverseEngineer():
    global data
    methods = []
    print("Enter all known method names")
    while True:
        inp = input()
        if inp != "":
            methods.append(inp)
        else:
            break

    results = {}
    print("Calculating Class Scores...")
    for className in data:
        results[className] = 0
        for testMethod in methods:
            for method in data[className]:
                if testMethod in method:
                    results[className] += 1

    print("Sorting Results...")

    sortedResults = sorted(results.items(), key=lambda x:x[1], reverse=True)

    if sortedResults[0][1] > sortedResults[1][1]:
        print("The class is most likely:  " + str(sortedResults[0][0]))
    elif sortedResults[0][1] > 0:
        highestScore = sortedResults[0][1]
        couldBe = []
        for result in sortedResults:
            if result[1] == highestScore:
                couldBe.append(result)
            else:
                break
        
        print("Found multiple classes with inputted data")
        for result in couldBe:
            print(result[0])
    else:
        print("No matching classes found.\nTry again with less data or make sure the data you inputted was spelt correctly")

while True:
    ReverseEngineer()
    input("Press enter to continue")
    os.system("cls")