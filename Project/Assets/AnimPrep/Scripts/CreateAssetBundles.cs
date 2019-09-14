#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;


public class CreateAssetBundles
{
	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles ()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
	}

	[MenuItem ("Assets/Remove Undersea")]
	static void RemoveName ()
	{
		var names = AssetDatabase.GetAllAssetBundleNames();
		foreach (var name in names) {
			if (name == "tree.scene") {
				AssetDatabase.RemoveAssetBundleName ("tree.scene", true);
				Debug.Log ("Found and removed");
			}
			Debug.Log ("AssetBundle: " + name);
		}
	}
}


#endif