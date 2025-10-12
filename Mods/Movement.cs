
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using static Breeze.Menu.SimpleInputs;
using static BreezeCheatClient.Menu.Main;
namespace Breeze.Mods
{
    internal class Movement
    {
        public static void EnterMovement()
        {
            buttonsType = 3;
        }

        public static void BetterSpeedboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 7.04f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 1.3f;
        }
     
        private static GameObject leftplat = null;
        private static GameObject rightplat = null;

        private static GameObject CreatePlatformOnHand(Transform handTransform)
        {
            GameObject plat = GameObject.CreatePrimitive(PrimitiveType.Cube);
            plat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);

            plat.transform.position = handTransform.position;
            plat.transform.rotation = handTransform.rotation;

            float h = (Time.frameCount / 180f) % 1f;
            plat.GetComponent<Renderer>().material.color = UnityEngine.Color.mintCream;
            return plat;
        }


        public static void Platforms()
        {
            if (ControllerInputPoller.instance.leftGrab && leftplat == null)
            {
                leftplat = CreatePlatformOnHand(GorillaTagger.Instance.leftHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrab && rightplat == null)
            {
                rightplat = CreatePlatformOnHand(GorillaTagger.Instance.rightHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrabRelease && rightplat != null)
            {
                rightplat.Disable();
                rightplat = null;
            }

            if (ControllerInputPoller.instance.leftGrabRelease && leftplat != null)
            {
                leftplat.Disable();
                leftplat = null;
            }
        }

        public static void GravityChanger(float GravValue)
        {
            GTPlayer.Instance.AddForce(new Vector3(0, GravValue, 0), ForceMode.Impulse);
        }
        public static void SlideControl(float slideV)
        {
            if (RightGrab)
            {
                GTPlayer.Instance.slideControl = slideV;
            }
        }

    }
}
