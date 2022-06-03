﻿using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System.Linq;
using static LasMonjas.HudManagerStartPatch;
using Hazel;
using LasMonjas.Patches;
using LasMonjas.Core;

namespace LasMonjas.Objects
{
    class EngineerTrap
    {
        public static List<EngineerTrap> engineerTraps = new List<EngineerTrap>();
        private Color color;
        public GameObject engineerTrap;
        private SpriteRenderer spriteRenderer;
        private bool touched = false;
        public byte myTrapType = 1;
        private float myTrapDuration = 20;
        private Vector3 position;
        public bool isActive = true;

        private static Sprite accelSprite;
        private static Sprite decelSprite;
        private static Sprite positionSprite;

        public static Sprite getAccelSprite() {
            if (accelSprite) return accelSprite;
            accelSprite = CustomMain.customAssets.accelSprite.GetComponent<SpriteRenderer>().sprite;
            return accelSprite;
        }
        public static Sprite getDecelSprite() {
            if (decelSprite) return decelSprite;
            decelSprite = CustomMain.customAssets.decelSprite.GetComponent<SpriteRenderer>().sprite;
            return decelSprite;
        }
        public static Sprite getPositionSprite() {
            if (positionSprite) return positionSprite;
            positionSprite = CustomMain.customAssets.positionSprite.GetComponent<SpriteRenderer>().sprite;
            return positionSprite;
        }

        public EngineerTrap(float duration, PlayerControl player, byte trapType) {

            this.color = new Color(1f, 1f, 1f, 1f);

            engineerTrap = new GameObject("EngineerTrap" + engineerTraps.Count.ToString());
            engineerTrap.AddSubmergedComponent(SubmergedCompatibility.Classes.ElevatorMover);
            if (PlayerControl.GameOptions.MapId == 5) {
                position = new Vector3(player.transform.position.x, player.transform.position.y, -0.5f);
            }
            else {
                position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1f);
            }
            engineerTrap.transform.position = position;
            engineerTrap.transform.localPosition = position;
            engineerTrap.transform.SetParent(player.transform.parent);

            spriteRenderer = engineerTrap.AddComponent<SpriteRenderer>();
            switch (trapType) {
                case 1:
                    spriteRenderer.sprite = getAccelSprite();
                    break;
                case 2:
                    spriteRenderer.sprite = getDecelSprite();
                    break;
                case 3:
                    spriteRenderer.sprite = getPositionSprite();
                    break;
            }
            myTrapType = trapType;
            myTrapDuration = duration;
            spriteRenderer.color = color;

            // Only render the trap for the Engineer
            var playerIsEngineer = PlayerControl.LocalPlayer == Engineer.engineer;
            if (playerIsEngineer) {
                engineerTrap.gameObject.SetActive(true);
                engineerTrap.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            }
            else {
                engineerTrap.gameObject.SetActive(false);
            }

            engineerTraps.Add(this);            
        }

        public static void clearTraps() {
            engineerTraps = new List<EngineerTrap>();
        }

        public static void activateTraps() {
            foreach (EngineerTrap engineerTrap in engineerTraps) {
                engineerTrap.engineerTrap.gameObject.SetActive(true);
                if (engineerTrap.myTrapType == 3) {
                    if (Engineer.engineer != null && PlayerControl.LocalPlayer == Engineer.engineer) {
                        engineerTrap.engineerTrap.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                    }
                    else {
                        engineerTrap.engineerTrap.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
                    }
                } else {
                    engineerTrap.engineerTrap.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                }

                switch (engineerTrap.myTrapType) {
                    case 1:
                        engineerTrap.spriteRenderer.sprite = getAccelSprite();
                        break;
                    case 2:
                        engineerTrap.spriteRenderer.sprite = getDecelSprite();
                        break;
                    case 3:
                        engineerTrap.spriteRenderer.sprite = getPositionSprite();
                        break;
                }

                HudManager.Instance.StartCoroutine(Effects.Lerp(engineerTrap.myTrapDuration, new Action<float>((p) => {

                    var player = PlayerControl.LocalPlayer;

                    if (Vector2.Distance(player.transform.position, engineerTrap.engineerTrap.transform.position) < 0.5f && !engineerTrap.touched && !player.Data.IsDead && engineerTrap.isActive) {
                        engineerTrap.touched = true;

                        HudManager.Instance.StartCoroutine(Effects.Lerp(5, new Action<float>((p) => {

                            if (p == 1f && engineerTrap.touched) {
                                engineerTrap.touched = false;
                            }

                        })));

                        foreach (EngineerTrap trap in engineerTraps) {
                            if (trap.myTrapType != 3) {
                                trap.isActive = false;
                            }
                        }
                        Engineer.messageTimer = 5;
                        if (engineerTrap.myTrapType != 3) {
                            if (MapBehaviour.Instance) {
                                MapBehaviour.Instance.Close();
                            }
                            SoundManager.Instance.PlaySound(CustomMain.customAssets.treasureHunterPlaceTreasure, false, 100f);
                            new CustomMessage("速度变更!", 5, -1, 1f, 23);
                        }

                        PlayerControl target = Helpers.playerById(player.PlayerId);
                        MessageWriter killWriter = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId, (byte)CustomRPC.ActivateEngineerTrap, Hazel.SendOption.Reliable, -1);
                        killWriter.Write(player.PlayerId);
                        killWriter.Write(engineerTrap.myTrapType);
                        AmongUsClient.Instance.FinishRpcImmediately(killWriter);
                        RPCProcedure.activateEngineerTrap(target.PlayerId, engineerTrap.myTrapType);

                    }                   

                    if (p == 1f && engineerTrap != null) {
                        Engineer.currentTrapNumber -= 1;
                        engineerTrap.engineerTrap.transform.position = new Vector3(-1000, 500, 0);
                        //UnityEngine.Object.Destroy(trap);
                        //traps.Remove(this);                   
                    }

                })));
            }
            return;
        }
    }
}
