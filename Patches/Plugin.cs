using BepInEx;
using BreezeCheatClient.Classes;
using System.ComponentModel;
using System.Linq;
using UnityEngine;
using System.Reflection;

namespace BreezeCheatClient.Patches
{
    [Description(BreezeCheatClient.PluginInfo.Description)]
    [BepInPlugin(BreezeCheatClient.PluginInfo.GUID, BreezeCheatClient.PluginInfo.Name, BreezeCheatClient.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {


       
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
