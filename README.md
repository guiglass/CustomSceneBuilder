# CustomSceneBuilder
AnimationPrepStudio (Lite) - build scenes for recording. 

The CustomSceneBuilder contains an example Unity project that shows a Blender scene setup and ready to be built to an assetbundle for Luxor - after loading this example project you should see **Build Assetbundles** option located in the **Assets** dropdown menu in Unity.


## Creating Scene Assets Completely From Scratch:

First create a .blend file with the scene model and move it into a blank Unity scene.

*Remember to create the scene to-scale in Blender before moving to Unity.*

![Step1](https://imgur.com/djdF40W.png)

If creating a scene from a blank project then you have to assign the assetbundle information for the Unity scene you just created. By selecting the MyNewScene.scene from in the project tab, you will then see the Asset Labels under the inspector tab, from there just create a new name in the **AssetBundle** dropdown, but be sure to leave "**Scene**" set as the variant type:

![Step1](https://imgur.com/nOw9AqE.png)

Add the [CreateAssetBundles.cs](https://github.com/guiglass/CustomSceneBuilder/blob/master/Project/Assets/AnimPrep/Scripts/CreateAssetBundles.cs "CreateAssetBundles.cs") script to the project's asset folder.



From here you should be able to build the scene to an assetbundle by selecting **Build Assetbundles** from the **Assets** dropdown:

![Step1](https://imgur.com/mytvIic.png)

Once Unity has finished processing the assetbundle you can then copy the newly created .scene file (located in *Assets/AssetBundles* folder of the Unity project) and paste it into **VR_MocapAssets** folder to make it available in Luxor. 

Copy the new .scene file to: **%USERPROFILE%\appdata\LocalLow\Animation Prep Studios\AnimationPrepStudio_Lite\VR_MocapAssets**

Also be sure to copy the original .blend and place it next to the .scene asset and give it the same name - this will make the .blend (aka. render scene template) available when exporting from Luxor so it can be loaded by the sceneloader for final rendering:

![Step1](https://imgur.com/lyLAfea.png)


If all was successful then you should see the scene you created from Unity available in the scene browser for Luxor and can be used as a mocap environment.

Then after creating some mocap in Luxor and exporting everything out to a new Blender files *project folder* you should see a copy of the original .blend was placed in the directory with the mocap output as part of the compilation to be loaded by the SceneLoader. 

Here's an example of some of the files that exist after exporting a scene from Luxor to a new Blender project folder. Notice the scene.blend which is just the original .blend that was used to create the asset:

![Step1](https://imgur.com/zuxcy8X.png)
