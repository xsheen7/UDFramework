using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

namespace QFramework
{
    public class CustomImportPipeline : AssetPostprocessor
    {
        public static void OnPostprocessAllAssets(string[] importedAsset, string[] deleteAsset, string[] movedAssets,
            string[] movedFromAssetPaths)
        {
            ProcessImportedAssets(importedAsset);
            ProcessMovedAsset(movedAssets, movedFromAssetPaths);
        }

        private static void ProcessMovedAsset(string[] movedAssets, string[] movedFromAssets)
        {
            if (movedAssets != null && movedAssets.Length > 0)
            {
                for (int i = 0; i < movedAssets.Length; ++i)
                {
                    if (CheckIsRes4AssetBundle(movedAssets[i]))
                    {
                        ProcessAssetBundleTag(movedAssets[i], true);
                    }
                    else if (CheckIsRes4Resources(movedAssets[i]))
                    {
                        ProcessAssetBundleTag(movedAssets[i], false);
                    }
                }
            }
        }

        private static void ProcessImportedAssets(string[] assetPath)
        {
            if (assetPath == null || assetPath.Length == 0)
            {
                return;
            }

            for (int i = 0; i < assetPath.Length; ++i)
            {
                if (CheckIsRes4AssetBundle(assetPath[i]))
                {
                    ProcessAssetBundleTag(assetPath[i], true);
                }
            }
        }

        private static void ProcessAssetBundleTag(string assetPath, bool tag)
        {
            AssetImporter ai = AssetImporter.GetAtPath(assetPath);
            if (ai == null)
            {
                Debug.LogError("Not Find Asset:" + assetPath);
                return;
            }

            string fullPath = PathHelper.AssetsPath2ABSPath(assetPath);
            if (Directory.Exists(fullPath))
            {
                return;
            }

            if (tag)
            {
                string dirName = Path.GetDirectoryName(assetPath);
                string assetBundleName =
                    PathHelper.AssetPath2RelativePath(dirName)
                        .ToLower();
                //注意路径内不要有resource文件夹
                assetBundleName = assetBundleName.Replace("resources/", "");

                if (assetPath.Contains("ABSingleFile"))
                {
                    ai.assetBundleName = string.Format("{0}/{1}.bundle", assetBundleName,
                        PathHelper.FileNameWithoutSuffix(Path.GetFileName(assetPath)));
                }
                else
                {
                    ai.assetBundleName = assetBundleName + ".bundle";
                }
            }
            else
            {
                ai.assetBundleName = string.Empty;
            }
        }

        private static bool CheckIsRes4AssetBundle(string name)
        {
            if (name.StartsWith("Assets/") && name.Contains("/Art/"))
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsRes4Resources(string name)
        {
            if (name.StartsWith("Assets/") && name.Contains("/Resources/"))
            {
                return true;
            }

            return false;
        }

        private static void LogStringArray(string name, string[] data)
        {
            if (data == null)
            {
                return;
            }

            for (int i = 0; i < data.Length; ++i)
            { 
                Debug.Log(string.Format("{0}:{1}", name, data[i]));
            }
        }
    }
}