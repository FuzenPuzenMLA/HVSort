﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace ControlersData
{
    public class PartColorPacksCnt
    {
        public static Dictionary<PartColor, Color32> GetCurrentLevelPack()
        {
            int id = LevelsCnt.GetCurrentLevel().colorPackId;
            switch (id)
            {
                case 0: return colorPackDefault;
                case 1: return colorPackBlue;
                case 2: return colorPackIceTree;
                case 3: return colorPackIceFire;
                case 4: return colorPackYelowBlue;
                case 5: return colorPackYelowRed;
                default: return colorPackDefault;
            }
        }
        
        public static Dictionary<PartColor, Color32> colorPackDefault = new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(254, 39, 18,255)},
            {PartColor.Green, new Color32(240, 87, 0,255)},
            {PartColor.Orange,  new Color32(251, 153, 2,255)},
            {PartColor.Yellow,  new Color32(250, 188, 3,255)},
            {PartColor.Pink, new Color32(167, 25, 75,255)},
            {PartColor.Violet,  new Color32(134, 2, 176,255)},
            {PartColor.Lime,  new Color32(62, 1, 164,255)},
            {PartColor.Blue,  new Color32(2, 71, 254,255)},
        
        };
        
        public static Dictionary<PartColor, Color32> colorPackBlue = new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(255, 255, 255,255)},
            {PartColor.Green, new Color32(146, 255, 255,255)},
            {PartColor.Orange,  new Color32(0, 241, 255,255)},
            {PartColor.Yellow,  new Color32(0, 198, 255,255)},
            {PartColor.Pink, new Color32(0, 157, 255,255)},
            {PartColor.Violet,  new Color32(0, 115, 255,255)},
            {PartColor.Lime,  new Color32(50, 72, 200,255)},
            {PartColor.Blue,  new Color32(10, 30, 255,255)},
        
        };
        
      
        
        public static Dictionary<PartColor, Color32> colorPackIceTree = new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(17, 204, 0,255)},
            {PartColor.Green, new Color32(0, 145, 39,255)},
            {PartColor.Orange,  new Color32(139, 204, 0,255)},
            {PartColor.Yellow,  new Color32(0, 204, 163,255)},
            {PartColor.Pink, new Color32(112, 147, 204,255)},
            {PartColor.Violet,  new Color32(0, 246, 255,255)},
            {PartColor.Lime,  new Color32(0, 102, 204,255)},
            {PartColor.Blue,  new Color32(0, 51, 204,255)},
        
        };
        
        public static Dictionary<PartColor, Color32> colorPackIceFire= new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(204, 0, 0,255)},
            {PartColor.Green, new Color32(196, 0, 99,255)},
            {PartColor.Orange,  new Color32(204, 102, 0,255)},
            {PartColor.Yellow,  new Color32(204, 235, 0,255)},
            {PartColor.Pink, new Color32(112, 147, 204,255)},
            {PartColor.Violet,  new Color32(0, 246, 255,255)},
            {PartColor.Lime,  new Color32(0, 102, 204,255)},
            {PartColor.Blue,  new Color32(0, 51, 204,255)},
        
        };
        
        public static Dictionary<PartColor, Color32> colorPackYelowBlue= new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(227, 224, 0,255)},
            {PartColor.Green, new Color32(255, 255, 190,255)},
            {PartColor.Orange,  new Color32(204, 102, 0,255)},
            {PartColor.Yellow,  new Color32(255, 184, 109,255)},
            {PartColor.Pink, new Color32(112, 147, 204,255)},
            {PartColor.Violet,  new Color32(0, 246, 255,255)},
            {PartColor.Lime,  new Color32(0, 102, 204,255)},
            {PartColor.Blue,  new Color32(0, 51, 204,255)},
        
        };
        
        public static Dictionary<PartColor, Color32> colorPackYelowRed= new Dictionary<PartColor, Color32>()
        {
            {PartColor.Red, new Color32(227, 224, 0,255)},
            {PartColor.Green, new Color32(255, 255, 190,255)},
            {PartColor.Orange,  new Color32(204, 102, 0,255)},
            {PartColor.Yellow,  new Color32(255, 184, 109,255)},
            {PartColor.Pink, new Color32(255, 51, 59,255)},
            {PartColor.Violet,  new Color32(204, 0, 0,255)},
            {PartColor.Lime,  new Color32(196, 0, 99,255)},
            {PartColor.Blue,  new Color32(174, 0, 204,255)},
        
        };
        [Serializable]
        public enum PartColor
        {
            Red,
            Green,
            Orange,
            Blue,
            Pink,
            Violet,
            Lime,
            Yellow
        }
    }
}