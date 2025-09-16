using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

namespace Breeze.Menu
{
    internal class SimpleInputs
    {
        // Right controller
        public static bool RightTrigger => ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f;
        public static bool RightGrab => ControllerInputPoller.instance.rightControllerGripFloat > 0.5f;
        public static bool RightA => ControllerInputPoller.instance.rightControllerSecondaryButton;
        public static bool RightB => ControllerInputPoller.instance.rightControllerSecondaryButton;
        //Left Controller
        public static bool LeftTrigger => ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f;
        public static bool LeftGrab => ControllerInputPoller.instance.leftControllerGripFloat > 0.5f;
        public static bool LeftX => ControllerInputPoller.instance.leftControllerPrimaryButton;
        public static bool LeftY => ControllerInputPoller.instance.leftControllerSecondaryButton;
    }
}
