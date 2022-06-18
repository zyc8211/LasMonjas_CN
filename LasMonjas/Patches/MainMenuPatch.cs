﻿using HarmonyLib;
using LasMonjas.Core;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Object = UnityEngine.Object;

namespace LasMonjas.Patches
{
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class MainMenuPatch
    {
        private static Color discordButtonColor = new Color32(255, 0, 0, byte.MaxValue);
        private static Color discordButtonColorOnHover = new Color32(200, 0, 0, byte.MaxValue);

        private static void Prefix(MainMenuManager __instance) {
            // Check the music option after loading main menu screen, so when you join the Lobby it starts playing if enabled
            MapOptions.checkMusic();

            // Get the ExitGameButton and create the discord's one
            var exitButton = GameObject.Find("ExitGameButton");

            var discordButton = UnityEngine.Object.Instantiate(exitButton, exitButton.transform.parent);
            discordButton.name = "SGHPhanhuaButton";
            discordButton.transform.position = new Vector3(exitButton.transform.position.x, exitButton.transform.position.y + 0.6f, exitButton.transform.position.z);

            var discordButtonSceneChanger = discordButton.GetComponent<SceneChanger>();
            UnityEngine.Object.Destroy(discordButtonSceneChanger); 
            
            SpriteRenderer discordButtonSprite = discordButton.GetComponent<SpriteRenderer>();

            var discordButtonText = discordButton.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                discordButtonText.SetText("四个憨批\n汉化组");
            })));

            discordButtonSprite.color = discordButtonText.color = discordButtonColor;

            PassiveButton btnDiscordPassive = discordButton.GetComponent<PassiveButton>();
            btnDiscordPassive.OnClick.AddListener((UnityEngine.Events.UnityAction)delegate {
                Application.OpenURL("https://amonguscn.club/");
            });
            btnDiscordPassive.OnMouseOver.AddListener((UnityEngine.Events.UnityAction)delegate {
                discordButtonSprite.color = discordButtonText.color = discordButtonColorOnHover;
            });
            btnDiscordPassive.OnMouseOut.AddListener((UnityEngine.Events.UnityAction)delegate {
                discordButtonSprite.color = discordButtonText.color = discordButtonColor;
            });

        }

    }

    [HarmonyPatch(typeof(Constants), nameof(Constants.ShouldHorseAround))]
    public static class ConstPatch
    {
        public static void Postfix(ref bool __result) {
            __result = LasMonjasPlugin.HorseMode.Value;
        }
    }

    [HarmonyPatch(typeof(AnnouncementPopUp), nameof(AnnouncementPopUp.UpdateAnnounceText))]
    public static class Announcement
    {
        public static ModUpdateBehaviour.UpdateData updateData = null;
        public static bool Prefix(AnnouncementPopUp __instance) {
            if (ModUpdateBehaviour.showPopUp || updateData == null) return true;

            var text = __instance.AnnounceTextMeshPro;
            text.text = $"<size=150%><color=#CC00FFFF>Las Monjas </color> {(updateData.Tag)}\n{(updateData.Content)}";

            return false;
        }
    }
}