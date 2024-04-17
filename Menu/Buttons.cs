using Eyerock.Classes;
using Photon.Pun;
using static Eyerock.Mods.MoveMent;
using static Eyerock.Mods.Visuals;
using static Eyerock.Settings;

namespace Eyerock.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Page 1 Mods
                new ButtonInfo{ buttonText = "LEAVE", method =() => PhotonNetwork.Disconnect(), isTogglable = true},
                new ButtonInfo{ buttonText = "Car Monke", method =() => CarMonkey(), isTogglable = true},
                new ButtonInfo{ buttonText = "Speed Boost", method =() => SpeedBoost(true), disableMethod =() => SpeedBoost(false), isTogglable = true},
                new ButtonInfo{ buttonText = "Long Arms", method =() => LongArms(), disableMethod =() => LongArmsFix(), isTogglable = true},
                new ButtonInfo{ buttonText = "No Tag Freeze", method =() => GorillaLocomotion.Player.Instance.disableMovement = false, isTogglable = true},
                new ButtonInfo{ buttonText = "Toggle Beacon", method =() => Beacons(), isTogglable = true},
                new ButtonInfo{ buttonText = "Platform", method =() => Platforms(), isTogglable = true},
                new ButtonInfo{ buttonText = "No Clip", method =() => NoClip(), isTogglable = true},
                new ButtonInfo{ buttonText = "TP Gun", method =() => TpGun(), isTogglable = true},
                new ButtonInfo{ buttonText = "----->> [PG 1]", method =() => Page2(), isTogglable = false},
            },
            new ButtonInfo[] { // Page 2 Mods
                new ButtonInfo{ buttonText = "RGB [W?]", method =() => RGBMONKEY(), isTogglable = true},
                new ButtonInfo{ buttonText = "Super Monke", method =() => SuperMonk(), isTogglable = true},
                new ButtonInfo{ buttonText = "Grip Monke", method =() => GripMonkey(), disableMethod =() => GripMonkeyFix(), isTogglable = true},
                new ButtonInfo{ buttonText = "Ghost Monke", method =() => GhostMonke(), isTogglable = true},
                new ButtonInfo{ buttonText = "SpiderMonke", method =() => SpiderMonke(), isTogglable = true},
                new ButtonInfo{ buttonText = "Big Monke", method =() => BigMonke(), disableMethod =() => BigMonkeFix(), isTogglable = true},
                new ButtonInfo{ buttonText = "Invisible Monke", method =() => InvisibleMonke(), isTogglable = true},
                new ButtonInfo{ buttonText = "Check Point", method =() => CheckPoint(),disableMethod =() => destroycheckpoint(), isTogglable = true},
                new ButtonInfo{ buttonText = "<<----- [PG 0]", method =() => Page1(), isTogglable = false},
                new ButtonInfo{ buttonText = "----->> [PG 2]", method =() => Page3(), isTogglable = false},
            },
            new ButtonInfo[] { // Page 3 Mods
                new ButtonInfo{ buttonText = "Lean Bomb", method =() => LeanBomb(), isTogglable = true},
                new ButtonInfo{ buttonText = "Slide Control", method =() => GorillaLocomotion.Player.Instance.slideControl = 1f, isTogglable = true},
                new ButtonInfo{ buttonText = "Funny Walk", method =() => GorillaLocomotion.Player.Instance.disableMovement = true, disableMethod =() => GorillaLocomotion.Player.Instance.disableMovement = false, isTogglable = true},
                new ButtonInfo{ buttonText = "Strobe [W?]", method =() => STROBEMONKEY(), isTogglable = true},
                new ButtonInfo{ buttonText = "Moon Walk", method =() => MoonGrav(), isTogglable = true},
                new ButtonInfo{ buttonText = "Jupiter Walk", method =() => JupiterGrav(), isTogglable = true},
                new ButtonInfo{ buttonText = "Wall Walk", method =() => WallHelper(), isTogglable = true},
                new ButtonInfo{ buttonText = "Up and Down", method =() => UpAndDown(), isTogglable = true},
                new ButtonInfo{ buttonText = "<<----- [PG 1]", method =() => Page2(), isTogglable = false},
                new ButtonInfo{ buttonText = "----->> [PG 3]", method =() => Page4(), isTogglable = false},
            },
            new ButtonInfo[] { // Page 3 Mods
                new ButtonInfo{ buttonText = "Hide in Trees", method =() => HideinTrees(), disableMethod =() => HideinTreesFix(), isTogglable = true},
                new ButtonInfo{ buttonText = "Name Changer [W?]", method =() => NameChanger(), isTogglable = true},
                new ButtonInfo{ buttonText = "Black Hole", method =() => BlackHole(), disableMethod =() => delerig1(), isTogglable = true},
                new ButtonInfo{ buttonText = "<<----- [PG 2]", method =() => Page3(), isTogglable = false},
                new ButtonInfo{ buttonText = "-=CREDS=-", method =() => PageCosmetics(), isTogglable = false},
            },
            new ButtonInfo[] { // Page 3 Mods
                new ButtonInfo{ buttonText = "Bypasser [MAIN DEV]", method =() => PlaceHolder(), isTogglable = false},
                new ButtonInfo{ buttonText = "Azora [SOME MODS]", method =() => PlaceHolder(), isTogglable = false},
                new ButtonInfo{ buttonText = "eyerock [OG MENU]", method =() => PlaceHolder(), isTogglable = false},
                new ButtonInfo{ buttonText = "YOU [THANKS FOR USING THE MENU]", method =() => PlaceHolder(), isTogglable = false},
                new ButtonInfo{ buttonText = "JOIN DISCORD", method =() => JoioDiscord(), isTogglable = false},
                new ButtonInfo{ buttonText = "-=Back To Menu=-", method =() => Page1(), isTogglable = false},
            },
        };
    }
}
