using HarmonyLib;
using System.Linq;
using System;
using System.Collections.Generic;
using static LasMonjas.LasMonjas;
using UnityEngine;

namespace LasMonjas
{
    class RoleInfo
    {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isRebel;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isRebel = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isRebel = isRebel;
        }

        // Capture the Flag Teams
        public static RoleInfo redplayer01 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer01);
        public static RoleInfo redplayer02 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer02);
        public static RoleInfo redplayer03 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer03);
        public static RoleInfo redplayer04 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer04);
        public static RoleInfo redplayer05 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer05);
        public static RoleInfo redplayer06 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer06);
        public static RoleInfo redplayer07 = new RoleInfo("红队", Color.red, "窃取 <color=#0000FFFF>蓝队</color> 旗帜", "窃取 <color=#0000FFFF>蓝队</color> 旗帜", RoleId.RedPlayer07);
        public static RoleInfo blueplayer01 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer01);
        public static RoleInfo blueplayer02 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer02);
        public static RoleInfo blueplayer03 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer03);
        public static RoleInfo blueplayer04 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer04);
        public static RoleInfo blueplayer05 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer05);
        public static RoleInfo blueplayer06 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer06);
        public static RoleInfo blueplayer07 = new RoleInfo("蓝队", Color.blue, "窃取 <color=#FF0000FF>红队</color> 旗帜", "窃取 <color=#FF0000FF>红队</color> 旗帜", RoleId.BluePlayer07);
        public static RoleInfo stealerplayer = new RoleInfo("盗旗者", Color.grey, "从玩家手中窃取旗帜以加入该团队", "从玩家手中窃取旗帜 \n以加入该团队", RoleId.StealerPlayer);

        // Police and Thief Teams
        public static RoleInfo policeplayer01 = new RoleInfo("警察", Color.cyan, "逮捕所有 <color=#D2B48CFF>小偷</color>", "逮捕所有 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer01);
        public static RoleInfo policeplayer02 = new RoleInfo("辅警", Color.yellow, "用电击枪射击 <color=#D2B48CFF>小偷</color>", "用电击枪射击 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer02);
        public static RoleInfo policeplayer03 = new RoleInfo("警察", Color.cyan, "逮捕所有 <color=#D2B48CFF>小偷</color>", "逮捕所有 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer03);
        public static RoleInfo policeplayer04 = new RoleInfo("辅警", Color.yellow, "用电击枪射击 <color=#D2B48CFF>小偷</color>", "用电击枪射击 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer04);
        public static RoleInfo policeplayer05 = new RoleInfo("警察", Color.cyan, "逮捕所有 <color=#D2B48CFF>小偷</color>", "逮捕所有 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer05);
        public static RoleInfo policeplayer06 = new RoleInfo("警察", Color.cyan, "逮捕所有 <color=#D2B48CFF>小偷</color>", "逮捕所有 <color=#D2B48CFF>小偷</color>", RoleId.PolicePlayer06);
        public static RoleInfo thiefplayer01 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer01);
        public static RoleInfo thiefplayer02 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer02);
        public static RoleInfo thiefplayer03 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer03);
        public static RoleInfo thiefplayer04 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer04);
        public static RoleInfo thiefplayer05 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer05);
        public static RoleInfo thiefplayer06 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer06);
        public static RoleInfo thiefplayer07 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer07);
        public static RoleInfo thiefplayer08 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer08);
        public static RoleInfo thiefplayer09 = new RoleInfo("小偷", Mechanic.color, "偷走所有宝石不被逮捕", "偷走所有宝石不被逮捕", RoleId.ThiefPlayer09);

        // King of the hill Teams
        public static RoleInfo greenKing = new RoleInfo("绿队国王", Color.green, "占据领地", "占据领地", RoleId.GreenKing);
        public static RoleInfo greenplayer01 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer01);
        public static RoleInfo greenplayer02 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer02);
        public static RoleInfo greenplayer03 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer03);
        public static RoleInfo greenplayer04 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer04);
        public static RoleInfo greenplayer05 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer05);
        public static RoleInfo greenplayer06 = new RoleInfo("绿队", Color.green, "保护你的国王和领地", "保护你的国王和领地", RoleId.GreenPlayer06);
        public static RoleInfo yellowKing = new RoleInfo("黄队国王", Color.yellow, "占据领地", "占据领地", RoleId.YellowKing);
        public static RoleInfo yellowplayer01 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer01);
        public static RoleInfo yellowplayer02 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer02);
        public static RoleInfo yellowplayer03 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer03);
        public static RoleInfo yellowplayer04 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer04);
        public static RoleInfo yellowplayer05 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer05);
        public static RoleInfo yellowplayer06 = new RoleInfo("黄队", Color.yellow, "保护你的国王和领地", "保护你的国王和领地", RoleId.YellowPlayer06);
        public static RoleInfo usurperplayer = new RoleInfo("篡位者", Color.grey, "杀死国王并取代他", "杀死国王并取代他", RoleId.UsurperPlayer);

        // Hot Potato Teams
        public static RoleInfo hotPotatoPlayer = new RoleInfo("烫手山芋", Color.grey, "把烫手山芋丢给别人", "把烫手山芋丢给别人", RoleId.HotPotato);
        public static RoleInfo notPotato01 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato01);
        public static RoleInfo notPotato02 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato02);
        public static RoleInfo notPotato03 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato03);
        public static RoleInfo notPotato04 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato04);
        public static RoleInfo notPotato05 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato05);
        public static RoleInfo notPotato06 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato06);
        public static RoleInfo notPotato07 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato07);
        public static RoleInfo notPotato08 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato08);
        public static RoleInfo notPotato09 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato09);
        public static RoleInfo notPotato10 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato10);
        public static RoleInfo notPotato11 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato11);
        public static RoleInfo notPotato12 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato12);
        public static RoleInfo notPotato13 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato13);
        public static RoleInfo notPotato14 = new RoleInfo("冷山芋", Color.cyan, "逃离烫手山芋", "逃离烫手山芋", RoleId.NotPotato14);
        public static RoleInfo explodedPotato01 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato01);
        public static RoleInfo explodedPotato02 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato02);
        public static RoleInfo explodedPotato03 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato03);
        public static RoleInfo explodedPotato04 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato04);
        public static RoleInfo explodedPotato05 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato05);
        public static RoleInfo explodedPotato06 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato06);
        public static RoleInfo explodedPotato07 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato07);
        public static RoleInfo explodedPotato08 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato08);
        public static RoleInfo explodedPotato09 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato09);
        public static RoleInfo explodedPotato10 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato10);
        public static RoleInfo explodedPotato11 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato11);
        public static RoleInfo explodedPotato12 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato12);
        public static RoleInfo explodedPotato13 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato13);
        public static RoleInfo explodedPotato14 = new RoleInfo("烧焦的山芋", Mechanic.color, "你被烧糊了", "你被烧糊了", RoleId.ExplodedPotato14);

        // ZombieLaboratory Teams
        public static RoleInfo nursePlayer = new RoleInfo("护士", Shy.color, "治愈幸存者并净化飞船以解决生化危机", "治愈幸存者并净化飞船以解决生化危机", RoleId.NursePlayer);
        public static RoleInfo survivorPlayer01 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer01);
        public static RoleInfo survivorPlayer02 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer02);
        public static RoleInfo survivorPlayer03 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer03);
        public static RoleInfo survivorPlayer04 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer04);
        public static RoleInfo survivorPlayer05 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer05);
        public static RoleInfo survivorPlayer06 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer06);
        public static RoleInfo survivorPlayer07 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer07);
        public static RoleInfo survivorPlayer08 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer08);
        public static RoleInfo survivorPlayer09 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer09);
        public static RoleInfo survivorPlayer10 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer10);
        public static RoleInfo survivorPlayer11 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer11);
        public static RoleInfo survivorPlayer12 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer12);
        public static RoleInfo survivorPlayer13 = new RoleInfo("幸存者", Color.cyan, "在生化危机中活下去，并寻找用于净化飞船的关键道具", "在生化危机中活下去\n并寻找用于净化飞船的关键道具", RoleId.SurvivorPlayer13);
        public static RoleInfo zombiePlayer01 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer01);
        public static RoleInfo zombiePlayer02 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer02);
        public static RoleInfo zombiePlayer03 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer03);
        public static RoleInfo zombiePlayer04 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer04);
        public static RoleInfo zombiePlayer05 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer05);
        public static RoleInfo zombiePlayer06 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer06);
        public static RoleInfo zombiePlayer07 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer07);
        public static RoleInfo zombiePlayer08 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer08);
        public static RoleInfo zombiePlayer09 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer09);
        public static RoleInfo zombiePlayer10 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer10);
        public static RoleInfo zombiePlayer11 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer11);
        public static RoleInfo zombiePlayer12 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer12);
        public static RoleInfo zombiePlayer13 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer13);
        public static RoleInfo zombiePlayer14 = new RoleInfo("僵尸", Mechanic.color, "感染所有幸存者", "感染所有幸存者", RoleId.ZombiePlayer14);
        
        // Impostor roles
        public static RoleInfo mimic = new RoleInfo("化形者", Mimic.color, "化形成其他玩家", "化形成其他玩家", RoleId.Mimic);
        public static RoleInfo painter = new RoleInfo("隐蔽者", Painter.color, "将玩家都变成相同的颜色", "将玩家都变成相同的颜色", RoleId.Painter);
        public static RoleInfo demon = new RoleInfo("吸血鬼", Demon.color, "叮咬船员让他们慢慢死去", "叮咬船员让他们慢慢死去", RoleId.Demon);
        public static RoleInfo janitor = new RoleInfo("清理者", Janitor.color, "将尸体带离犯罪现场", "将尸体带离犯罪现场", RoleId.Janitor);
        public static RoleInfo illusionist = new RoleInfo("骗术师", Illusionist.color, "建立自己的通道网络并关闭灯光", "建立自己的通道网络并关闭灯光", RoleId.Illusionist);
        public static RoleInfo manipulator = new RoleInfo("术士", Manipulator.color, "操控玩家杀死他附近的人", "操控玩家杀死他附近的人", RoleId.Manipulator);
        public static RoleInfo bomberman = new RoleInfo("爆破者", Bomberman.color, "通过放置炸弹进行破坏", "通过放置炸弹进行破坏", RoleId.Bomberman);
        public static RoleInfo chameleon = new RoleInfo("隐身人", Chameleon.color, "让自己隐身", "让自己隐身", RoleId.Chameleon);
        public static RoleInfo gambler = new RoleInfo("赌怪", Gambler.color, "会议期间猜测其他玩家身份将其狙杀", "会议期间猜测其他玩家身份将其狙杀", RoleId.Gambler);
        public static RoleInfo sorcerer = new RoleInfo("女巫", Sorcerer.color, "给其他玩家下咒", "给其他玩家下咒", RoleId.Sorcerer);
        public static RoleInfo medusa = new RoleInfo("美杜莎", Medusa.color, "石化其他玩家，杀死所有敌人", "石化其他玩家，杀死所有敌人", RoleId.Medusa);
        public static RoleInfo hypnotist = new RoleInfo("催眠师", Hypnotist.color, "颠倒玩家的移动控制", "颠倒玩家的移动控制", RoleId.Hypnotist);
        public static RoleInfo archer = new RoleInfo("弓箭手", Archer.color, "可以进行远距离击杀", "可以进行远距离击杀", RoleId.Archer);

        // Rebelde roles
        public static RoleInfo renegade = new RoleInfo("变节者", Renegade.color, "招募一名爪牙并杀死所有人", "招募一名爪牙并杀死所有人", RoleId.Renegade, false, true);
        public static RoleInfo minion = new RoleInfo("爪牙", Minion.color, "帮助变节者杀死所有人", "帮助变节者杀死所有人", RoleId.Minion, false, true);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, "猎杀你的目标" + BountyHunter.rolName, "猎杀你的目标" + BountyHunter.rolName, RoleId.BountyHunter, false, true);
        public static RoleInfo trapper = new RoleInfo("陷阱师", Trapper.color, "在地图上放置地雷和捕兽夹", "在地图上放置地雷和捕兽夹", RoleId.Trapper, false, true);
        public static RoleInfo yinyanger = new RoleInfo("阴阳师", Yinyanger.color, "标记两名玩家使其相遇时死亡", "标记两名玩家使其相遇时死亡", RoleId.Yinyanger, false, true);
        public static RoleInfo challenger = new RoleInfo("挑战者", Challenger.color, "用剪刀石头布和其他玩家决斗", "用剪刀石头布和其他玩家决斗", RoleId.Challenger, false, true);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, "标记并进行双杀", "标记并进行双杀", RoleId.Ninja, false, true);
        public static RoleInfo berserker = new RoleInfo("嗜血杀手", Berserker.color, "你无法停止杀戮", "你无法停止杀戮", RoleId.Berserker, false, true);

        // Neutral roles
        public static RoleInfo joker = new RoleInfo("小丑", Joker.color, "让自己被投出去", "让自己被投出去来取得胜利 \n打开地图激活破坏能力", RoleId.Joker, true, false);
        public static RoleInfo rolethief = new RoleInfo("身份窃贼", RoleThief.color, "窃取其他玩家的身份", "窃取其他玩家的身份", RoleId.RoleThief, true, false);
        public static RoleInfo pyromaniac = new RoleInfo("纵火犯", Pyromaniac.color, "点燃幸存者获得胜利", "点燃幸存者获得胜利", RoleId.Pyromaniac, true, false);
        public static RoleInfo treasureHunter = new RoleInfo("寻宝猎人", TreasureHunter.color, "寻找宝藏获得胜利", "寻找宝藏获得胜利", RoleId.TreasureHunter, true, false);
        public static RoleInfo devourer = new RoleInfo("秃鹫", Devourer.color, "吞噬尸体以获得胜利", "吞噬尸体以获得胜利", RoleId.Devourer, true, false);
        public static RoleInfo poisoner = new RoleInfo("疫医", Poisoner.color, "下毒并感染所有玩家", "下毒并感染所有玩家 \n打开地图激活破坏按钮", RoleId.Poisoner, true, false);
        public static RoleInfo puppeteer = new RoleInfo("傀儡师", Puppeteer.color, "制造并设法杀死假人", "制造并设法杀死假人", RoleId.Puppeteer, true, false);

        // Crewmate roles
        public static RoleInfo captain = new RoleInfo("舰长", Captain.color, "你的投票计为两票", "你的投票计为两票", RoleId.Captain);
        public static RoleInfo mechanic = new RoleInfo("工程师", Mechanic.color, "修理被破坏的飞船", "修理被破坏的飞船", RoleId.Mechanic);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "杀死 <color=#FF0000FF>伪装者</color>", "杀死 <color=#FF0000FF>伪装者</color>", RoleId.Sheriff);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "调查脚印", "调查脚印", RoleId.Detective);
        public static RoleInfo forensic = new RoleInfo("法医", Forensic.color, "通过报告尸体及询问灵魂获得线索", "通过报告尸体及询问灵魂获得线索", RoleId.Forensic);
        public static RoleInfo timeTraveler = new RoleInfo("时间之主", TimeTraveler.color, "回溯时间", "回溯时间", RoleId.TimeTraveler);
        public static RoleInfo squire = new RoleInfo("医生", Squire.color, "使用你的盾牌保护一名玩家", "使用你的盾牌保护一名玩家", RoleId.Squire);
        public static RoleInfo cheater = new RoleInfo("换票师", Cheater.color, "交换两名玩家的选票", "交换两名玩家的选票", RoleId.Cheater);
        public static RoleInfo fortuneTeller = new RoleInfo("预言家", FortuneTeller.color, "揭露谁是 <color=#FF0000FF>伪装者</color>", "揭露谁是 <color=#FF0000FF>伪装者</color>", RoleId.FortuneTeller);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, "可以在任何地方使用管理员权限与生命监测装置", "可以在任何地方\n使用管理员权限与生命监测装置", RoleId.Hacker);
        public static RoleInfo sleuth = new RoleInfo("追踪者", Sleuth.color, "追踪玩家和尸体", "追踪玩家和尸体", RoleId.Sleuth);
        public static RoleInfo fink = new RoleInfo("告密者", Fink.color, "完成你的任务来找到 <color=#FF0000FF>伪装者</color>", "完成你的任务来找到 <color=#FF0000FF>伪装者</color>", RoleId.Fink);
        public static RoleInfo kid = new RoleInfo("小孩", Kid.color, "如果你死了或被驱逐所有人都将失败", "如果你死了或被驱逐所有人都将失败", RoleId.Kid);
        public static RoleInfo welder = new RoleInfo("焊工", Welder.color, "焊死通风口", "焊死通风口", RoleId.Welder);
        public static RoleInfo spiritualist = new RoleInfo("殉道者", Spiritualist.color, "牺牲自己复活其他玩家", "牺牲自己复活其他玩家", RoleId.Spiritualist);
        public static RoleInfo coward = new RoleInfo("怯懦者", Coward.color, "远程召开紧急会议", "远程召开紧急会议", RoleId.Coward);
        public static RoleInfo vigilant = new RoleInfo("哨兵", Vigilant.color, "在地图上放置额外的摄像头", "在地图上放置额外的摄像头", RoleId.Vigilant);
        public static RoleInfo vigilantMira = new RoleInfo("哨兵", Vigilant.color, "按Q键可以远程开门", "按Q键可以远程开门", RoleId.VigilantMira);
        public static RoleInfo hunter = new RoleInfo("猎人", Hunter.color, "标记一名玩家在自己死亡时陪葬", "标记一名玩家在自己死亡时陪葬", RoleId.Hunter);
        public static RoleInfo jinx = new RoleInfo("扫把星", Jinx.color, "给其他玩家传递厄运，无效一次技能", "给其他玩家传递厄运\n无效一次技能", RoleId.Jinx);
        public static RoleInfo bat = new RoleInfo("蝙蝠侠", Bat.color, "加速船员阵营技能冷却时间，减缓伪装者技能冷却时间", "加速船员阵营技能冷却时间\n减缓伪装者技能冷却时间", RoleId.Bat);
        public static RoleInfo necromancer = new RoleInfo("死灵法师", Necromancer.color, "把尸体带到其它的房间并复活", "把尸体带到其它的房间并复活", RoleId.Necromancer);
        public static RoleInfo engineer = new RoleInfo("机关师", Engineer.color, "设置速度变换和位置显示陷阱", "设置速度变换和位置显示陷阱\n按Q切换陷阱类型", RoleId.Engineer);
        public static RoleInfo shy = new RoleInfo("内敛者", Shy.color, "检查靠近的玩家", "检查靠近的玩家", RoleId.Shy);
        public static RoleInfo impostor = new RoleInfo("伪装者", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏并杀死所有人"), "破坏并杀死所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Kid.color, "找出并放逐 <color=#FF0000FF>伪装者</color>", "找出并放逐 <color=#FF0000FF>伪装者</color>", RoleId.Crewmate);
        public static RoleInfo lighter = new RoleInfo("执灯人", Modifiers.color, "你的视野更加开阔", "你的视野更加开阔", RoleId.Lighter);
        public static RoleInfo blind = new RoleInfo("失明者", Modifiers.color, "你的视野更加狭窄", "你的视野更加狭窄", RoleId.Blind);
        public static RoleInfo flash = new RoleInfo("闪电侠", Modifiers.color, "你拥有风驰电掣的速度", "你拥有风驰电掣的速度", RoleId.Flash);
        public static RoleInfo bigchungus = new RoleInfo("巨人", Modifiers.color, "你太胖了跑不动", "你太胖了跑不动", RoleId.BigChungus);
        public static RoleInfo theChosenOne = new RoleInfo("诱饵", Modifiers.color, "杀死你的凶手会被迫报告", "杀死你的凶手会被迫报告", RoleId.TheChosenOne);
        public static RoleInfo performer = new RoleInfo("广播员", Modifiers.color, "你的死亡会触发警报", "你的死亡会触发警报\n并告知你所在的位置", RoleId.Performer);
        public static RoleInfo pro = new RoleInfo("醉鬼", Modifiers.color, "你的行动控制是颠倒的", "你的行动控制是颠倒的", RoleId.Pro);
        public static RoleInfo lover = new RoleInfo("恋人", Modifiers.loverscolor, $"♥与你的恋人一起存活下去♥", $"♥与你的恋人一起存活下去♥", RoleId.Lover);
        public static RoleInfo badlover = new RoleInfo("伪装者恋人", Palette.ImpostorRed, $"<color=#FF00D1FF>♥与你的恋人一起存活♥. </color><color=#FF1919FF>杀死其他人</color>", $"<color=#FF00D1FF>♥与你的恋人一起存活♥. \n</color><color=#FF1919FF>杀死其他人</color>", RoleId.Lover);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            mimic,
            painter,
            demon,
            janitor,
            illusionist,
            manipulator,
            bomberman,
            chameleon,
            gambler,
            sorcerer,
            medusa,
            hypnotist,
            archer,
            renegade,
            minion,
            bountyHunter,
            trapper,
            yinyanger,
            challenger,
            ninja,
            berserker,
            joker,
            rolethief,
            pyromaniac,
            treasureHunter,
            devourer,
            poisoner,
            puppeteer,
            crewmate,
            captain,
            mechanic,
            sheriff,
            detective,
            forensic,
            timeTraveler,
            squire,
            cheater,
            fortuneTeller,
            hacker,
            sleuth,
            fink,
            welder,
            spiritualist,
            coward,         
            vigilant,
            vigilantMira,
            kid,
            medusa,
            hunter,
            jinx,
            bat,
            necromancer,
            engineer,
            shy,
            lighter,
            blind,
            flash,
            bigchungus,
            theChosenOne,
            performer,
            pro,
            lover,
            badlover,
            redplayer01,
            redplayer02,
            redplayer03,
            redplayer04,
            redplayer05,
            redplayer06,
            redplayer07,
            blueplayer01,
            blueplayer02,
            blueplayer03,
            blueplayer04,
            blueplayer05,
            blueplayer06,
            blueplayer07,
            stealerplayer,
            policeplayer01,
            policeplayer02,
            policeplayer03,
            policeplayer04,
            policeplayer05,
            policeplayer06,
            thiefplayer01,
            thiefplayer02,
            thiefplayer03,
            thiefplayer04,
            thiefplayer05,
            thiefplayer06,
            thiefplayer07,
            thiefplayer08,
            thiefplayer09,
            greenKing,
            greenplayer01,
            greenplayer02,
            greenplayer03,
            greenplayer04,
            greenplayer05,
            greenplayer06,
            yellowKing,
            yellowplayer01,
            yellowplayer02,
            yellowplayer03,
            yellowplayer04,
            yellowplayer05,
            yellowplayer06,
            usurperplayer,
            hotPotatoPlayer,
            notPotato01,
            notPotato02,
            notPotato03,
            notPotato04,
            notPotato05,
            notPotato06,
            notPotato07,
            notPotato08,
            notPotato09,
            notPotato10,
            notPotato11,
            notPotato12,
            notPotato13,
            notPotato14,
            explodedPotato01,
            explodedPotato02,
            explodedPotato03,
            explodedPotato04,
            explodedPotato05,
            explodedPotato06,
            explodedPotato07,
            explodedPotato08,
            explodedPotato09,
            explodedPotato10,
            explodedPotato11,
            explodedPotato12,
            explodedPotato13,
            explodedPotato14,
            nursePlayer,
            survivorPlayer01,
            survivorPlayer02,
            survivorPlayer03,
            survivorPlayer04,
            survivorPlayer05,
            survivorPlayer06,
            survivorPlayer07,
            survivorPlayer08,
            survivorPlayer09,
            survivorPlayer10,
            survivorPlayer11,
            survivorPlayer12,
            survivorPlayer13,
            zombiePlayer01,
            zombiePlayer02,
            zombiePlayer03,
            zombiePlayer04,
            zombiePlayer05,
            zombiePlayer06,
            zombiePlayer07,
            zombiePlayer08,
            zombiePlayer09,
            zombiePlayer10,
            zombiePlayer11,
            zombiePlayer12,
            zombiePlayer13,
            zombiePlayer14
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Capture the Flag
            if (p == CaptureTheFlag.redplayer01) infos.Add(redplayer01);
            if (p == CaptureTheFlag.redplayer02) infos.Add(redplayer02);
            if (p == CaptureTheFlag.redplayer03) infos.Add(redplayer03);
            if (p == CaptureTheFlag.redplayer04) infos.Add(redplayer04);
            if (p == CaptureTheFlag.redplayer05) infos.Add(redplayer05);
            if (p == CaptureTheFlag.redplayer06) infos.Add(redplayer06);
            if (p == CaptureTheFlag.redplayer07) infos.Add(redplayer07);
            if (p == CaptureTheFlag.blueplayer01) infos.Add(blueplayer01);
            if (p == CaptureTheFlag.blueplayer02) infos.Add(blueplayer02);
            if (p == CaptureTheFlag.blueplayer03) infos.Add(blueplayer03);
            if (p == CaptureTheFlag.blueplayer04) infos.Add(blueplayer04);
            if (p == CaptureTheFlag.blueplayer05) infos.Add(blueplayer05);
            if (p == CaptureTheFlag.blueplayer06) infos.Add(blueplayer06);
            if (p == CaptureTheFlag.blueplayer07) infos.Add(blueplayer07);
            if (p == CaptureTheFlag.stealerPlayer) infos.Add(stealerplayer);

            // Police and Thief
            if (p == PoliceAndThief.policeplayer01) infos.Add(policeplayer01);
            if (p == PoliceAndThief.policeplayer02) infos.Add(policeplayer02);
            if (p == PoliceAndThief.policeplayer03) infos.Add(policeplayer03);
            if (p == PoliceAndThief.policeplayer04) infos.Add(policeplayer04);
            if (p == PoliceAndThief.policeplayer05) infos.Add(policeplayer05);
            if (p == PoliceAndThief.policeplayer06) infos.Add(policeplayer06);
            if (p == PoliceAndThief.thiefplayer01) infos.Add(thiefplayer01);
            if (p == PoliceAndThief.thiefplayer02) infos.Add(thiefplayer02);
            if (p == PoliceAndThief.thiefplayer03) infos.Add(thiefplayer03);
            if (p == PoliceAndThief.thiefplayer04) infos.Add(thiefplayer04);
            if (p == PoliceAndThief.thiefplayer05) infos.Add(thiefplayer05);
            if (p == PoliceAndThief.thiefplayer06) infos.Add(thiefplayer06);
            if (p == PoliceAndThief.thiefplayer07) infos.Add(thiefplayer07);
            if (p == PoliceAndThief.thiefplayer08) infos.Add(thiefplayer08);
            if (p == PoliceAndThief.thiefplayer09) infos.Add(thiefplayer09);

            // King of the hill
            if (p == KingOfTheHill.greenKingplayer) infos.Add(greenKing);
            if (p == KingOfTheHill.greenplayer01) infos.Add(greenplayer01);
            if (p == KingOfTheHill.greenplayer02) infos.Add(greenplayer02);
            if (p == KingOfTheHill.greenplayer03) infos.Add(greenplayer03);
            if (p == KingOfTheHill.greenplayer04) infos.Add(greenplayer04);
            if (p == KingOfTheHill.greenplayer05) infos.Add(greenplayer05);
            if (p == KingOfTheHill.greenplayer06) infos.Add(greenplayer06);
            if (p == KingOfTheHill.yellowKingplayer) infos.Add(yellowKing);
            if (p == KingOfTheHill.yellowplayer01) infos.Add(yellowplayer01);
            if (p == KingOfTheHill.yellowplayer02) infos.Add(yellowplayer02);
            if (p == KingOfTheHill.yellowplayer03) infos.Add(yellowplayer03);
            if (p == KingOfTheHill.yellowplayer04) infos.Add(yellowplayer04);
            if (p == KingOfTheHill.yellowplayer05) infos.Add(yellowplayer05);
            if (p == KingOfTheHill.yellowplayer06) infos.Add(yellowplayer06);
            if (p == KingOfTheHill.usurperPlayer) infos.Add(usurperplayer);

            // Hot Potato
            if (p == HotPotato.hotPotatoPlayer) infos.Add(hotPotatoPlayer);
            if (p == HotPotato.notPotato01) infos.Add(notPotato01);
            if (p == HotPotato.notPotato02) infos.Add(notPotato02);
            if (p == HotPotato.notPotato03) infos.Add(notPotato03);
            if (p == HotPotato.notPotato04) infos.Add(notPotato04);
            if (p == HotPotato.notPotato05) infos.Add(notPotato05);
            if (p == HotPotato.notPotato06) infos.Add(notPotato06);
            if (p == HotPotato.notPotato07) infos.Add(notPotato07);
            if (p == HotPotato.notPotato08) infos.Add(notPotato08);
            if (p == HotPotato.notPotato09) infos.Add(notPotato09);
            if (p == HotPotato.notPotato10) infos.Add(notPotato10);
            if (p == HotPotato.notPotato11) infos.Add(notPotato11);
            if (p == HotPotato.notPotato12) infos.Add(notPotato12);
            if (p == HotPotato.notPotato13) infos.Add(notPotato13);
            if (p == HotPotato.notPotato14) infos.Add(notPotato14);

            if (p == HotPotato.explodedPotato01) infos.Add(explodedPotato01);
            if (p == HotPotato.explodedPotato02) infos.Add(explodedPotato02);
            if (p == HotPotato.explodedPotato03) infos.Add(explodedPotato03);
            if (p == HotPotato.explodedPotato04) infos.Add(explodedPotato04);
            if (p == HotPotato.explodedPotato05) infos.Add(explodedPotato05);
            if (p == HotPotato.explodedPotato06) infos.Add(explodedPotato06);
            if (p == HotPotato.explodedPotato07) infos.Add(explodedPotato07);
            if (p == HotPotato.explodedPotato08) infos.Add(explodedPotato08);
            if (p == HotPotato.explodedPotato09) infos.Add(explodedPotato09);
            if (p == HotPotato.explodedPotato10) infos.Add(explodedPotato10);
            if (p == HotPotato.explodedPotato11) infos.Add(explodedPotato11);
            if (p == HotPotato.explodedPotato12) infos.Add(explodedPotato12);
            if (p == HotPotato.explodedPotato13) infos.Add(explodedPotato13);
            if (p == HotPotato.explodedPotato14) infos.Add(explodedPotato14);

            // ZombieLaboratory
            if (p == ZombieLaboratory.nursePlayer) infos.Add(nursePlayer);
            if (p == ZombieLaboratory.survivorPlayer01) infos.Add(survivorPlayer01);
            if (p == ZombieLaboratory.survivorPlayer02) infos.Add(survivorPlayer02);
            if (p == ZombieLaboratory.survivorPlayer03) infos.Add(survivorPlayer03);
            if (p == ZombieLaboratory.survivorPlayer04) infos.Add(survivorPlayer04);
            if (p == ZombieLaboratory.survivorPlayer05) infos.Add(survivorPlayer05);
            if (p == ZombieLaboratory.survivorPlayer06) infos.Add(survivorPlayer06);
            if (p == ZombieLaboratory.survivorPlayer07) infos.Add(survivorPlayer07);
            if (p == ZombieLaboratory.survivorPlayer08) infos.Add(survivorPlayer08);
            if (p == ZombieLaboratory.survivorPlayer09) infos.Add(survivorPlayer09);
            if (p == ZombieLaboratory.survivorPlayer10) infos.Add(survivorPlayer10);
            if (p == ZombieLaboratory.survivorPlayer11) infos.Add(survivorPlayer11);
            if (p == ZombieLaboratory.survivorPlayer12) infos.Add(survivorPlayer12);
            if (p == ZombieLaboratory.survivorPlayer13) infos.Add(survivorPlayer13);

            if (p == ZombieLaboratory.zombiePlayer01) infos.Add(zombiePlayer01);
            if (p == ZombieLaboratory.zombiePlayer02) infos.Add(zombiePlayer02);
            if (p == ZombieLaboratory.zombiePlayer03) infos.Add(zombiePlayer03);
            if (p == ZombieLaboratory.zombiePlayer04) infos.Add(zombiePlayer04);
            if (p == ZombieLaboratory.zombiePlayer05) infos.Add(zombiePlayer05);
            if (p == ZombieLaboratory.zombiePlayer06) infos.Add(zombiePlayer06);
            if (p == ZombieLaboratory.zombiePlayer07) infos.Add(zombiePlayer07);
            if (p == ZombieLaboratory.zombiePlayer08) infos.Add(zombiePlayer08);
            if (p == ZombieLaboratory.zombiePlayer09) infos.Add(zombiePlayer09);
            if (p == ZombieLaboratory.zombiePlayer10) infos.Add(zombiePlayer10);
            if (p == ZombieLaboratory.zombiePlayer11) infos.Add(zombiePlayer11);
            if (p == ZombieLaboratory.zombiePlayer12) infos.Add(zombiePlayer12);
            if (p == ZombieLaboratory.zombiePlayer13) infos.Add(zombiePlayer13);
            if (p == ZombieLaboratory.zombiePlayer14) infos.Add(zombiePlayer14);


            // Impostor roles
            if (p == Mimic.mimic) infos.Add(mimic);
            if (p == Painter.painter) infos.Add(painter);
            if (p == Demon.demon) infos.Add(demon);
            if (p == Illusionist.illusionist) infos.Add(illusionist);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Manipulator.manipulator) infos.Add(manipulator);
            if (p == Bomberman.bomberman) infos.Add(bomberman);
            if (p == Chameleon.chameleon) infos.Add(chameleon);
            if (p == Gambler.gambler) infos.Add(gambler);
            if (p == Sorcerer.sorcerer) infos.Add(sorcerer);
            if (p == Medusa.medusa) infos.Add(medusa);
            if (p == Hypnotist.hypnotist) infos.Add(hypnotist);
            if (p == Archer.archer) infos.Add(archer);

            // Rebels roles
            if (p == Renegade.renegade || (Renegade.formerRenegades != null && Renegade.formerRenegades.Any(x => x.PlayerId == p.PlayerId))) infos.Add(renegade);
            if (p == Minion.minion) infos.Add(minion);
            if (p == BountyHunter.bountyhunter) infos.Add(bountyHunter);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Yinyanger.yinyanger) infos.Add(yinyanger);
            if (p == Challenger.challenger) infos.Add(challenger);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Berserker.berserker) infos.Add(berserker);

            // Neutral roles
            if (p == Joker.joker) infos.Add(joker);
            if (p == RoleThief.rolethief) infos.Add(rolethief);
            if (p == Pyromaniac.pyromaniac) infos.Add(pyromaniac);
            if (p == TreasureHunter.treasureHunter) infos.Add(treasureHunter);
            if (p == Devourer.devourer) infos.Add(devourer);
            if (p == Poisoner.poisoner) infos.Add(poisoner);
            if (p == Puppeteer.puppeteer) infos.Add(puppeteer);

            // Crewmate roles
            if (p == Captain.captain) infos.Add(captain);
            if (p == Mechanic.mechanic) infos.Add(mechanic);
            if (p == Sheriff.sheriff) infos.Add(sheriff);
            if (p == Detective.detective) infos.Add(detective);
            if (p == Forensic.forensic) infos.Add(forensic);
            if (p == TimeTraveler.timeTraveler) infos.Add(timeTraveler);
            if (p == Squire.squire) infos.Add(squire);
            if (p == Cheater.cheater) infos.Add(cheater);
            if (p == FortuneTeller.fortuneTeller) infos.Add(fortuneTeller);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Sleuth.sleuth) infos.Add(sleuth);
            if (p == Fink.fink) infos.Add(fink);
            if (p == Kid.kid) infos.Add(kid);
            if (p == Welder.welder) infos.Add(welder);
            if (p == Spiritualist.spiritualist) infos.Add(spiritualist);
            if (p == Coward.coward) infos.Add(coward);
            if (p == Vigilant.vigilant) infos.Add(vigilant);
            if (p == Vigilant.vigilantMira) infos.Add(vigilantMira);
            if (p == Hunter.hunter) infos.Add(hunter);
            if (p == Jinx.jinx) infos.Add(jinx);
            if (p == Bat.bat) infos.Add(bat);
            if (p == Necromancer.necromancer) infos.Add(necromancer);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Shy.shy) infos.Add(shy);

            // Modifier
            if (p == Modifiers.lighter) infos.Add(lighter);
            if (p == Modifiers.blind) infos.Add(blind);
            if (p == Modifiers.flash) infos.Add(flash);
            if (p == Modifiers.bigchungus) infos.Add(bigchungus);
            if (p == Modifiers.theChosenOne) infos.Add(theChosenOne);
            if (p == Modifiers.performer) infos.Add(performer);
            if (p == Modifiers.pro) infos.Add(pro);
            if (p == Modifiers.lover1 || p == Modifiers.lover2) infos.Add(p.Data.Role.IsImpostor ? badlover : lover);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (roleName.Contains("恋人")) roleName.Replace("恋人", "");
            return roleName;
        }

        public class RoleFortuneTellerInfo
        {
            public Color color;
            public string name;
            public bool isGood;

            RoleFortuneTellerInfo(Color color, string name, bool isGood) {
                this.color = color;
                this.name = name;
                this.isGood = isGood;
            }

            public static RoleFortuneTellerInfo getFortuneTellerRoleInfoForPlayer(PlayerControl p) {
                string name = "";
                bool isGood = true;
                Color color = Color.white;

                if (Captain.captain != null && p == Captain.captain) {
                    name = "舰长";
                    color = Captain.color;
                }
                else if (Mechanic.mechanic != null && p == Mechanic.mechanic) {
                    name = "工程师";
                    color = Mechanic.color;
                }
                else if (Sheriff.sheriff != null && p == Sheriff.sheriff) {
                    name = "警长";
                    color = Sheriff.color;
                }
                else if (Detective.detective != null && p == Detective.detective) {
                    name = "侦探";
                    color = Detective.color;
                }
                else if (Forensic.forensic != null && p == Forensic.forensic) {
                    name = "法医";
                    color = Forensic.color;
                }
                else if (TimeTraveler.timeTraveler != null && p == TimeTraveler.timeTraveler) {
                    name = "时间之主";
                    color = TimeTraveler.color;
                }
                else if (Squire.squire != null && p == Squire.squire) {
                    name = "医生";
                    color = Squire.color;
                }
                else if (Cheater.cheater != null && p == Cheater.cheater) {
                    name = "换票师";
                    color = Cheater.color;
                }
                else if (FortuneTeller.fortuneTeller != null && p == FortuneTeller.fortuneTeller) {
                    name = "预言家";
                    color = FortuneTeller.color;
                }
                else if (Hacker.hacker != null && p == Hacker.hacker) {
                    name = "黑客";
                    color = Hacker.color;
                }
                else if (Sleuth.sleuth != null && p == Sleuth.sleuth) {
                    name = "追踪者";
                    color = Sleuth.color;
                }
                else if (Fink.fink != null && p == Fink.fink) {
                    name = "告密者";
                    color = Fink.color;
                }
                else if (Kid.kid != null && p == Kid.kid) {
                    name = "小孩";
                    color = Kid.color;
                }
                else if (Welder.welder != null && p == Welder.welder) {
                    name = "焊工";
                    color = Welder.color;
                }
                else if (Spiritualist.spiritualist != null && p == Spiritualist.spiritualist) {
                    name = "殉道者";
                    color = Spiritualist.color;
                }
                else if (Coward.coward != null && p == Coward.coward) {
                    name = "怯懦者";
                    color = Coward.color;
                }
                else if (Vigilant.vigilant != null && p == Vigilant.vigilant) {
                    name = "哨兵";
                    color = Vigilant.color;
                }
                else if (Vigilant.vigilantMira != null && p == Vigilant.vigilantMira) {
                    name = "哨兵";
                    color = Vigilant.color;
                }
                else if (Hunter.hunter != null && p == Hunter.hunter) {
                    name = "猎人";
                    color = Hunter.color;
                }
                else if (Jinx.jinx != null && p == Jinx.jinx) {
                    name = "扫把星";
                    color = Jinx.color;
                }
                else if (Bat.bat != null && p == Bat.bat) {
                    name = "蝙蝠侠";
                    color = Bat.color;
                }
                else if (Necromancer.necromancer != null && p == Necromancer.necromancer) {
                    name = "死灵法师";
                    color = Necromancer.color;
                }
                else if (Engineer.engineer != null && p == Engineer.engineer) {
                    name = "机关师";
                    color = Engineer.color;
                }
                else if (Shy.shy != null && p == Shy.shy) {
                    name = "内敛者";
                    color = Shy.color;
                }
                else if (Mimic.mimic != null && p == Mimic.mimic) {
                    name = "化形者";
                    color = Mimic.color;
                    isGood = false;
                }
                else if (Painter.painter != null && p == Painter.painter) {
                    name = "隐蔽者";
                    color = Painter.color;
                    isGood = false;
                }
                else if (Demon.demon != null && p == Demon.demon) {
                    name = "吸血鬼";
                    color = Demon.color;
                    isGood = false;
                }
                else if (Illusionist.illusionist != null && p == Illusionist.illusionist) {
                    name = "骗术师";
                    color = Illusionist.color;
                    isGood = false;
                }
                else if (Janitor.janitor != null && p == Janitor.janitor) {
                    name = "清理者";
                    color = Janitor.color;
                    isGood = false;
                }
                else if (Manipulator.manipulator != null && p == Manipulator.manipulator) {
                    name = "术士";
                    color = Manipulator.color;
                    isGood = false;
                }
                else if (Bomberman.bomberman != null && p == Bomberman.bomberman) {
                    name = "爆破者";
                    color = Bomberman.color;
                    isGood = false;
                }
                else if (Chameleon.chameleon != null && p == Chameleon.chameleon) {
                    name = "隐身人";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }
                else if (Gambler.gambler != null && p == Gambler.gambler) {
                    name = "赌怪";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }
                else if (Sorcerer.sorcerer != null && p == Sorcerer.sorcerer) {
                    name = "女巫";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }
                else if (Medusa.medusa != null && p == Medusa.medusa) {
                    name = "美杜莎";
                    color = Medusa.color;
                    isGood = false;
                }
                else if (Hypnotist.hypnotist != null && p == Hypnotist.hypnotist) {
                    name = "催眠师";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }
                else if (Archer.archer != null && p == Archer.archer) {
                    name = "弓箭手";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }               
                else if (Renegade.renegade != null && p == Renegade.renegade) {
                    name = "变节者";
                    color = Renegade.color;
                    isGood = false;
                }
                else if (Minion.minion != null && p == Minion.minion) {
                    name = "爪牙";
                    color = Minion.color;
                    isGood = false;
                }
                else if (BountyHunter.bountyhunter != null && p == BountyHunter.bountyhunter) {
                    name = "赏金猎人";
                    color = BountyHunter.color;
                    isGood = false;
                }
                else if (Trapper.trapper != null && p == Trapper.trapper) {
                    name = "陷阱师";
                    color = Trapper.color;
                    isGood = false;
                }
                else if (Yinyanger.yinyanger != null && p == Yinyanger.yinyanger) {
                    name = "阴阳师";
                    color = Yinyanger.color;
                    isGood = false;
                }
                else if (Challenger.challenger != null && p == Challenger.challenger) {
                    name = "挑战者";
                    color = Challenger.color;
                    isGood = false;
                }
                else if (Ninja.ninja != null && p == Ninja.ninja) {
                    name = "忍者";
                    color = Ninja.color;
                    isGood = false;
                }
                else if (Berserker.berserker != null && p == Berserker.berserker) {
                    name = "嗜血杀手";
                    color = Berserker.color;
                    isGood = false;
                }
                else if (Joker.joker != null && p == Joker.joker) {
                    name = "小丑";
                    color = Joker.color;
                    isGood = false;
                }
                else if (RoleThief.rolethief != null && p == RoleThief.rolethief) {
                    name = "身份窃贼";
                    color = RoleThief.color;
                    isGood = false;
                }
                else if (Pyromaniac.pyromaniac != null && p == Pyromaniac.pyromaniac) {
                    name = "纵火犯";
                    color = Pyromaniac.color;
                    isGood = false;
                }
                else if (TreasureHunter.treasureHunter != null && p == TreasureHunter.treasureHunter) {
                    name = "寻宝猎人";
                    color = TreasureHunter.color;
                    isGood = false;
                }
                else if (Devourer.devourer != null && p == Devourer.devourer) {
                    name = "秃鹫";
                    color = Devourer.color;
                    isGood = false;
                }
                else if (Poisoner.poisoner != null && p == Poisoner.poisoner) {
                    name = "疫医";
                    color = Poisoner.color;
                    isGood = false;
                }
                else if (Puppeteer.puppeteer != null && p == Puppeteer.puppeteer) {
                    name = "傀儡师";
                    color = Puppeteer.color;
                    isGood = false;
                }
                else if (p.Data.Role.IsImpostor) { // Just Impostor
                    name = "伪装者";
                    color = Palette.ImpostorRed;
                    isGood = false;
                }
                else { // Just Crewmate
                    name = "船员";
                    color = Kid.color;
                }

                return new RoleFortuneTellerInfo(
                    color,
                    name,
                    isGood
                );
            }
        }
    }
}
