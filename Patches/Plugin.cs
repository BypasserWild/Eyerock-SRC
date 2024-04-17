using BepInEx;
using System.ComponentModel;

namespace Eyerock.Patches
{
    [Description(Eyerock.PluginInfo.Description)]
    [BepInPlugin(Eyerock.PluginInfo.GUID, Eyerock.PluginInfo.Name, Eyerock.PluginInfo.Version)]
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
