using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static Breeze.Menu.SimpleInputs;
using static BreezeCheatClient.Menu.Main;

namespace Breeze.Mods
{
    internal class Overpowered
    {
        public static void EnterOverpowered()
        {
            buttonsType = 5;
        }

        public static void Fling()
        {
            if (LeftX)
            {
                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0, -125f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0, -125f, 0f);
            }
        }

        public static void RandomTpPlayer()
        {
            if (LeftX)
            {
                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0, 0, 999f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0, 0, 999f);
            }
        }

    }
}
