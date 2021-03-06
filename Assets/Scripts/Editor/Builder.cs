﻿using System.Linq;

using UnityEngine;
using UnityEditor;

public class Builder {

	public static void BuildProjectAndroid()
	{
		BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions{
			scenes = UnityEditor.EditorBuildSettings.scenes.Select(s => s.path).ToArray(),
			locationPathName = "./artifacts/build.apk",
			target = BuildTarget.Android,
			options = BuildOptions.None,
		};
		BuildPipeline.BuildPlayer(buildPlayerOptions);
	}

	public static void BuildProjectiOS()
	{
		BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions{
			scenes = UnityEditor.EditorBuildSettings.scenes.Select(s => s.path).ToArray(),
			locationPathName = "./Xcode",
			target = BuildTarget.iOS,
			options = BuildOptions.None,
		};
		BuildPipeline.BuildPlayer(buildPlayerOptions);
	}
}
