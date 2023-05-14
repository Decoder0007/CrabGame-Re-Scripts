import os
import pyperclip
import re

os.system("cls")

def ReadFolder(folder):
    print("Loading Data from \"" + folder + "\"...")
    return [f for f in os.listdir("./"+folder) if os.path.isfile(os.path.join("./"+folder, f))]

old = ReadFolder("OldMethods")
new = ReadFolder("NewMethods")
dontExist = [
    "Client.cs",
    "GameState.cs",
    "IInteractPrompt.cs",
    "IInteractUp.cs",
    "KillCheater.cs",
    "LinkOpener.cs",
    "ListExtensions.cs",
    "NetworkingConstants.cs",
    "OnlineSpectator.cs",
    "PacketUtility.cs",
    "RaycastExtensions.cs",
    "ServerConfig.cs",
    "TextureUtility.cs",
    "VectorExtensions.cs",
    "zzTransparencyCapture.cs"
]

done = ""
notDone = ""
cantDo = ""
completed = 0

for name in old:
    if name in new:
        done += "`" + name + "` - :white_check_mark: "
        completed += 1
    elif name in dontExist: cantDo += "`" + name + "` - :x: "
    else: notDone += "`" + name + "` - :clock4: "

output = ""
for string in done.split(":white_check_mark:"):
    output += string + ":white_check_mark: "
    if len(output) > 1950:
        pyperclip.copy(output)
        input("Paste into discord and send")
        output = ""
if len(output) > 0:
    pyperclip.copy(output)
    input("Paste into discord and send")
    output = ""

for string in notDone.split(":clock4:"):
    output += string + ":clock4: " if not ":clock4:" in string else ""
    if len(output) > 1950:
        pyperclip.copy(output)
        input("Paste into discord and send")
        output = ""
if len(output) > 0:
    pyperclip.copy(output)
    input("Paste into discord and send")
    output = ""

for string in cantDo.split(":x:"):
    output += string + ":x: "
    if len(output) > 1950:
        pyperclip.copy(output)
        input("Paste into discord and send")
        output = ""
if len(output) > 0:
    pyperclip.copy(output)
    input("Paste into discord and send")
    output = ""

print(str(completed) + " / " + str((len(old) - len(dontExist))) + "   " + str(round((completed / (len(old) - len(dontExist))) * 100, 2)) + "% Complete")