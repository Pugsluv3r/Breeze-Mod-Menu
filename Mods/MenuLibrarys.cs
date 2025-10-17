using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Breeze.Mods
{
    internal class MenuLibrarys
    {
        private static GameObject GunSphere;  // the sphere object 
        private static LineRenderer lineRenderer;  // The lineRenderer 
        private static float timeCounter = 0f;  // just a timer for animations
        private static Vector3[] linePositions;  // stores positions
        private static Vector3 previousControllerPosition;  // stores previous positions
        public static void GunLib()
        {
            // Check if the right controller grip or the mouse right button is pressed
            if (ControllerInputPoller.instance.rightControllerGripFloat > 0.1f || Mouse.current.rightButton.isPressed)
            {
                if (Physics.Raycast(
                        GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position,
                        -GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.up, out var hitinfo))
                {
                    // if mouse right button is pressed
                    if (Mouse.current.rightButton.isPressed)
                    {
                        Camera cam = GameObject.Find("Shoulder Camera").GetComponent<Camera>();
                        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                        Physics.Raycast(ray, out hitinfo, 100); // how far away from camera
                    }

                    // if it doesnt exist make it ig
                    if (GunSphere == null)
                    {
                        GunSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);  // makes a sphere frfr
                        GunSphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);  
                        GunSphere.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                        GunSphere.GetComponent<Renderer>().material.color = Color.white;  // not sure why i addded it but oh well changes color

                        // gets rid if stuff we dont need
                        UnityEngine.Object.Destroy(GunSphere.GetComponent<BoxCollider>());
                        UnityEngine.Object.Destroy(GunSphere.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(GunSphere.GetComponent<Collider>());

                        // makes line renderer
                        lineRenderer = GunSphere.AddComponent<LineRenderer>();
                        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                        lineRenderer.widthCurve = AnimationCurve.Linear(0, 0.01f, 1, 0.01f);
                        lineRenderer.startColor = Color.white;
                        lineRenderer.endColor = Color.white;

                        linePositions = new Vector3[50];
                        for (int i = 0; i < linePositions.Length; i++)
                        {
                            linePositions[i] = GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position; // set start positions to controllers position
                        }
                    }

                    GunSphere.transform.position = hitinfo.point;

                    timeCounter += Time.deltaTime; 

                    Vector3 pos1 = GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position;  
                    float distance = Vector3.Distance(pos1, hitinfo.point);  
                    previousControllerPosition = pos1;  

                    const float spiralTurns = 0f;  // amount of spiral turns
                    const float maxAmplitude = 0.1f;  // max amplitude of the spiral

                    for (int i = 0; i < linePositions.Length; i++)
                    {
                        float t = i / (float)(linePositions.Length - 1);  // interpolation value
                        Vector3 basePos = Vector3.Lerp(pos1, hitinfo.point, t);  // interpolate between controller and hit point
                        Vector3 forward = (hitinfo.point - pos1).normalized;  // direction from controller to hit point
                        Vector3 up = Vector3.up;

                        // makes the up vector perpendicular to the forward vector
                        if (Mathf.Abs(Vector3.Dot(forward, up)) > 0.9f)
                        {
                            up = Vector3.right;
                        }

                        // vectors for the spiral
                        Vector3 right = Vector3.Cross(forward, up).normalized;
                        up = Vector3.Cross(right, forward).normalized;

                        // the spirals angle and amplitude
                        float spiralAngle = t * 2f * Mathf.PI * spiralTurns + timeCounter;
                        float spiralAmplitude = (1f - t) * maxAmplitude;

                        // offset of spiral effect
                        Vector3 offset = right * (Mathf.Cos(spiralAngle) * spiralAmplitude) +
                                         up * (Mathf.Sin(spiralAngle) * spiralAmplitude);

                        Vector3 newPos = basePos + offset;  // final position of the spiral
                        linePositions[i] = Vector3.Lerp(linePositions[i], newPos, Time.deltaTime * 5f);  
                    }

                    
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f || Mouse.current.leftButton.isPressed)
                    {
                        


                    }

                    
                    lineRenderer.positionCount = linePositions.Length;
                    lineRenderer.SetPositions(linePositions);

                    
                    float colorLerp = Mathf.PingPong(timeCounter, 1f);
                    Color lineColor = Color.Lerp(Color.white, Color.cyan, colorLerp);
                    lineRenderer.startColor = lineColor;
                    lineRenderer.endColor = lineColor;
                }
            }
            // if the grip or mouse button is released
            else if (GunSphere != null && ControllerInputPoller.instance.rightControllerGripFloat <= 0.1f && !Mouse.current.rightButton.isPressed)
            {
                UnityEngine.Object.Destroy(GunSphere);  // destroys GunSphere object
                UnityEngine.Object.Destroy(lineRenderer);  // destroys LineRenderer
                timeCounter = 0f;  // Resets timer
                linePositions = null;  // basically deletes the line renderer if its in the scene 
            }
        }

    }
}
