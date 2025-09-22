using BepInEx;
using BreezeCheatClient.Classes;
using System.ComponentModel;
using UnityEngine;
using static BreezeCheatClient.Classes.Console;

namespace BreezeCheatClient.Patches
{
    [Description(BreezeCheatClient.PluginInfo.Description)]
    [BepInPlugin(BreezeCheatClient.PluginInfo.GUID, BreezeCheatClient.PluginInfo.Name, BreezeCheatClient.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        void Start() =>
    GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);

        void OnPlayerSpawned()
        {
            string ConsoleGUID = $"goldentrophy_Console_{Console.ConsoleVersion}";
            GameObject ConsoleObject = GameObject.Find(ConsoleGUID);

            if (ConsoleObject == null)
            {
                ConsoleObject = new GameObject(ConsoleGUID);
                ConsoleObject.AddComponent<CoroutineManager>();
                ConsoleObject.AddComponent<Console>();
            }

            if (ServerData.ServerDataEnabled)
                ConsoleObject.AddComponent<ServerData>();
        }

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
