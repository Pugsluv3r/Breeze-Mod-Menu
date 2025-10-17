using Breeze.Mods;
using BreezeCheatClient.Classes;
using BreezeCheatClient.Mods;
using static BreezeCheatClient.Settings;
using static Breeze.Menu.Disconnect;

namespace BreezeCheatClient.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => Movement.EnterMovement(), isTogglable = false, toolTip = "All Movement Mods"},
                new ButtonInfo { buttonText = "Room Mods", method =() => RoomMods.EnterRoomMods(), isTogglable = false, toolTip = "Join Rooms without needing a computer"},
                new ButtonInfo { buttonText = "Rig Mods", method =() => RigMods.EnterRigMods(), isTogglable = false, toolTip = "Rig related mods"},
                new ButtonInfo { buttonText = "Overpowered", method =() => Overpowered.EnterOverpowered(), isTogglable = false, toolTip = "Overpowered UND"},
                new ButtonInfo { buttonText = "Safety", method =() => Safety.EnterSaftey(), isTogglable = false, toolTip = "Saftey related Mods"},
                new ButtonInfo { buttonText = "PC Utils", method =() => PcMods.EnterPcMods(), isTogglable = false, toolTip = "suckjdisfj"},
                new ButtonInfo { buttonText = "Other", method =() => Othershit.EnterOther(), isTogglable = false, toolTip = "Uncatatagorized junk"},
                new ButtonInfo { buttonText = "Credits", method =() => Global.Entercredits(), isTogglable = false, toolTip = "Congrats we made a mod"},
                 new ButtonInfo { buttonText = "Click for version info", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "Version: INDEV preview 2"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },
             new ButtonInfo[] { // Movement [3]
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Speed Boost", method =() => Movement.BetterSpeedboost(), isTogglable = true, toolTip = "A slight speedboost"},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), isTogglable = true, toolTip = "Use your left and right grips to make plats"}, // i want to die
                new ButtonInfo { buttonText = "Low Gravity", method =() => Movement.GravityChanger(1.7f), isTogglable = true, toolTip = "Monkes on da MOON!"}, // same with this tooltip
                new ButtonInfo { buttonText = "High Gravity", method =() => Movement.GravityChanger(-2.7f), isTogglable = true, toolTip = "Monkes go to jupiter to get more stupider!"}, // i hate this fucking tooltip 
                new ButtonInfo { buttonText = "Quest Slide Control", method = () => Movement.SlideControl(0.0006f), isTogglable = true, toolTip = "Gives player a slide control similar to a quest player"},
                new ButtonInfo { buttonText = "SuperMonke [RT]", method = () => Movement.Headfly(10f), isTogglable  = true, toolTip = "Look were you want to fly, then Use Right trigger to fly and left trigger to boost yourself"},
                new ButtonInfo { buttonText = "Handfly [RT]", method = () => Movement.HandFly(10f), isTogglable  = true, toolTip = "point your hand were you want to fly, then Use Right trigger to fly and left trigger to boost yourself"}
             },
                 new ButtonInfo[] { // Saftey [4]
                   new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                   new ButtonInfo { buttonText = "Return To Stump", method =() => Safety.ReturnToStump(), isTogglable = true, toolTip = "Press Y to return to stump" },
                   new ButtonInfo { buttonText = "Anti AFK", method =() => Safety.AntiAfk(), isTogglable = true, toolTip = "Disables AFK kick"},
                   new ButtonInfo { buttonText = "Notify when near", method =() => Safety.DWPIN(), isTogglable = true, toolTip = "notifys you when a player is near you"},
            },
                 new ButtonInfo[] { // Overpowered [5]
                   new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                   new ButtonInfo { buttonText = "Fling [X]", method =() => Overpowered.Fling(), isTogglable = true, toolTip = "When holding a players hand press X to fling them (use Return to stump with it)"},
                   new ButtonInfo { buttonText = "Random tp player [X]", method =() => Overpowered.RandomTpPlayer(), isTogglable = true, toolTip = "When holding a players hand press X to teloport them"},
                   new ButtonInfo { buttonText = "InstaCrash on grab [X]", method =() => Overpowered.CrashonGrab(), isTogglable = true, toolTip = "Crash go brrrr (use Return to stump with it)"},

            },
                 new ButtonInfo[] { // Room Mods [6]
                   new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                   new ButtonInfo { buttonText = "Join Mods", method =() => RoomMods.JoinCodeMods(), isTogglable = false, toolTip = "Attempting to join"},
                   new ButtonInfo { buttonText = "Join Mod", method =() => RoomMods.JoinCodeMod(), isTogglable = false, toolTip = "Attempting to join"},
                   new ButtonInfo { buttonText = "Join Lucio", method =() => RoomMods.JoinRoomLucio(), isTogglable = false, toolTip = "Attempting to join"},

            },
                 new ButtonInfo[] { // Rig Mods [7]
                 new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                 new ButtonInfo { buttonText = "Ghost", method =() => RigMods.Ghost(), isTogglable = true, toolTip = "Basic Ghost monkey"},
                 new ButtonInfo { buttonText = "Grab Rig", method =() => RigMods.Grabrig(), isTogglable = true, toolTip = "Basic grab rig"},
            },

                  new ButtonInfo[] { //Credits [8]
                 new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                 new ButtonInfo { buttonText = "Devs:", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "PUGSLUV3R", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "Testers:", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "Duhui", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "A msg from me:", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "If your reading this id like to say that anything is possible allthough this community may seem toxic.", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "There are amazing people out the ive met so many cool people through this game and i mean it.", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "to industry and test you guys inspired me to pick up C# and i cant thank you enough for doing that.", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "to the user, Thank you for using my menu", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
                 new ButtonInfo { buttonText = "Without you guys i dont know if id be in the spot im at today <3", method =() => Global.Nothingsandwitch(), isTogglable = false, toolTip = "This is just text dummy KekW"},
           },
                  new ButtonInfo[] { //pcutil [9]
                 new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                 new ButtonInfo { buttonText = "Pc Controller emulator", method =() => MenuLibrarys.GunLib(), isTogglable = true, toolTip =  "emulates your controllers"},
                 new ButtonInfo { buttonText = "Pc Noclip (E)", method =() => PcMods.PCnoclip(), isTogglable = true, toolTip =  "Press E to enable noclip"},
                 new ButtonInfo { buttonText = "Pc Ghost (Q)", method =() => PcMods.PCghost(), isTogglable = true, toolTip =  "Press Q to enable Ghost"},
                 new ButtonInfo { buttonText = "Force enable hand colliders", method =() => PcMods.EnableHands(), isTogglable = true, toolTip =  "Enables hand colliders"},
          },
                 new ButtonInfo[] { // Other shit [10]
                 new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                 new ButtonInfo { buttonText = "Clear Notifs", method =() => Othershit.Clearnotifs(), isTogglable = false, toolTip = "Clears all notifications"},
         },
       };
    }
}
