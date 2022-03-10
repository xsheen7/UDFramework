using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace QFramework
{
    public class PathHelper
    {
        /// <summary>
        /// asset相对路径转绝对路径
        /// </summary>
        /// <param name="assetsPath"></param>
        /// <returns></returns>
        public static string AssetsPath2ABSPath(string assetsPath)
        {
            string assetRootPath = System.IO.Path.GetFullPath(Application.dataPath);
            assetRootPath = assetRootPath.Substring(0, assetRootPath.Length - 6) + assetsPath;
            return assetRootPath.Replace("\\", "/");
        }
        
        /// <summary>
        /// asset相对路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string AssetPath2RelativePath(string path)
        {
            if (path == null)
            {
                return null;
            }

            return path.Replace("Assets" + Path.DirectorySeparatorChar, "");
        }
        
        /// <summary>
        /// 文件路径无后缀
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string FileNameWithoutSuffix(string name)
        {
            if (name == null)
            {
                return null;
            }

            int endIndex = name.LastIndexOf('.');
            if (endIndex > 0)
            {
                return name.Substring(0, endIndex);
            }
            return name;
        }
    }
}

