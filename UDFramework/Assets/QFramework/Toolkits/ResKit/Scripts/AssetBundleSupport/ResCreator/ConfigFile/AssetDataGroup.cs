/****************************************************************************
 * Copyright (c) 2018.3 ~ 2019.1 liangxie
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/


using System;
using UnityEngine;
using System.Collections.Generic;

namespace QFramework
{
    /// <summary>
    /// AB包资源 包括ab包和ab内的资源清单 运行时使用数据
    /// </summary>
    public class AssetDataGroup
    {
        public IEnumerable<AssetData> AssetDatas
        {
            get { return mAssetDataMap.Values; }
        }

        public IEnumerable<ABDependenceData> AssetBundleDatas
        {
            get
            {
                return mABDependenceArray;
            }
        }

        /// <summary>
        /// 代表依赖关系的类
        /// </summary>
        [Serializable]
        public class ABDependenceData
        {
            public string abName;
            public string[] abDepends;

            public ABDependenceData(string name, string[] depends)
            {
                abName = name;
                if (depends == null || depends.Length == 0)
                {

                }
                else
                {
                    abDepends = depends;
                }
            }

            public override string ToString()
            {
                var result = string.Format("ABName:" + abName);
                if (abDepends == null)
                {
                    return result;
                }

                foreach (var abDepend in abDepends)
                {
                    result += string.Format(" #:{0}", abDepend);
                }

                return result;
            }
        }

        /// <summary>
        /// 序列化ab包资源 本地序列化使用数据
        /// </summary>
        [Serializable]
        public class SerializeData
        {
            private string mKey;
            private ABDependenceData[] mAbUnitArray;
            private AssetData[] mAssetDataArray;

            public string key
            {
                get { return mKey; }
                set { mKey = value; }
            }

            public ABDependenceData[] abUnitArray
            {
                get { return mAbUnitArray; }
                set { mAbUnitArray = value; }
            }

            public AssetData[] assetDataArray
            {
                get { return mAssetDataArray; }
                set { mAssetDataArray = value; }
            }
        }

        private string m_Key;

        private List<ABDependenceData> mABDependenceArray;
        private Dictionary<string, AssetData> mAssetDataMap;
        private Dictionary<string, AssetData> mUUID4AssetData;
        public string key
        {
            get { return m_Key; }
        }

        public AssetDataGroup(string key)
        {
            m_Key = key;
        }

        public AssetDataGroup(SerializeData data)
        {
            m_Key = data.key;
            SetSerializeData(data);
        }

        public void Reset()
        {
            if (mABDependenceArray != null)
            {
                mABDependenceArray.Clear();
            }

            if (mAssetDataMap != null)
            {
                mAssetDataMap.Clear();
            }
        }

        public int AddAssetBundleName(string name, string[] depends)
        {
            if (string.IsNullOrEmpty(name))
            {
                return -1;
            }

            if (mABDependenceArray == null)
            {
                mABDependenceArray = new List<ABDependenceData>();
            }

            var resSearchRule = ResSearchKeys.Allocate(name);
            AssetData config = GetAssetData(resSearchRule);
            resSearchRule.Recycle2Cache();

            if (config != null)
            {
                return config.AssetBundleIndex;
            }

            mABDependenceArray.Add(new ABDependenceData(name, depends));

            int index = mABDependenceArray.Count - 1;

            AddAssetData(new AssetData(name, ResLoadType.AssetBundle, index,null));

            return index;
        }

        public bool GetAssetBundleName(string assetName, int index, out string result)
        {
            result = null;

            if (mABDependenceArray == null)
            {
                return false;
            }

            if (index >= mABDependenceArray.Count)
            {
                return false;
            }

            if (mAssetDataMap.ContainsKey(assetName))
            {
                result = mABDependenceArray[index].abName;
                return true;
            }

            return false;
        }

        public ABDependenceData GetABUnit(string assetName)
        {
            var resSearchRule = ResSearchKeys.Allocate(assetName);

            AssetData data = GetAssetData(resSearchRule);
            
            resSearchRule.Recycle2Cache();

            if (data == null)
            {
                return null;
            }

            if (mABDependenceArray == null)
            {
                return null;
            }

            return mABDependenceArray[data.AssetBundleIndex];
        }

        public bool GetAssetBundleDepends(string abName, out string[] result)
        {
            result = null;

            ABDependenceData unit = GetABUnit(abName);

            if (unit == null)
            {
                return false;
            }

            result = unit.abDepends;

            return true;
        }

        public AssetData GetAssetData(ResSearchKeys resSearchRule)
        {
            AssetData result = null;

            if (resSearchRule.OwnerBundle != null && mUUID4AssetData != null)
            {
                return mUUID4AssetData.TryGetValue(resSearchRule.OwnerBundle + resSearchRule.AssetName, out result) ? result : null;
            }

            if (resSearchRule.OwnerBundle == null && mAssetDataMap != null)
            {
                return mAssetDataMap.TryGetValue(resSearchRule.AssetName, out result) ? result : null;
            }

            return result;
        }

        public bool AddAssetData(AssetData data)
        {
            if (mAssetDataMap == null)
            {
                mAssetDataMap = new Dictionary<string, AssetData>();
            }

            if (mUUID4AssetData == null)
            {
                mUUID4AssetData = new Dictionary<string, AssetData>();
            }
 
            string key = data.AssetName.ToLower();

            if (mAssetDataMap.ContainsKey(key))
            {
                var resSearchRule = ResSearchKeys.Allocate(data.AssetName);
                var old = GetAssetData(resSearchRule);
                resSearchRule.Recycle2Cache();

                try
                {
                    //注意ab包的tag不能和资源名相同 会添加ab的tag作为key
                    Debug.LogFormat("Already Add AssetData :{0} \n OldAB:{1}      NewAB:{2}", data.AssetName,
                        mABDependenceArray[old.AssetBundleIndex].abName, mABDependenceArray[data.AssetBundleIndex].abName);
                }
                catch (Exception e)
                {
                    Debug.LogWarning(e);
                }
            }
            else
            {
                mAssetDataMap.Add(key, data);
            }

            if (mUUID4AssetData.ContainsKey(data.UUID))
            {
                var resSearchRule = ResSearchKeys.Allocate(data.AssetName,data.OwnerBundleName);

                AssetData old = GetAssetData(resSearchRule);
                resSearchRule.Recycle2Cache();

                Debug.LogWarningFormat("Already Add AssetData :{0} \n OldAB:{1}      NewAB:{2}", data.UUID,
                    mABDependenceArray[old.AssetBundleIndex].abName, mABDependenceArray[data.AssetBundleIndex].abName);
            }
            else
            {
                mUUID4AssetData.Add(data.UUID,data);
            }
            return true;
        }

        public SerializeData CreatSerializeData()
        {
            var sd = new SerializeData();
            sd.key = m_Key;
            sd.abUnitArray = mABDependenceArray.ToArray();
            if (mAssetDataMap != null)
            {
                AssetData[] acArray = new AssetData[mAssetDataMap.Count];

                int index = 0;
                foreach (var item in mAssetDataMap)
                {
                    acArray[index++] = item.Value;
                }

                sd.assetDataArray = acArray;
            }

            return sd;
        }


        private void SetSerializeData(SerializeData data)
        {
            if (data == null)
            {
                return;
            }

            mABDependenceArray = new List<ABDependenceData>(data.abUnitArray);

            if (data.assetDataArray != null)
            {
                mAssetDataMap = new Dictionary<string, AssetData>();

                foreach (var config in data.assetDataArray)
                {
                    AddAssetData(config);
                }
            }
        }
    }
}
