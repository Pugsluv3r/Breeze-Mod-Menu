using BreezeCheatClient.Notifications;
using GorillaNetworking;
using Mono.Security.Interface;
using Photon.Pun;
using Photon.Realtime;
using PlayFab.MultiplayerModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UnityEngine;
using static BreezeCheatClient.Menu.Main;
namespace Breeze.Mods
{
    internal class RoomMods : MonoBehaviourPunCallbacks
    {
        public static void EnterRoomMods()
        {
            buttonsType = 6;
        }

      public static void JoinCodeMods()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MODS", JoinType.Solo);
        }

        public static void JoinCodeMod()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MOD", JoinType.Solo);
        }

        public static void JoinRoomLucio()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("LUCIO", JoinType.Solo);
        }
    }
}
