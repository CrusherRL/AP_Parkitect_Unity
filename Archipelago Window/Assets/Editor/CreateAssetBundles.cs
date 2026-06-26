using System.Diagnostics;
using UnityEditor;

public class CreateAssetBundles
{
    [MenuItem("Bundler/Build Asset Bundles")]
    static void BuildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/Dist/Windows", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        BuildPipeline.BuildAssetBundles("Assets/Dist/MacOS", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);
        BuildPipeline.BuildAssetBundles("Assets/Dist/Linux", BuildAssetBundleOptions.None, BuildTarget.StandaloneLinux64);
    }
}