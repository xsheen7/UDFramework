using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using QFramework.Example;
using UnityEngine;

public class MainGame : Architecture<MainGame>
{
    protected override void Init()
    {
        ResKit.Init();
        UIMyPanel panel = UIKit.OpenPanel<UIMyPanel>();
        
        Material mat = ResLoader.Allocate().LoadSync("Test") as Material;
        Log.I(mat.name);
    }
}
