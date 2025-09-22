using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using static BreezeCheatClient.Menu.Main;
namespace Breeze.Menu
{
    internal class Disconnect
    {
        Disconnect()
        {
            NetworkSystem.Instance.ReturnToSinglePlayer();
        }
    }
}
