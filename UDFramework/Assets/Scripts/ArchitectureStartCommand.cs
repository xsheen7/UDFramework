using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace Game
{
    public class ArchitectureStartCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            Log.I("architecture start");
        }
    }
}

