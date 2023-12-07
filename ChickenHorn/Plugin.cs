using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCSoundTool;
using UnityEngine;
using HarmonyLib.Tools;
using System.IO;
using UnityEngine.Networking;

namespace ChickenHorn
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class ChickenBase : BaseUnityPlugin
    {
        private const string PLUGIN_GUID = "ChickenAirHorn";
        private const string PLUGIN_NAME = "Chicken Air Horn";
        private const string PLUGIN_VERSION = "1.2.0";

        internal ManualLogSource logger;

        public static AudioClip sound;

        private void Awake()
        {

            logger = BepInEx.Logging.Logger.CreateLogSource(PLUGIN_GUID);

            logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
        }

        private void Start()
        {
            // Here we get the sound from the mod folder
            sound = SoundTool.GetAudioClip("ChickenHorn", "TrimmedChickenHorn.wav");

            // For the test.wav, we just use it to replace one of the main menu button sounds nothing special here. Check LCSoundTool's page for more info.
            SoundTool.ReplaceAudioClip("AirHorn1", sound);
        }
    }
}

