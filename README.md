# SENG2260HiFiPrototype
This is the repo for the high fidelity prototype.

# Setup
1. Download and install Unity Hub. This allows you to manage projects and unity versions
2. From unity hub, navigate to 'installs' and install the most recent version of unity (2019.2.6f1)
3. From GitHub, click the 'Clone or Download' button, thn choose Open in Desktop
  3.1 This requires you to have the GitHub Desktop application (You can just use command line git or any other program to clone the repository but the github app seems pretty easy)
  3.2 From the desktop app you can choose to add a remote respository or something similar, give it the url to this repo (Can't remember the exact steps here but it wasn't too hard)
4. In Unity Hub, click 'Add' and choose the folder you cloned the repo to (Should be Documents/Github/SENG2260HiFiPrototype or similar (on windows))
5. The project should now appear in unity hub and you can open it
6. There might be alot of errors about loading files but it should be fine, open the scene named 'SampleScene' in the scenes folder (Assets/Scenes/SampleScene)
7. Should work if you press play from here.

# Adding stuff

First of all use the github desktop app to pull and changes that have been made since the last time you worked on the project.

If you're going to make a large change, maybe do it in a new branch, commit to that branch and thn once you're happy everything works and is usable, commit and push to here. 
Then make a pull request and we can agree to merch the branch and your changes with the master branch if it's all good
(idk too much about using branches and pull requests, does this sound right?)

(Anyone can update this if there's anything missing or that could be clarified)

# IMPORTING IMAGES

Images to be used as UI things like buttons need some import settings changed:

Change the Texture Type to "Sprite (2D and UI)"
Change the Mesh Type to "Full Rect"
then click the arrow next to Advanced to see the advanced settings and tick "Read/Write Enabled"
Then click apply to the lower right.