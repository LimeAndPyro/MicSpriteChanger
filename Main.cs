using LoadSprite;
using MelonLoader;
using System;
using System.Collections;
using UnityEngine;

namespace Mic_Sprite_Changer
{
    public class MicChanger : MelonMod
    {

        public override void OnApplicationStart()
        {

            




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("..............................Are You Lost?......");
            Console.WriteLine("I Updated it lol");
            Console.WriteLine("lol pyro/lime/creed");

        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            var MicIconMute = (Environment.CurrentDirectory + "\\MicIcons\\Mute.png").LoadSpriteFromDisk();
            var MicIcon = (Environment.CurrentDirectory + "\\MicIcons\\Unmute.png").LoadSpriteFromDisk();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Loading Mic");
            GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/VoiceDotParent/VoiceDotDisabled").GetComponent<UnityEngine.UI.Image>().overrideSprite = MicIconMute;
            GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/VoiceDotParent/VoiceDot").GetComponent<UnityEngine.UI.Image>().overrideSprite = MicIcon;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Mic Loaded");
        }

    }
}
   
