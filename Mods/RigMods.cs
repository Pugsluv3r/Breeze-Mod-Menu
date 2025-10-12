using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static Breeze.Menu.SimpleInputs;
using static BreezeCheatClient.Menu.Main;
namespace Breeze.Mods
{
    internal class RigMods
    {
        public static void EnterRigMods()
        {
            buttonsType = 7;
        }

        public static void Ghost()
        {
            if (RightTrigger)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;  // im stupid and this took me 3 hours to figure out

            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true; // i hate myself
            }
        }
        public static void Grabrig()
        {
            if (RightGrab)
            {
                VRRig.LocalRig.enabled = false;

                VRRig.LocalRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;

            }
            else
            {
                VRRig.LocalRig.enabled = true;
            }
        }
    }
}
