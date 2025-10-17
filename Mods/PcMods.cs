using BepInEx;
using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;
using static BreezeCheatClient.Menu.Main;
using static Breeze.Mods.MenuLibrarys;
namespace Breeze.Mods
{
    internal class PcMods
    {
        public static void EnterPcMods()
        {
            buttonsType = 9;
        }
        public static void PCnoclip()
        {

            bool NoCollide = (!UnityInput.Current.GetKey(KeyCode.E));
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>(); // im aware this is old as fuck BUTTTTT idc so fuck you buddy

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !NoCollide;
            }
        }
        public static void PCghost()
        {
            if (!UnityInput.Current.GetKey(KeyCode.Q))
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
        }
        public static void EnableHands()
        {
            GTPlayer.Instance.wasRightHandColliding = true;
            GTPlayer.Instance.wasLeftHandColliding = true;
        }
        public static void Pchandemu()
        {
            
        }

    }
}
