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
                GameObject lBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GameObject.Destroy(lBall.GetComponent<Collider>()); 
                lBall.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                lBall.GetComponent<Renderer>().material.color = Color.red;
                lBall.transform.localScale = new Vector3(0f, 0f, 0f);
                lBall.transform.SetParent(GorillaTagger.Instance.leftHandTransform);
                lBall.transform.localPosition = Vector3.zero;
                GameObject rBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GameObject.Destroy(rBall.GetComponent<Collider>());
                rBall.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                rBall.GetComponent<Renderer>().material.color = Color.red;
                rBall.transform.localScale = new Vector3(0f, 0f, 0f);
                rBall.transform.SetParent(GorillaTagger.Instance.rightHandTransform);
                rBall.transform.localPosition = Vector3.zero;
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                UnityEngine.Object.Destroy(rBall, Time.deltaTime);
                UnityEngine.Object.Destroy(lBall, Time.deltaTime);
                
                
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
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
