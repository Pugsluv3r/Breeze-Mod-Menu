using GorillaLocomotion;
using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using static BreezeCheatClient.Menu.Main;
using static Breeze.Menu.SimpleInputs;
using UnityEngine;
using System.Numerics;
using Photon.Realtime;
using BreezeCheatClient.Notifications;

namespace Breeze.Mods
{
    internal class Safety
    {
        public static void EnterSaftey()
        {
            buttonsType = 4;
        }

        public static void AntiAfk()
        {
            PhotonNetworkController.Instance.disableAFKKick = true;
        }
        public static void ReturnToStump()
        {
            if (RightB)
            {
                UnityEngine.Vector3 targetPosition = new UnityEngine.Vector3(-66.9039f, 11.8661f, -82.1227f);
                UnityEngine.Quaternion targetRotation = UnityEngine.Quaternion.identity;
                GTPlayer.Instance.TeleportTo(targetPosition, targetRotation);
            }
        }
        public static float range = 5f;
        public static float Notifdelay;
        public static void DWPIN()
        {
            try
            {
                foreach (VRRig vRRig in GorillaParent.instance.vrrigs)
                    if (!vRRig.isLocal)
                    {
                        float playerpos = UnityEngine.Vector3.Distance(vRRig.bodyTransform.position, GTPlayer.Instance.transform.position);
                        if (playerpos < range)
                            if (Time.time > Notifdelay)
                        {
                                Notifdelay =  Time.time + 0.6f;
                            NotifiLib.SendNotification("<color=purple>[WARNING]</color> Player near you");
                        }
                    }
            }
            catch { } // no reason
        }
    }
}