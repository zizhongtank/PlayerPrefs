**Game Technologies Lab**\
**Jiayu Yan**\
**Use of Data Persistence PlayerPrefs**

**Proposal**

Understand the use of data persistence PlayerPrefs to further study the game's archive and read files.

**Reserach**

During the research process, I learned the following knowledge:

1, Data persistence in Unity3D is stored as key values and can be thought of as a dictionary.

2, The Unity3D median is read by the key name. When the value does not exist, the default value is returned.

3, The current class for data persistence in Unity3D is layerPrefs

**Porcess**

1. Create two scenes, named Scene1 and Scene2. Click on the top navigation bar Flie->Build Settings and click Add Open Scenes, then add the two created scenes。

2. Create a script for Scnen1 to create data. 

3. Create another script for Scnene2 to read data

4. Bind the scripts to their own scene camera, then compile the project, run the program.

**Project**

After you enter the program in the first scene and click Submit, you will jump to the second scene, and you can make operations to clear the data and return to the scene.

**citation**

https://docs.unity3d.com/ScriptReference/PlayerPrefs.html \
https://unity3d.com/cn/learn/tutorials/topics/scripting/high-score-playerprefs
