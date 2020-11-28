# CustomSceneBuilder
AnimationPrepStudio (Lite) - build scenes for recording. 


Some of the steps to add a custom scene,

First create a .blend file with the scene model and move it into the unity scene:
![Step1](https://imgur.com/djdF40W.png)

Also remember to create your scenes to scale in Blender before moving to Unity.


If creating a scene from a blank project then you have to assign the assetbundle information for the Unity scene you just created. By selecting the MyNewScene.scene from in the project tab, you will then see the Asset Labels under the inspector tab, from there just create a new name in the AssetBundle dropdown, but be sure to leave "Scene" set as the variant type:
![Step1](https://imgur.com/nOw9AqE.png)

From there you can build the scene to assetbundle by selecting Build Assetbundles from the Assets dropdown:
![Step1](https://imgur.com/mytvIic.png)

Once Unity has finished processing the assetbundle you can then move the newly created .scene file from the Unity project and place it into VR_MocapAssets folder to make it available in Luxor. 

Copy the new .scene file to: %USERPROFILE%\appdata\LocalLow\Animation Prep Studios\AnimationPrepStudio_Lite\VR_MocapAssets

Also be sure to copy the original .blend and place it next to the .scene asset and give it the same name - this will make the .blend (aka. render scene template) available when exporting from Luxor so it can be loaded by the sceneloader for final rendering:
![Step1](https://imgur.com/3E5IUfZ.png)


If all was successful then you should see the scene you created from Unity available in the scene browser for Luxor and can be used as a mocap environment.

Then after creating some mocap in Luxor and exporting everything out to Blender files project folder you should see your original .blend in the same directory as your avatar/mocap output and as part of the compilation to be loaded by the SceneLoader. 

Here's an example of some of the files that exist after exporting a scene from Luxor to a new Blender project folder. Notice the scene.blend which is just the original .blend that was used:
![Step1](https://imgur.com/zuxcy8X.png)
