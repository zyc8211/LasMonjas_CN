using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LasMonjas.Patches {
    [HarmonyPatch]
    public static class CredentialsPatch {

        public static string mainMenuCredentials = $@"翻译：<color=#BBFFEE>凌霄LX</color> <color=#0000FF>氢氧则名</color> <color=#FFFF37>山羊</color> 美工：<color=#FFC0CB>糖果</color> 汉化封装：<color=#BBFFEE>凌霄LX</color> \n汉化：<color=#FF0000>四个憨批汉化组</color> QQ群：792600803 憨批小站：https://amonguscn.club";

        [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
        private static class VersionShowerPatch
        {
            static void Postfix(VersionShower __instance) {
                var amongUsLogo = GameObject.Find("bannerLogo_AmongUs");
                if (amongUsLogo == null) return;

                var credentials = UnityEngine.Object.Instantiate<TMPro.TextMeshPro>(__instance.text);
                credentials.transform.position = new Vector3(0, 0, 0);
                credentials.SetText($"模组作者: <color=#CC00FFFF>Allul</color>  版本号：v{LasMonjasPlugin.Version.ToString()}\n<size=30f%>\n</size>{mainMenuCredentials}\n<size=30%>\n</size>");
                credentials.alignment = TMPro.TextAlignmentOptions.Center;
                credentials.fontSize *= 0.75f;

                credentials.transform.SetParent(amongUsLogo.transform);
            }
        }

        [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
        private static class PingTrackerPatch
        {

            static void Postfix(PingTracker __instance) {

                __instance.text.text += "\n<color=#CC00FFFF>Las Monjas v2.0.3</color>\n汉化：<color=#FF0000>四个憨批汉化组</color>\n<size=50%>翻译：<color=#BBFFEE>凌霄LX</color> <color=#0000FF>氢氧则名</color> <color=#FFFF37>山羊</color> 美工：<color=#FFC0CB>糖果</color> 实装：<color=#BBFFEE>凌霄LX</color>\n憨批小站：https://amonguscn.club</size>";
                __instance.transform.localPosition = new Vector3(1.25f, 3f, __instance.transform.localPosition.z);
            }
        }     

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
        private static class LogoPatch
        {
            static void Postfix(PingTracker __instance) {
                var amongUsLogo = GameObject.Find("bannerLogo_AmongUs");
                if (amongUsLogo != null) {
                    amongUsLogo.transform.localScale *= 0.6f;
                    amongUsLogo.transform.position += Vector3.up * 0.25f;
                }

                var lasMonjasLogo = new GameObject("bannerLogo_LasMonjas");
                lasMonjasLogo.transform.position = Vector3.up;
                var renderer = lasMonjasLogo.AddComponent<SpriteRenderer>();
                renderer.sprite = Helpers.loadSpriteFromResources("LasMonjas.Images.Banner.png", 300f);                                
            }
        }
    }
}
