using System.Collections.Generic;
using UnityEngine;
using BepInEx.Configuration;
using System;
using System.Linq;
using HarmonyLib;
using Hazel;
using System.Reflection;
using System.Text;
using static LasMonjas.LasMonjas;
using LasMonjas.Core;

namespace LasMonjas
{
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "100%"}; 
        public static string[] presets = new string[]{"多职业模式", "夺旗赛", "警察抓小偷", "山丘之王", "烫手山芋", "生化危机", "预设 7", "预设 8", "预设 9", "预设 10" };

        // Game Options 
        public static CustomOption presetSelection;

        // Global Settings
        public static CustomOption globalSettings;
        public static CustomOption activateRoles;
        public static CustomOption activateSenseiMap;
        public static CustomOption removeSwipeCard;
        public static CustomOption removeAirshipDoors;
        public static CustomOption nightVisionLightSabotage;
        public static CustomOption screenShakeReactorSabotage;
        public static CustomOption anonymousCommsSabotage;
        public static CustomOption slowSpeedOxigenSabotage;
        public static CustomOption hideVentAnimOnShadows;

        // Modifiers
        public static CustomOption activateModifiers;
        public static CustomOption loverPlayer;
        public static CustomOption lighterPlayer;
        public static CustomOption blindPlayer;
        public static CustomOption flashPlayer;
        public static CustomOption bigchungusPlayer;
        public static CustomOption theChosenOnePlayer;
        public static CustomOption theChosenOneReportDelay;
        public static CustomOption performerPlayer;
        public static CustomOption performerDuration;
        public static CustomOption proPlayer;

        // Capture the flag
        public static CustomOption captureTheFlagMode;
        public static CustomOption flagMatchDuration;
        public static CustomOption requiredFlags;
        public static CustomOption flagKillCooldown;
        public static CustomOption flagReviveTime;
        public static CustomOption flagInvincibilityTimeAfterRevive;

        // Police And Thief
        public static CustomOption policeAndThiefMode;
        public static CustomOption thiefModeMatchDuration;
        public static CustomOption thiefModerequiredJewels;
        public static CustomOption thiefModePoliceKillCooldown;
        public static CustomOption thiefModePoliceTaseCooldown;
        public static CustomOption thiefModePoliceTaseDuration;
        public static CustomOption thiefModePoliceCanSeeJewels;
        public static CustomOption thiefModePoliceCatchCooldown;
        public static CustomOption thiefModecaptureThiefTime;
        public static CustomOption thiefModepolicevision;
        public static CustomOption thiefModePoliceReviveTime;
        public static CustomOption thiefModeWhoCanThiefsKill;
        public static CustomOption thiefModeKillCooldown;
        public static CustomOption thiefModeThiefReviveTime;
        public static CustomOption thiefModeInvincibilityTimeAfterRevive;

        // King of the hill
        public static CustomOption kingOfTheHillMode;
        public static CustomOption kingMatchDuration;
        public static CustomOption kingRequiredPoints;
        public static CustomOption kingCaptureCooldown;
        public static CustomOption kingKillCooldown;
        public static CustomOption kingCanKill;
        public static CustomOption kingReviveTime;
        public static CustomOption kingInvincibilityTimeAfterRevive;

        // Hot Potato
        public static CustomOption hotPotatoMode;
        public static CustomOption hotPotatoMatchDuration;
        public static CustomOption hotPotatoTransferLimit;
        public static CustomOption hotPotatoCooldown;
        public static CustomOption hotPotatoNotPotatovision;
        public static CustomOption hotPotatoResetTimeForTransfer;
        public static CustomOption hotPotatoIncreaseTimeIfNoReset;

        // ZombieLaboratory
        public static CustomOption zombieLaboratoryMode;
        public static CustomOption zombieLaboratoryMatchDuration;
        public static CustomOption zombieLaboratoryStartZombies;
        public static CustomOption zombieLaboratoryInfectCooldown;
        public static CustomOption zombieLaboratoryKillCooldown;
        public static CustomOption zombieLaboratoryReviveTime;
        public static CustomOption zombieLaboratoryInvincibilityTimeAfterRevive;
        public static CustomOption zombieLaboratoryInfectTime;
        public static CustomOption zombieLaboratoryTimeForHeal;
        public static CustomOption zombieLaboratoryWhoCanZombiesKill;
        public static CustomOption zombieLaboratorySurvivorsVision;
        public static CustomOption zombieLaboratorySearchBoxTimer;
        
        
        // Impostors configurable options

        // Mimic
        public static CustomOption mimicSpawnRate;
        public static CustomOption mimicDuration;

        // Painter
        public static CustomOption painterSpawnRate;
        public static CustomOption painterCooldown;
        public static CustomOption painterDuration;

        // Demon
        public static CustomOption demonSpawnRate;
        public static CustomOption demonKillDelay;
        public static CustomOption demonCanKillNearNuns;

        // Janitor
        public static CustomOption janitorSpawnRate;
        public static CustomOption janitorCooldown;

        // Illusionist
        public static CustomOption illusionistSpawnRate;
        public static CustomOption illusionistPlaceHatCooldown;
        public static CustomOption illusionistLightsOutCooldown;
        public static CustomOption illusionistLightsOutDuration;

        // Manipulator
        public static CustomOption manipulatorSpawnRate;

        // Bomberman
        public static CustomOption bombermanSpawnRate;
        public static CustomOption bombermanBombCooldown;

        // Chameleon
        public static CustomOption chameleonSpawnRate;
        public static CustomOption chameleonCooldown;
        public static CustomOption chameleonDuration;

        // Gambler
        public static CustomOption gamblerSpawnRate;
        public static CustomOption gamblerNumberOfShots;
        public static CustomOption gamblerCanCallEmergency;
        public static CustomOption gamblerCanShootMultipleTimes;
        public static CustomOption gamblerCanKillThroughShield;

        // Sorcerer
        public static CustomOption sorcererSpawnRate;
        public static CustomOption sorcererCooldown;
        public static CustomOption sorcererAdditionalCooldown;
        public static CustomOption sorcererSpellDuration;
        public static CustomOption sorcererCanCallEmergency;

        // Medusa
        public static CustomOption medusaSpawnRate;
        public static CustomOption medusaCooldown;
        public static CustomOption medusaDelay;
        public static CustomOption medusaDuration;

        // Hypnotist
        public static CustomOption hypnotistSpawnRate;
        public static CustomOption hypnotistCooldown;
        public static CustomOption hypnotistNumberOfSpirals;
        public static CustomOption hypnotistSpiralsDuration;
        
        // Archer
        public static CustomOption archerSpawnRate;
        public static CustomOption archerShotSize;
        public static CustomOption archerShotRange;
        public static CustomOption archerNoticeRange;
        public static CustomOption archerAimAssistDuration;
        
        // Rebels configurable options

        // Renegade & Minion
        public static CustomOption renegadeSpawnRate;
        public static CustomOption renegadeCreateMinionCooldown;
        public static CustomOption renegadeCanUseVents;
        public static CustomOption renegadeCanRecruitMinion;    

        // Bountyhunter
        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterCooldown;

        // Trapper
        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMineNumber;
        public static CustomOption trapperMineDuration; 
        public static CustomOption trapperTrapNumber;
        public static CustomOption trapperTrapDuration;

        // Yinyanger
        public static CustomOption yinyangerSpawnRate;
        public static CustomOption yinyangerCooldown;

        // Challenger
        public static CustomOption challengerSpawnRate;
        public static CustomOption challengerCooldown;

        // Ninja
        public static CustomOption ninjaSpawnRate;

        // Berserker
        public static CustomOption berserkerSpawnRate;
        public static CustomOption berserkerTimeToKill;


        // Neutral configurable options

        // Joker
        public static CustomOption jokerSpawnRate;
        public static CustomOption jokerCanSabotage;

        // Role Thief
        public static CustomOption rolethiefSpawnRate;
        public static CustomOption rolethiefCooldown;

        // Pyromaniac
        public static CustomOption pyromaniacSpawnRate;
        public static CustomOption pyromaniacCooldown;
        public static CustomOption pyromaniacDuration;

        // Treasure Hunter
        public static CustomOption treasureHunterSpawnRate;
        public static CustomOption treasureHunterCooldown;
        public static CustomOption treasureHunterTreasureNumber;
        public static CustomOption treasureHunterCanCallEmergency;

        // Devourer
        public static CustomOption devourerSpawnRate;
        public static CustomOption devourerCooldown;
        public static CustomOption devourerBodiesNumber;

        // Poisoner
        public static CustomOption poisonerSpawnRate;
        public static CustomOption poisonerCooldown;
        public static CustomOption poisonerDuration;
        public static CustomOption poisonerInfectRange;
        public static CustomOption poisonerInfectDuration;
        public static CustomOption poisonerCanSabotage;

        // Puppeteer
        public static CustomOption puppeteerSpawnRate;
        public static CustomOption puppeteerNumberOfKills;


        // Crewmates configurable options

        // Captain
        public static CustomOption captainSpawnRate;

        // Mechanic
        public static CustomOption mechanicSpawnRate;
        public static CustomOption mechanicNumberOfRepairs;

        // Sheriff
        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCanKillNeutrals;

        // Detective
        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveShowFootprints;
        public static CustomOption detectiveCooldown;
        public static CustomOption detectiveShowFootPrintDuration;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;

        // Forensic
        public static CustomOption forensicSpawnRate;
        public static CustomOption forensicReportNameDuration;
        public static CustomOption forensicReportColorDuration;
        public static CustomOption forensicReportClueDuration;
        public static CustomOption forensicCooldown;
        public static CustomOption forensicDuration;
        public static CustomOption forensicOneTimeUse;

        // TimeTraveler
        public static CustomOption timeTravelerSpawnRate;
        public static CustomOption timeTravelerCooldown;
        public static CustomOption timeTravelerRewindTime;
        public static CustomOption timeTravelerShieldDuration;
        public static CustomOption timeTravelerReviveDuringRewind;

        // Squire
        public static CustomOption squireSpawnRate;
        public static CustomOption squireShowShielded;
        public static CustomOption squireShowAttemptToShielded;
        public static CustomOption squireResetShieldAfterMeeting;

        // Cheater
        public static CustomOption cheaterSpawnRate;
        public static CustomOption cheaterCanCallEmergency;
        public static CustomOption cheatercanOnlyCheatOthers;

        // FortuneTeller
        public static CustomOption fortuneTellerSpawnRate;
        public static CustomOption fortuneTellerCooldown;
        public static CustomOption fortuneTellerDuration; 
        public static CustomOption fortuneTellerNumberOfSee;
        public static CustomOption fortuneTellerKindOfInfo;
        public static CustomOption fortuneTellerPlayersWithNotification;

        // Hacker
        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;

        // Sleuth
        public static CustomOption sleuthSpawnRate;
        public static CustomOption sleuthUpdateIntervall;
        public static CustomOption sleuthResetTargetAfterMeeting;
        public static CustomOption sleuthCorpsesPathfindCooldown;
        public static CustomOption sleuthCorpsesPathfindDuration;

        // Fink
        public static CustomOption finkSpawnRate;
        public static CustomOption finkLeftTasksForImpostors;
        public static CustomOption finkIncludeTeamRenegade;
        public static CustomOption finkCooldown;
        public static CustomOption finkDuration;

        // Kid
        public static CustomOption kidSpawnRate;

        // Welder
        public static CustomOption welderSpawnRate;
        public static CustomOption welderCooldown;
        public static CustomOption welderTotalWelds;

        // Spiritualist
        public static CustomOption spiritualistSpawnRate;
        public static CustomOption spiritualistReviveTime;       

        // Vigilant
        public static CustomOption vigilantSpawnRate;
        public static CustomOption vigilantCooldown;
        public static CustomOption vigilantCamDuration;
        public static CustomOption vigilantCamMaxCharges;
        public static CustomOption vigilantCamRechargeTasksNumber;      
        
        // Hunter
        public static CustomOption hunterSpawnRate;
        public static CustomOption hunterResetTargetAfterMeeting;

        // Jinx
        public static CustomOption jinxSpawnRate;
        public static CustomOption jinxCooldown;
        public static CustomOption jinxJinxsNumber;

        // Coward
        public static CustomOption cowardSpawnRate;
        public static CustomOption cowardNumberOfCalls;

        // Bat
        public static CustomOption batSpawnRate;
        public static CustomOption batCooldown;
        public static CustomOption batDuration;
        public static CustomOption batRange;

        // Necromancer
        public static CustomOption necromancerSpawnRate;
        public static CustomOption necromancerReviveCooldown;
        public static CustomOption necromancerReviveTimer;
        public static CustomOption necromancerMaxReviveRoomDistance;

        // Engineer
        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerCooldown;
        public static CustomOption engineerNumberOfTraps;
        public static CustomOption engineerTrapsDuration;
        public static CustomOption engineerAccelTrapIncrease;
        public static CustomOption engineerDecelTrapDecrease;

        // Shy
        public static CustomOption shySpawnRate;
        public static CustomOption shyCooldown;
        public static CustomOption shyDuration;
        public static CustomOption shyArrowRange;
        public static CustomOption shyPlayerColor;

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {
            
            // Game Options
            presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "预设"), "setting", presets, null, true);

            // Global Settings
            activateSenseiMap = CustomOption.Create(3, cs(Kid.color, "激活千年隼号地图"), "setting", false, null, true);
            globalSettings = CustomOption.Create(4, cs(Detective.color, "职业设置"), "setting", false, null, true);
            activateRoles = CustomOption.Create(5, cs(Detective.color, "启用模组职业并禁用原版职业"), "setting", true, globalSettings);
            removeSwipeCard = CustomOption.Create(6, cs(Detective.color, "移除刷卡任务"), "setting", false, globalSettings);
            removeAirshipDoors = CustomOption.Create(7, cs(Detective.color, "移除飞艇地图的门"), "setting", false, globalSettings);
            nightVisionLightSabotage = CustomOption.Create(8, cs(Detective.color, "关灯时监控显示隐蔽状态"), "setting", false, globalSettings);
            screenShakeReactorSabotage = CustomOption.Create(9, cs(Detective.color, "反应堆破坏时震动屏幕"), "setting", false, globalSettings);
            anonymousCommsSabotage = CustomOption.Create(10, cs(Detective.color, "通讯破坏时进入隐蔽状态"), "setting", false, globalSettings);
            slowSpeedOxigenSabotage = CustomOption.Create(11, cs(Detective.color, "氧气破坏时降低行动速度"), "setting", false, globalSettings);
            hideVentAnimOnShadows = CustomOption.Create(12, cs(Detective.color, "隐藏阴影中的通风口动画"), "setting", false, globalSettings);

            // Modifiers
            activateModifiers = CustomOption.Create(15, cs(Modifiers.color, "附加职业"), "setting", false, null, true);
            loverPlayer = CustomOption.Create(16, cs(Modifiers.color, "恋人"), "setting", rates, activateModifiers, false);
            lighterPlayer = CustomOption.Create(17, cs(Modifiers.color, "执灯人"), "setting", rates, activateModifiers, false);
            blindPlayer = CustomOption.Create(18, cs(Modifiers.color, "失明者"), "setting", rates, activateModifiers, false);
            flashPlayer = CustomOption.Create(19, cs(Modifiers.color, "闪电侠"), "setting", rates, activateModifiers, false);
            bigchungusPlayer = CustomOption.Create(20, cs(Modifiers.color, "巨人"), "setting", rates, activateModifiers, false);
            theChosenOnePlayer = CustomOption.Create(21, cs(Modifiers.color, "诱饵"), "setting", rates, activateModifiers, false);
            theChosenOneReportDelay = CustomOption.Create(22, cs(Modifiers.color, "诱饵") + ": 报警延迟", "setting", 0f, 0f, 5f, 1f, activateModifiers);
            performerPlayer = CustomOption.Create(23, cs(Modifiers.color, "广播员"), "setting", rates, activateModifiers, false);
            performerDuration = CustomOption.Create(24, cs(Modifiers.color, "广播员") + ": 警报持续时长", "setting", 20f, 10f, 30f, 1f, activateModifiers);
            proPlayer = CustomOption.Create(25, cs(Modifiers.color, "醉鬼"), "setting", rates, activateModifiers, false);

            // Capture the flag mode
            captureTheFlagMode = CustomOption.Create(30, cs(Sheriff.color, "夺旗赛"), "gamemode", false, null, true);
            flagMatchDuration = CustomOption.Create(31, cs(Sheriff.color, "夺旗赛") + ": 比赛时长", "gamemode", 180f, 180f, 300f, 30f, captureTheFlagMode);
            requiredFlags = CustomOption.Create(32, cs(Sheriff.color, "夺旗赛") + ": 获胜所需分数", "gamemode", 3f, 3f, 5f, 1f, captureTheFlagMode);
            flagKillCooldown = CustomOption.Create(33, cs(Sheriff.color, "夺旗赛") + ": 击杀冷却", "gamemode", 10f, 5f, 15f, 1f, captureTheFlagMode);
            flagReviveTime = CustomOption.Create(34, cs(Sheriff.color, "夺旗赛") + ": 复活等待时间", "gamemode", 8f, 7f, 15f, 1f, captureTheFlagMode);
            flagInvincibilityTimeAfterRevive = CustomOption.Create(35, cs(Sheriff.color, "夺旗赛") + ": 复活后无敌时长", "gamemode", 3f, 2f, 5f, 1f, captureTheFlagMode);

            // Police and Thief mode
            policeAndThiefMode = CustomOption.Create(40, cs(Coward.color, "警察抓小偷"), "gamemode", false, null, true);
            thiefModeMatchDuration = CustomOption.Create(41, cs(Coward.color, "警察抓小偷") + ": 比赛时长", "gamemode", 300f, 300f, 450f, 30f, policeAndThiefMode);
            thiefModerequiredJewels = CustomOption.Create(42, cs(Coward.color, "警察抓小偷") + ": 珠宝数量", "gamemode", 15f, 8f, 15f, 1f, policeAndThiefMode);
            thiefModePoliceKillCooldown = CustomOption.Create(43, cs(Coward.color, "警察抓小偷") + ": 警察击杀冷却", "gamemode", 15f, 10f, 20f, 1f, policeAndThiefMode);
            thiefModePoliceCatchCooldown = CustomOption.Create(44, cs(Coward.color, "警察抓小偷") + ": 警察逮捕冷却", "gamemode", 10f, 5f, 15f, 1f, policeAndThiefMode);
            thiefModecaptureThiefTime = CustomOption.Create(45, cs(Coward.color, "警察抓小偷") + ": 逮捕所需时间", "gamemode", 3f, 2f, 5f, 1f, policeAndThiefMode);
            thiefModePoliceTaseCooldown = CustomOption.Create(46, cs(Coward.color, "警察抓小偷") + ": 警察电击枪冷却", "gamemode", 15f, 10f, 20f, 1f, policeAndThiefMode);
            thiefModePoliceTaseDuration = CustomOption.Create(47, cs(Coward.color, "警察抓小偷") + ": 警察电击枪持续时间", "gamemode", 3f, 3f, 5f, 1f, policeAndThiefMode);
            thiefModePoliceCanSeeJewels = CustomOption.Create(48, cs(Coward.color, "警察抓小偷") + ": 警察可见宝石", "gamemode", false, policeAndThiefMode);
            thiefModepolicevision = CustomOption.Create(49, cs(Coward.color, "警察抓小偷") + ": 警察视野范围", "gamemode", 0.8f, 0.4f, 1.4f, 0.2f, policeAndThiefMode);
            thiefModePoliceReviveTime = CustomOption.Create(50, cs(Coward.color, "警察抓小偷") + ": 警察复活等待时间", "gamemode", 8f, 8f, 13f, 1f, policeAndThiefMode);
            thiefModeWhoCanThiefsKill = CustomOption.Create(51, cs(Coward.color, "警察抓小偷") + ": 小偷可击杀", "gamemode", new string[] { "电击枪", "所有人", "无" }, policeAndThiefMode);
            thiefModeKillCooldown = CustomOption.Create(52, cs(Coward.color, "警察抓小偷") + ": 小偷击杀冷却", "gamemode", 20f, 15f, 30f, 1f, policeAndThiefMode);
            thiefModeThiefReviveTime = CustomOption.Create(53, cs(Coward.color, "警察抓小偷") + ": 小偷复活等待时间", "gamemode", 13f, 13f, 23f, 1f, policeAndThiefMode);
            thiefModeInvincibilityTimeAfterRevive = CustomOption.Create(54, cs(Coward.color, "警察抓小偷") + ": 复活后无敌时间", "gamemode", 3f, 2f, 5f, 1f, policeAndThiefMode);

            // King of the hill mode
            kingOfTheHillMode = CustomOption.Create(60, cs(Squire.color, "山丘之王"), "gamemode", false, null, true);
            kingMatchDuration = CustomOption.Create(61, cs(Squire.color, "山丘之王") + ": 比赛时长", "gamemode", 180f, 180f, 300f, 30f, kingOfTheHillMode);
            kingRequiredPoints = CustomOption.Create(62, cs(Squire.color, "山丘之王") + ": 获胜所需分数", "gamemode", 200f, 100f, 300f, 10f, kingOfTheHillMode);
            kingCaptureCooldown = CustomOption.Create(63, cs(Squire.color, "山丘之王") + ": 占点所需时间", "gamemode", 10f, 5f, 15f, 1f, kingOfTheHillMode);
            kingKillCooldown = CustomOption.Create(64, cs(Squire.color, "山丘之王") + ": 击杀冷却", "gamemode", 10f, 10f, 20f, 1f, kingOfTheHillMode);
            kingCanKill = CustomOption.Create(65, cs(Squire.color, "山丘之王") + ": 国王可击杀", "gamemode", false, kingOfTheHillMode);
            kingReviveTime = CustomOption.Create(66, cs(Squire.color, "山丘之王") + ": 复活等待时间", "gamemode", 13f, 13f, 18f, 1f, kingOfTheHillMode);
            kingInvincibilityTimeAfterRevive = CustomOption.Create(67, cs(Squire.color, "山丘之王") + ": 复活后无敌时间", "gamemode", 3f, 2f, 5f, 1f, kingOfTheHillMode);

            // Hot Potato
            hotPotatoMode = CustomOption.Create(70, cs(Shy.color, "烫手山芋"), "gamemode", false, null, true);
            hotPotatoMatchDuration = CustomOption.Create(71, cs(Shy.color, "烫手山芋") + ": 比赛时长", "gamemode", 300f, 300f, 450f, 30f, hotPotatoMode);
            hotPotatoTransferLimit = CustomOption.Create(72, cs(Shy.color, "烫手山芋") + ": 烫手山芋爆炸倒计时", "gamemode", 20f, 10f, 30f, 1f, hotPotatoMode);
            hotPotatoCooldown = CustomOption.Create(73, cs(Shy.color, "烫手山芋") + ": 烫手山芋传递冷却", "gamemode", 5f, 5f, 10f, 1f, hotPotatoMode);
            hotPotatoNotPotatovision = CustomOption.Create(74, cs(Shy.color, "烫手山芋") + ": 冷山芋视野", "gamemode", 0.8f, 0.7f, 1f, 0.1f, hotPotatoMode);
            hotPotatoResetTimeForTransfer = CustomOption.Create(75, cs(Shy.color, "烫手山芋") + ": 传递后重置烫手山芋爆炸倒计时", "gamemode", true, hotPotatoMode);
            hotPotatoIncreaseTimeIfNoReset = CustomOption.Create(76, cs(Shy.color, "烫手山芋") + ": 不重置倒计时时追加时间", "gamemode", 5f, 5f, 10f, 1f, hotPotatoMode);

            // ZombieLaboratory
            zombieLaboratoryMode = CustomOption.Create(80, cs(Hunter.color, "生化危机"), "gamemode", false, null, true);
            zombieLaboratoryMatchDuration = CustomOption.Create(81, cs(Hunter.color, "生化危机") + ": 比赛时长", "gamemode", 300f, 300f, 450f, 30f, zombieLaboratoryMode);
            zombieLaboratoryStartZombies = CustomOption.Create(82, cs(Hunter.color, "生化危机") + ": 初始僵尸数", "gamemode", 1f, 1f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInfectTime = CustomOption.Create(83, cs(Hunter.color, "生化危机") + ": 僵尸感染幸存者所需时间", "gamemode", 3f, 3f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInfectCooldown = CustomOption.Create(84, cs(Hunter.color, "生化危机") + ": 僵尸感染冷却时间", "gamemode", 10f, 10f, 20f, 1f, zombieLaboratoryMode);
            zombieLaboratorySearchBoxTimer = CustomOption.Create(85, cs(Hunter.color, "生化危机") + ": 幸存者打开箱子所需时间", "gamemode", 5f, 3f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratorySurvivorsVision = CustomOption.Create(86, cs(Hunter.color, "生化危机") + ": 幸存者视野", "gamemode", 0.8f, 0.8f, 1f, 0.1f, zombieLaboratoryMode);
            zombieLaboratoryTimeForHeal = CustomOption.Create(87, cs(Hunter.color, "生化危机") + ": 护士治愈受感染者所需时间", "gamemode", 15f, 10f, 30f, 1f, zombieLaboratoryMode);
            zombieLaboratoryWhoCanZombiesKill = CustomOption.Create(88, cs(Hunter.color, "生化危机") + ": 僵尸可击杀目标", "gamemode", new string[] { "幸存者", "所有人", "无" }, zombieLaboratoryMode);
            zombieLaboratoryKillCooldown = CustomOption.Create(89, cs(Hunter.color, "生化危机") + ": 击杀冷却", "gamemode", 10f, 10f, 20f, 1f, zombieLaboratoryMode);
            zombieLaboratoryReviveTime = CustomOption.Create(90, cs(Hunter.color, "生化危机") + ": 复活所需时间", "gamemode", 8f, 8f, 13f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInvincibilityTimeAfterRevive = CustomOption.Create(91, cs(Hunter.color, "生化危机") + ": 复活后的无敌时间", "gamemode", 3f, 2f, 5f, 1f, zombieLaboratoryMode);
            
            // Mimic options
            mimicSpawnRate = CustomOption.Create(150, cs(Mimic.color, "化形者"), "impostor", rates, null, true);
            mimicDuration = CustomOption.Create(151, cs(Mimic.color, "化形者") + ": 化形持续时间", "impostor", 10f, 10f, 15f, 1f, mimicSpawnRate);

            // Painter options
            painterSpawnRate = CustomOption.Create(160, cs(Painter.color, "隐蔽者"), "impostor", rates, null, true);
            painterCooldown = CustomOption.Create(161, cs(Painter.color, "隐蔽者") + ": 隐蔽冷却", "impostor", 30f, 20f, 40f, 2.5f, painterSpawnRate);
            painterDuration = CustomOption.Create(162, cs(Painter.color, "隐蔽者") + ": 隐蔽持续时间", "impostor", 10f, 10f, 15f, 1f, painterSpawnRate);

            // Demon options
            demonSpawnRate = CustomOption.Create(170, cs(Demon.color, "吸血鬼"), "impostor", rates, null, true);
            demonKillDelay = CustomOption.Create(171, cs(Demon.color, "吸血鬼") + ": 击杀延迟", "impostor", 10f, 5f, 15f, 1f, demonSpawnRate);
            demonCanKillNearNuns = CustomOption.Create(172, cs(Demon.color, "吸血鬼") + ": 可以在修女附近进行普通击杀", "impostor", false, demonSpawnRate);

            // Janitor options
            janitorSpawnRate = CustomOption.Create(180, cs(Janitor.color, "清理者"), "impostor", rates, null, true);
            janitorCooldown = CustomOption.Create(181, cs(Janitor.color, "清理者") + ": 清理冷却", "impostor", 30f, 20f, 40f, 2.5f, janitorSpawnRate);

            // Illusionist options
            illusionistSpawnRate = CustomOption.Create(190, cs(Illusionist.color, "骗术师"), "impostor", rates, null, true);
            illusionistPlaceHatCooldown = CustomOption.Create(191, cs(Illusionist.color, "骗术师") + ": 放置骗术帽冷却", "impostor", 20f, 15f, 30f, 1f, illusionistSpawnRate);
            illusionistLightsOutCooldown = CustomOption.Create(192, cs(Illusionist.color, "骗术师") + ": 熄灯冷却", "impostor", 30f, 20f, 40f, 1f, illusionistSpawnRate);
            illusionistLightsOutDuration = CustomOption.Create(193, cs(Illusionist.color, "骗术师") + ": 熄灯持续时间", "impostor", 10f, 5f, 15f, 1f, illusionistSpawnRate);

            // Manipulator options
            manipulatorSpawnRate = CustomOption.Create(200, cs(Manipulator.color, "术士"), "impostor", rates, null, true);

            // Bomberman options
            bombermanSpawnRate = CustomOption.Create(210, cs(Bomberman.color, "爆破者"), "impostor", rates, null, true);
            bombermanBombCooldown = CustomOption.Create(211, cs(Bomberman.color, "爆破者") + ": 炸弹冷却", "impostor", 40f, 30f, 60f, 5f, bombermanSpawnRate);

            // Chameleon options
            chameleonSpawnRate = CustomOption.Create(220, cs(Chameleon.color, "隐身人"), "impostor", rates, null, true);
            chameleonCooldown = CustomOption.Create(221, cs(Chameleon.color, "隐身人") + ": 隐身冷却", "impostor", 30f, 20f, 40f, 2.5f, chameleonSpawnRate);
            chameleonDuration = CustomOption.Create(222, cs(Chameleon.color, "隐身人") + ": 隐身持续时间", "impostor", 10f, 10f, 15f, 1f, chameleonSpawnRate);

            // Gambler options
            gamblerSpawnRate = CustomOption.Create(230, cs(Gambler.color, "赌怪"), "impostor", rates, null, true);
            gamblerNumberOfShots = CustomOption.Create(231, cs(Gambler.color, "赌怪") + ": 可赌次数", "impostor", 3f, 1f, 3f, 1f, gamblerSpawnRate);
            gamblerCanCallEmergency = CustomOption.Create(232, cs(Gambler.color, "赌怪") + ": 可召开紧急会议", "impostor", false, gamblerSpawnRate);
            gamblerCanShootMultipleTimes = CustomOption.Create(233, cs(Gambler.color, "赌怪") + ": 会议中可多次猜测", "impostor", true, gamblerSpawnRate);
            gamblerCanKillThroughShield = CustomOption.Create(234, cs(Gambler.color, "赌怪") + ": 猜测无视护盾", "impostor", false, gamblerSpawnRate);

            // Sorcerer Options
            sorcererSpawnRate = CustomOption.Create(240, cs(Sorcerer.color, "女巫"), "impostor", rates, null, true);
            sorcererCooldown = CustomOption.Create(241, cs(Sorcerer.color, "女巫") + ": 下咒冷却", "impostor", 20f, 20f, 40f, 2.5f, sorcererSpawnRate);
            sorcererAdditionalCooldown = CustomOption.Create(242, cs(Sorcerer.color, "女巫") + ": 下咒追加冷却时间", "impostor", 5f, 5f, 10f, 1f, sorcererSpawnRate);
            sorcererSpellDuration = CustomOption.Create(244, cs(Sorcerer.color, "女巫") + ": 下咒所需时间", "impostor", 3f, 3f, 5f, 1f, sorcererSpawnRate);
            sorcererCanCallEmergency = CustomOption.Create(245, cs(Sorcerer.color, "女巫") + ": 女巫可召开紧急会议", "impostor", false, sorcererSpawnRate);

            // Medusa options
            medusaSpawnRate = CustomOption.Create(250, cs(Medusa.color, "美杜莎"), "impostor", rates, null, true);
            medusaCooldown = CustomOption.Create(251, cs(Medusa.color, "美杜莎") + ": 石化冷却", "impostor", 20f, 15f, 30f, 2.5f, medusaSpawnRate);
            medusaDelay = CustomOption.Create(252, cs(Medusa.color, "美杜莎") + ": 石化延迟", "impostor", 10f, 5f, 10f, 1f, medusaSpawnRate);
            medusaDuration = CustomOption.Create(253, cs(Medusa.color, "美杜莎") + ": 石化持续时间", "impostor", 10f, 5f, 10f, 1f, medusaSpawnRate);

            // Hypnotist options
            hypnotistSpawnRate = CustomOption.Create(260, cs(Hypnotist.color, "催眠师"), "impostor", rates, null, true);
            hypnotistCooldown = CustomOption.Create(261, cs(Hypnotist.color, "催眠师") + ": 技能冷却", "impostor", 20f, 15f, 30f, 1f, hypnotistSpawnRate);
            hypnotistNumberOfSpirals = CustomOption.Create(262, cs(Hypnotist.color, "催眠师") + ": 使用次数", "impostor", 5f, 1f, 5f, 1f, hypnotistSpawnRate);
            hypnotistSpiralsDuration = CustomOption.Create(263, cs(Hypnotist.color, "催眠师") + ": 技能效果持续时间", "impostor", 20f, 10f, 30f, 1f, hypnotistSpawnRate);

            // Archer options
            archerSpawnRate = CustomOption.Create(270, cs(Archer.color, "弓箭手"), "impostor", rates, null, true);
            archerShotSize = CustomOption.Create(271, cs(Archer.color, "弓箭手") + ": 箭矢尺寸", "impostor", 2f, 1f, 3f, 1f, archerSpawnRate);
            archerShotRange = CustomOption.Create(272, cs(Archer.color, "弓箭手") + ": 攻击范围", "impostor", 5f, 5f, 15f, 1f, archerSpawnRate);
            archerNoticeRange = CustomOption.Create(273, cs(Archer.color, "弓箭手") + ": 攻击通知范围", "impostor", 10f, 10f, 30f, 2.5f, archerSpawnRate);
            archerAimAssistDuration = CustomOption.Create(274, cs(Archer.color, "弓箭手") + ": 瞄准时间", "impostor", 10f, 3f, 10f, 1f, archerSpawnRate);

            /// Renegade & Minion options
            renegadeSpawnRate = CustomOption.Create(280, cs(Renegade.color, "变节者"), "rebel", rates, null, true);
            renegadeCreateMinionCooldown = CustomOption.Create(281, cs(Renegade.color, "变节者") + ": 招募爪牙冷却", "rebel", 10f, 10f, 20f, 2.5f, renegadeSpawnRate);
            renegadeCanUseVents = CustomOption.Create(282, cs(Renegade.color, "变节者") + ": 可以使用管道", "rebel", true, renegadeSpawnRate);
            renegadeCanRecruitMinion = CustomOption.Create(283, cs(Renegade.color, "变节者") + ": 可以招募爪牙", "rebel", true, renegadeSpawnRate);

            // Bountyhunter options
            bountyHunterSpawnRate = CustomOption.Create(290, cs(BountyHunter.color, "赏金猎人"), "rebel", rates, null, true);
            bountyHunterCooldown = CustomOption.Create(291, cs(BountyHunter.color, "赏金猎人") + ": 击杀冷却", "rebel", 15f, 10f, 20f, 1f, bountyHunterSpawnRate);

            // Trapper options
            trapperSpawnRate = CustomOption.Create(300, cs(Trapper.color, "陷阱师"), "rebel", rates, null, true);
            trapperCooldown = CustomOption.Create(301, cs(Trapper.color, "陷阱师") + ": 陷阱放置冷却", "rebel", 15f, 15f, 30f, 1f, trapperSpawnRate);
            trapperMineNumber = CustomOption.Create(302, cs(Trapper.color, "陷阱师") + ": 可放置地雷数", "rebel", 3f, 1f, 3f, 1f, trapperSpawnRate);
            trapperMineDuration = CustomOption.Create(303, cs(Trapper.color, "陷阱师") + ": 放置地雷有效时间", "rebel", 45f, 30f, 60f, 5f, trapperSpawnRate);
            trapperTrapNumber = CustomOption.Create(304, cs(Trapper.color, "陷阱师") + ": 可放置捕兽夹数", "rebel", 3f, 1f, 5f, 1f, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(305, cs(Trapper.color, "陷阱师") + ": 放置捕兽夹有效时间", "rebel", 60f, 30f, 120f, 5f, trapperSpawnRate);
            
            // Yinyanger options
            yinyangerSpawnRate = CustomOption.Create(310, cs(Yinyanger.color, "阴阳师"), "rebel", rates, null, true);
            yinyangerCooldown = CustomOption.Create(311, cs(Yinyanger.color, "阴阳师") + ": 标记冷却时间", "rebel", 15f, 15f, 30f, 1f, yinyangerSpawnRate);

            // Challenger options
            challengerSpawnRate = CustomOption.Create(320, cs(Challenger.color, "挑战者"), "rebel", rates, null, true);
            challengerCooldown = CustomOption.Create(321, cs(Challenger.color, "挑战者") + ": 挑战冷却", "rebel", 15f, 15f, 30f, 1f, challengerSpawnRate);

            // Ninja options
            ninjaSpawnRate = CustomOption.Create(330, cs(Ninja.color, "忍者"), "rebel", rates, null, true);

            // Berserker options
            berserkerSpawnRate = CustomOption.Create(340, cs(Berserker.color, "嗜血杀手"), "rebel", rates, null, true);
            berserkerTimeToKill = CustomOption.Create(341, cs(Berserker.color, "嗜血杀手") + ": 击杀时限", "rebel", 30f, 20f, 40f, 2.5f, berserkerSpawnRate);

            // Joker options
            jokerSpawnRate = CustomOption.Create(350, cs(Joker.color, "小丑"), "neutral", rates, null, true);
            jokerCanSabotage = CustomOption.Create(352, cs(Joker.color, "小丑") + ": 可以破坏", "neutral", true, jokerSpawnRate);

            // RoleThief options
            rolethiefSpawnRate = CustomOption.Create(360, cs(RoleThief.color, "身份窃贼"), "neutral", rates, null, true);
            rolethiefCooldown = CustomOption.Create(361, cs(RoleThief.color, "身份窃贼") + ": 交换冷却", "neutral", 20f, 10f, 30f, 2.5f, rolethiefSpawnRate);

            // Pyromaniac options
            pyromaniacSpawnRate = CustomOption.Create(370, cs(Pyromaniac.color, "纵火犯"), "neutral", rates, null, true);
            pyromaniacCooldown = CustomOption.Create(371, cs(Pyromaniac.color, "纵火犯") + ": 涂油冷却", "neutral", 15f, 10f, 20f, 1f, pyromaniacSpawnRate);
            pyromaniacDuration = CustomOption.Create(372, cs(Pyromaniac.color, "纵火犯") + ": 涂油所需时间", "neutral", 3f, 1f, 5f, 1f, pyromaniacSpawnRate);

            // Treasure hunter options
            treasureHunterSpawnRate = CustomOption.Create(380, cs(TreasureHunter.color, "寻宝猎人"), "neutral", rates, null, true);
            treasureHunterCooldown = CustomOption.Create(381, cs(TreasureHunter.color, "寻宝猎人") + ": 寻宝冷却", "neutral", 10f, 10f, 20f, 1f, treasureHunterSpawnRate);
            treasureHunterTreasureNumber = CustomOption.Create(382, cs(TreasureHunter.color, "寻宝猎人") + ": 获胜所需寻宝数", "neutral", 3f, 3f, 5f, 1f, treasureHunterSpawnRate);
            treasureHunterCanCallEmergency = CustomOption.Create(383, cs(TreasureHunter.color, "寻宝猎人") + ": 可召开紧急会议", "neutral", false, treasureHunterSpawnRate);

            // Devourer options
            devourerSpawnRate = CustomOption.Create(390, cs(Devourer.color, "秃鹫"), "neutral", rates, null, true);
            devourerCooldown = CustomOption.Create(391, cs(Devourer.color, "秃鹫") + ": 吞噬冷却", "neutral", 20f, 10f, 20f, 1f, devourerSpawnRate);
            devourerBodiesNumber = CustomOption.Create(392, cs(Devourer.color, "秃鹫") + ": 获胜所需吞噬尸体数", "neutral", 3f, 2f, 5f, 1f, devourerSpawnRate);

            // Poisoner options
            poisonerSpawnRate = CustomOption.Create(400, cs(Poisoner.color, "疫医"), "neutral", rates, null, true);
            poisonerCooldown = CustomOption.Create(401, cs(Poisoner.color, "疫医") + ": 下毒冷却", "neutral", 15f, 10f, 20f, 1f, poisonerSpawnRate);
            poisonerDuration = CustomOption.Create(402, cs(Poisoner.color, "疫医") + ": 下毒时间", "neutral", 5f, 3f, 5f, 1f, poisonerSpawnRate);
            poisonerInfectRange = CustomOption.Create(403, cs(Poisoner.color, "疫医") + ": 病毒感染范围", "neutral", 1f, 0.5f, 2f, 0.25f, poisonerSpawnRate);
            poisonerInfectDuration = CustomOption.Create(404, cs(Poisoner.color, "疫医") + ": 病毒感染时间", "neutral", 20f, 15f, 30f, 1f, poisonerSpawnRate);
            poisonerCanSabotage = CustomOption.Create(405, cs(Poisoner.color, "疫医") + ": 允许破坏", "neutral", true, poisonerSpawnRate);

            // Puppeteer options
            puppeteerSpawnRate = CustomOption.Create(410, cs(Puppeteer.color, "傀儡师"), "neutral", rates, null, true);
            puppeteerNumberOfKills = CustomOption.Create(411, cs(Puppeteer.color, "傀儡师") + ": 获胜所需击杀数量", "neutral", 3f, 2f, 4f, 1f, devourerSpawnRate);

            // Captain options
            captainSpawnRate = CustomOption.Create(420, cs(Captain.color, "舰长"), "crewmate", rates, null, true);

            // Mechanic options
            mechanicSpawnRate = CustomOption.Create(430, cs(Mechanic.color, "工程师"), "crewmate", rates, null, true);
            mechanicNumberOfRepairs = CustomOption.Create(431, cs(Mechanic.color, "工程师") + ": 维修次数", "crewmate", 3f, 1f, 3f, 1f, mechanicSpawnRate);

            // Sheriff options
            sheriffSpawnRate = CustomOption.Create(440, cs(Sheriff.color, "警长"), "crewmate", rates, null, true);
            sheriffCanKillNeutrals = CustomOption.Create(441, cs(Sheriff.color, "警长") + ": 可击杀独立阵营", "crewmate", true, sheriffSpawnRate);

            // Detective options
            detectiveSpawnRate = CustomOption.Create(450, cs(Detective.color, "侦探"), "crewmate", rates, null, true);
            detectiveShowFootprints = CustomOption.Create(451, cs(Detective.color, "侦探") + ": 显示脚印", "crewmate", new string[] { "技能按钮", "一直显示" }, detectiveSpawnRate);
            detectiveCooldown = CustomOption.Create(452, cs(Detective.color, "侦探") + ": 技能冷却", "crewmate", 15f, 10f, 20f, 1f, detectiveSpawnRate);
            detectiveShowFootPrintDuration = CustomOption.Create(453, cs(Detective.color, "侦探") + ": 脚印显示时间", "crewmate", 10f, 10f, 15f, 1f, detectiveSpawnRate); 
            detectiveAnonymousFootprints = CustomOption.Create(454, cs(Detective.color, "侦探") + ": 匿名脚印", "crewmate", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(455, cs(Detective.color, "侦探") + ": 脚印生成间隔时间", "crewmate", 0.5f, 0.25f, 2f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(456, cs(Detective.color, "侦探") + ": 脚印持续时间", "crewmate", 15f, 10f, 20f, 1f, detectiveSpawnRate);

            // Forensic options
            forensicSpawnRate = CustomOption.Create(460, cs(Forensic.color, "法医"), "crewmate", rates, null, true);
            forensicReportNameDuration = CustomOption.Create(461, cs(Forensic.color, "法医") + ": 显示凶手的报告时间", "crewmate", 10, 2.5f, 10, 2.5f, forensicSpawnRate);
            forensicReportColorDuration = CustomOption.Create(462, cs(Forensic.color, "法医") + ": 显示凶手颜色类型的报告时间", "crewmate", 20, 10, 20, 2.5f, forensicSpawnRate);
            forensicReportClueDuration = CustomOption.Create(463, cs(Forensic.color, "法医") + ": 显示凶手特征的报告时间", "crewmate", 30, 20, 30, 2.5f, forensicSpawnRate);
            forensicCooldown = CustomOption.Create(464, cs(Forensic.color, "法医") + ": 询问冷却", "crewmate", 20f, 20f, 30f, 1f, forensicSpawnRate);
            forensicDuration = CustomOption.Create(465, cs(Forensic.color, "法医") + ": 询问持续时间", "crewmate", 5f, 5f, 10f, 1f, forensicSpawnRate);
            forensicOneTimeUse = CustomOption.Create(466, cs(Forensic.color, "法医") + ": 每个灵魂只能询问一次", "crewmate", true, forensicSpawnRate);

            // TimeTraveler options
            timeTravelerSpawnRate = CustomOption.Create(470, cs(TimeTraveler.color, "时间之主"), "crewmate", rates, null, true);
            timeTravelerCooldown = CustomOption.Create(471, cs(TimeTraveler.color, "时间之主") + ": 技能冷却", "crewmate", 30f, 20f, 40f, 2.5f, timeTravelerSpawnRate);
            timeTravelerShieldDuration = CustomOption.Create(472, cs(TimeTraveler.color, "时间之主") + ": 时间之盾持续时间", "crewmate", 10f, 5f, 15f, 1f, timeTravelerSpawnRate);
            timeTravelerRewindTime = CustomOption.Create(473, cs(TimeTraveler.color, "时间之主") + ": 回溯持续时长", "crewmate", 10f, 10f, 15f, 1f, timeTravelerSpawnRate);
            timeTravelerReviveDuringRewind = CustomOption.Create(474, cs(TimeTraveler.color, "时间之主") + ": 回溯时可复活玩家", "crewmate", true, timeTravelerSpawnRate);

            // Squire options
            squireSpawnRate = CustomOption.Create(480, cs(Squire.color, "医生"), "crewmate", rates, null, true);
            squireShowShielded = CustomOption.Create(481, cs(Squire.color, "医生") + ": 显示被保护玩家", "crewmate", new string[] { "医生", "医生与被保护者", "所有人" }, squireSpawnRate);
            squireShowAttemptToShielded = CustomOption.Create(482, cs(Squire.color, "医生") + ": 保护者被击杀是播放提示音效", "crewmate", true, squireSpawnRate);
            squireResetShieldAfterMeeting = CustomOption.Create(483, cs(Squire.color, "医生") + ": 会议后护盾重置", "crewmate", true, squireSpawnRate);

            // Cheater options
            cheaterSpawnRate = CustomOption.Create(490, cs(Cheater.color, "换票师"), "crewmate", rates, null, true);
            cheaterCanCallEmergency = CustomOption.Create(491, cs(Cheater.color, "换票师") + ": 可召开紧急会议", "crewmate", false, cheaterSpawnRate);
            cheatercanOnlyCheatOthers = CustomOption.Create(492, cs(Cheater.color, "换票师") + ": 可交换自己的得票", "crewmate", false, cheaterSpawnRate);

            // FortuneTeller options
            fortuneTellerSpawnRate = CustomOption.Create(500, cs(FortuneTeller.color, "预言家"), "crewmate", rates, null, true);
            fortuneTellerCooldown = CustomOption.Create(501, cs(FortuneTeller.color, "预言家") + ": 预言冷却", "crewmate", 30f, 30f, 40f, 2.5f, fortuneTellerSpawnRate);
            fortuneTellerDuration = CustomOption.Create(502, cs(FortuneTeller.color, "预言家") + ": 预言所需时间", "crewmate", 3f, 3f, 5f, 1f, fortuneTellerSpawnRate);
            fortuneTellerNumberOfSee = CustomOption.Create(503, cs(FortuneTeller.color, "预言家") + ": 可预言次数", "crewmate", 3f, 1f, 3f, 1f, fortuneTellerSpawnRate);
            fortuneTellerKindOfInfo = CustomOption.Create(504, cs(FortuneTeller.color, "预言家") + ": 信息格式", "crewmate", new string[] { "好人/坏人", "职业" }, fortuneTellerSpawnRate);
            fortuneTellerPlayersWithNotification = CustomOption.Create(505, cs(FortuneTeller.color, "预言家") + ": 通知被预言玩家", "crewmate", new string[] { "伪装者", "船员", "所有人", "无" }, fortuneTellerSpawnRate);

            // Hacker options
            hackerSpawnRate = CustomOption.Create(510, cs(Hacker.color, "黑客"), "crewmate", rates, null, true);
            hackerCooldown = CustomOption.Create(511, cs(Hacker.color, "黑客") + ": 技能冷却", "crewmate", 20f, 20f, 40f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(512, cs(Hacker.color, "黑客") + ": 技能持续时间", "crewmate", 15f, 10f, 15f, 1f, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(513, cs(Hacker.color, "黑客") + ": 初始技能次数", "crewmate", 3f, 1f, 5f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(514, cs(Hacker.color, "黑客") + ": 充能需要完成的任务数", "crewmate", 2f, 1f, 3f, 1f, hackerSpawnRate);

            // Sleuth options
            sleuthSpawnRate = CustomOption.Create(520, cs(Sleuth.color, "追踪者"), "crewmate", rates, null, true);
            sleuthUpdateIntervall = CustomOption.Create(521, cs(Sleuth.color, "追踪者") + ": 追踪箭头更新时间", "crewmate", 0f, 0f, 3f, 1f, sleuthSpawnRate);
            sleuthResetTargetAfterMeeting = CustomOption.Create(522, cs(Sleuth.color, "追踪者") + ": 会议后追踪重置", "crewmate", true, sleuthSpawnRate);
            sleuthCorpsesPathfindCooldown = CustomOption.Create(524, cs(Sleuth.color, "追踪者") + ": 追踪尸体的冷却", "crewmate", 30f, 20f, 40f, 2.5f, sleuthSpawnRate);
            sleuthCorpsesPathfindDuration = CustomOption.Create(525, cs(Sleuth.color, "追踪者") + ": 追踪尸体的持续时间", "crewmate", 10f, 5f, 15f, 2.5f, sleuthSpawnRate);

            // Fink options
            finkSpawnRate = CustomOption.Create(530, cs(Fink.color, "告密者"), "crewmate", rates, null, true);
            finkLeftTasksForImpostors = CustomOption.Create(531, cs(Fink.color, "告密者") + ": 被内鬼阵营发现时剩余的任务数", "crewmate", 1f, 1f, 3f, 1f, finkSpawnRate);
            finkIncludeTeamRenegade = CustomOption.Create(532, cs(Fink.color, "告密者") + ": 可以与变节者阵营相互发现", "crewmate", true, finkSpawnRate);
            finkCooldown = CustomOption.Create(533, cs(Fink.color, "告密者") + ": 技能冷却", "crewmate", 20f, 20f, 30f, 1f, finkSpawnRate);
            finkDuration = CustomOption.Create(534, cs(Fink.color, "告密者") + ": 鹰眼持续时间", "crewmate", 5f, 3f, 5f, 1f, finkSpawnRate);

            // Kid options
            kidSpawnRate = CustomOption.Create(540, cs(Kid.color, "小孩"), "crewmate", rates, null, true);

            // Welder options
            welderSpawnRate = CustomOption.Create(550, cs(Welder.color, "焊工"), "crewmate", rates, null, true);
            welderCooldown = CustomOption.Create(551, cs(Welder.color, "焊工") + ": 封锁冷却", "crewmate", 20f, 10f, 40f, 2.5f, welderSpawnRate);
            welderTotalWelds = CustomOption.Create(552, cs(Welder.color, "焊工") + ": 可封锁数", "crewmate", 5f, 3f, 5f, 1f, welderSpawnRate);

            // Spiritualist options
            spiritualistSpawnRate = CustomOption.Create(560, cs(Spiritualist.color, "殉道者"), "crewmate", rates, null, true);
            spiritualistReviveTime = CustomOption.Create(561, cs(Spiritualist.color, "殉道者") + ": 复活玩家所需时间", "crewmate", 10f, 10f, 15f, 1f, spiritualistSpawnRate);          

            // Vigilant options
            vigilantSpawnRate = CustomOption.Create(570, cs(Vigilant.color, "哨兵"), "crewmate", rates, null, true);
            vigilantCooldown = CustomOption.Create(571, cs(Vigilant.color, "哨兵") + ": 安装摄像头冷却", "crewmate", 20f, 10f, 30f, 2.5f, vigilantSpawnRate);
            vigilantCamDuration = CustomOption.Create(573, cs(Vigilant.color, "哨兵") + ": 远程观看监控持续时间", "crewmate", 10f, 5f, 15f, 1f, vigilantSpawnRate);
            vigilantCamMaxCharges = CustomOption.Create(574, cs(Vigilant.color, "哨兵") + ": 初始充能数", "crewmate", 5f, 1f, 5f, 1f, vigilantSpawnRate);
            vigilantCamRechargeTasksNumber = CustomOption.Create(575, cs(Vigilant.color, "哨兵") + ": 充能需要完成的任务数", "crewmate", 2f, 1f, 3f, 1f, vigilantSpawnRate);
                      
            // Hunter options
            hunterSpawnRate = CustomOption.Create(580, cs(Hunter.color, "猎人"), "crewmate", rates, null, true);
            hunterResetTargetAfterMeeting = CustomOption.Create(581, cs(Hunter.color, "猎人") + ": 会议后标记重置", "crewmate", true, hunterSpawnRate);

            // Jinx
            jinxSpawnRate = CustomOption.Create(590, cs(Jinx.color, "扫把星"), "crewmate", rates, null, true);
            jinxCooldown = CustomOption.Create(595, cs(Jinx.color, "扫把星") + ": 厄运传递冷却", "crewmate", 20f, 10f, 30f, 2.5f, jinxSpawnRate);
            jinxJinxsNumber = CustomOption.Create(596, cs(Jinx.color, "扫把星") + ": 厄运传递次数", "crewmate", 10f, 5f, 15f, 1f, jinxSpawnRate);

            // Coward options
            cowardSpawnRate = CustomOption.Create(600, cs(Coward.color, "怯懦者"), "crewmate", rates, null, true);
            cowardNumberOfCalls = CustomOption.Create(601, cs(Coward.color, "怯懦者") + ": 可召开紧急会议数", "crewmate", 3f, 1f, 3f, 1f, cowardSpawnRate);

            // Bat options
            batSpawnRate = CustomOption.Create(610, cs(Bat.color, "蝙蝠侠"), "crewmate", rates, null, true);
            batCooldown = CustomOption.Create(611, cs(Bat.color, "蝙蝠侠") + ": 技能冷却", "crewmate", 15f, 10f, 20f, 1f, batSpawnRate);
            batDuration = CustomOption.Create(612, cs(Bat.color, "蝙蝠侠") + ": 放射持续时间", "crewmate", 10f, 5f, 10f, 1f, batSpawnRate);
            batRange = CustomOption.Create(613, cs(Bat.color, "蝙蝠侠") + ": 放射范围", "crewmate", 1f, 0.5f, 2f, 0.25f, batSpawnRate);

            // Necromancer options
            necromancerSpawnRate = CustomOption.Create(620, cs(Necromancer.color, "死灵法师"), "crewmate", rates, null, true);
            necromancerReviveCooldown = CustomOption.Create(621, cs(Necromancer.color, "死灵法师") + ": 技能冷却", "crewmate", 20f, 20f, 40f, 1f, necromancerSpawnRate);
            necromancerReviveTimer = CustomOption.Create(622, cs(Necromancer.color, "死灵法师") + ": 复活时间", "crewmate", 5f, 5f, 10f, 1f, necromancerSpawnRate);
            necromancerMaxReviveRoomDistance = CustomOption.Create(623, cs(Necromancer.color, "死灵法师") + ": 房间距离", "crewmate", 25f, 25f, 50f, 2.5f, necromancerSpawnRate);

            // Engineer options
            engineerSpawnRate = CustomOption.Create(630, cs(Engineer.color, "机关师"), "crewmate", rates, null, true);
            engineerCooldown = CustomOption.Create(631, cs(Engineer.color, "机关师") + ": 机关设置冷却", "crewmate", 10f, 10f, 20f, 1f, engineerSpawnRate);
            engineerNumberOfTraps = CustomOption.Create(632, cs(Engineer.color, "机关师") + ": 机关设置数量", "crewmate", 5f, 3f, 5f, 1f, engineerSpawnRate);
            engineerTrapsDuration = CustomOption.Create(633, cs(Engineer.color, "机关师") + ": 机关持续时间", "crewmate", 60f, 30f, 120f, 5f, engineerSpawnRate);
            engineerAccelTrapIncrease = CustomOption.Create(634, cs(Engineer.color, "机关师") + ": 速度提升", "crewmate", 1.4f, 1.2f, 1.5f, 0.1f, engineerSpawnRate);
            engineerDecelTrapDecrease = CustomOption.Create(635, cs(Engineer.color, "机关师") + ": 速度降低", "crewmate", 0.5f, 0.5f, 0.8f, 0.1f, engineerSpawnRate);

            // Shy options
            shySpawnRate = CustomOption.Create(640, cs(Shy.color, "内敛者"), "crewmate", rates, null, true);
            shyCooldown = CustomOption.Create(641, cs(Shy.color, "内敛者") + ": 技能冷却", "crewmate", 20f, 10f, 30f, 1f, shySpawnRate);
            shyDuration = CustomOption.Create(642, cs(Shy.color, "内敛者") + ": 技能持续时间", "crewmate", 10f, 5f, 20f, 1f, shySpawnRate);
            shyArrowRange = CustomOption.Create(643, cs(Shy.color, "内敛者") + ": 通知范围", "crewmate", 10f, 5f, 15f, 1f, shySpawnRate);
            shyPlayerColor = CustomOption.Create(644, cs(Shy.color, "内敛者") + ": 箭头显示玩家颜色", "crewmate", false, shySpawnRate);
        }
    }    
}