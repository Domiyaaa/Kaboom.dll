using BepInEx;
using UnityEngine;

namespace Kaboom
{
    [BepInPlugin("Domiyaa.Kaboom", "Kaboom", "1.0.0")]
    public class InstantQuitPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            float roll = UnityEngine.Random.Range(0f, 1f);

            if (roll < 0.2f)
            {
                Logger.LogInfo($"LetsGoGambling: {roll:F3}  awh dang it ");

                UnityEngine.Application.Quit();

#if UNITY_STANDALONE
                System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif
            }
            else
            {
                Logger.LogInfo($"LetsGoGambling: {roll:F3} yay!");
            }
        }
    }
}