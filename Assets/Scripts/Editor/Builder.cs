using UnityEngine;
using UnityEditor;

public class Builder {

	public static void BuildProjectAndroid()
	{
		BuildPipeline.BuildPlayer(UnityEditor.EditorBuildSettings.scenes, 
			System.IO.Path.Combine(Application.dataPath, "../artifacts"), 
			BuildTarget.Android, BuildOptions.None);
	}
}
