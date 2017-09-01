using UnityEngine;
using UnityEditor;

public class Builder {

	public static void BuildProjectAndroid()
	{
		BuildPipeline.BuildPlayer(UnityEditor.EditorBuildSettings.scenes, 
			"artifacts/build.apk", 
			BuildTarget.Android, BuildOptions.None);
	}
}
