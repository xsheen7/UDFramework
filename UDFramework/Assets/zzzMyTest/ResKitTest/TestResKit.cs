using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class TestResKit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResKit.Init();
        
        AssetBundlePathHelper.SimulationMode = true;
        
        ResLoader resLoader =  ResLoader.Allocate();

        Instantiate(resLoader.LoadSync("Cube"));
        resLoader.ReleaseRes("Cube");
        resLoader.Recycle2Cache();
        
        resLoader.Add2Load("Cube", (success,res) =>
        {
            if (success)
            {
                Instantiate(res.Asset);
            }
        });
        resLoader.LoadAsync();
    }
}
