using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

class WindowsBuild
{
    static void build() {
        // string[] scenes = { "Assets/scenes/SampleScene.unity" };
        // string buildPath = "buildwindowstest";
        // BuildReport buildReport = BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "windowsbuildtest";
        buildPlayerOptions.target = (BuildTarget) 19;
        buildPlayerOptions.options = (BuildOptions) 0;
        buildPlayerOptions.targetGroup = (BuildTargetGroup) 1;

        BuildReport buildReport = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = buildReport.summary;

        if (summary.result == BuildResult.Succeeded) {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }

        if (summary.result == BuildResult.Failed) {
            Debug.Log("Build failed");
        }
    }
}