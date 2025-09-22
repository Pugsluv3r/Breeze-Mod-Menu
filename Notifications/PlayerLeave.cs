using HarmonyLib;
using BreezeCheatClient.Notifications;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static BreezeCheatClient.Menu.Main;

namespace BreezeCheatClient.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
    internal class LeavePatch : MonoBehaviour
    {
        private static void Prefix(Player otherPlayer)
        {
            if (otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != a)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=red>Disconnected</color><color=grey>]</color> <color=white>Name: " + otherPlayer.NickName + "</color>");
                a = otherPlayer;
            }
        }

        private static Player a;
    }
}