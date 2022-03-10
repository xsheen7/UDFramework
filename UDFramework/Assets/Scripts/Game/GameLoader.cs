﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameLoader : MonoBehaviour
    {
        private void Start()
        {
            MainGame.Interface.SendCommand<ArchitectureStartCommand>();
        }
    }
}


