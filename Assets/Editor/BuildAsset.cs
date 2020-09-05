using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class BuildAsset : Editor 
{
     [MenuItem("Asset/BuildAssetbundle")]

    static void buildAssetbundle()
    {
        BuildPipeline.BuildAssetBundles(@"D:\Assetbundle_2", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }
}
