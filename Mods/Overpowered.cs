using BepInEx;
using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;
using static Breeze.Menu.SimpleInputs;
using static BreezeCheatClient.Menu.Main;


namespace Breeze.Mods
{
    internal class Overpowered
    {
        public static object Breezee { get; private set; }

        public static void EnterOverpowered()
        {
            buttonsType = 5;
        }

        public static void Fling()
        {
            if (LeftX)
            {
                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0, -235f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0, -155f, 0f);
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

        public static async void CrashonGrab()
        {
            if (LeftX)
            {
                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0f, 255f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0f, 255f, 0f);

                await System.Threading.Tasks.Task.Delay(1);

                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0f, -255f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0f, -255f, 0f);

                
                await System.Threading.Tasks.Task.Delay(1);

                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0f, 255f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0f, 255f, 0f);


                await System.Threading.Tasks.Task.Delay(1);

                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(0f, -255f, 0f);
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(0f, -255f, 0f);
            }
        }
    }
}
