﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A05D3FD3FD75164)]
    public class GcSubstanceTableEnum : NMSTemplate
    {
        // size: 0x38
		public enum SubstanceEnum { None, FUEL1, FUEL2, OXYGEN, LAUNCHSUB, LAUNCHSUB2, ROCKETSUB, LAND1, LAND2, LAND3, CATALYST1, CATALYST2, CAVE1, CAVE2, WATER1, WATER2, WATERPLANT, YELLOW2, RED2, GREEN2, BLUE2, STELLAR2, TECHFRAG, LUSH1, DUSTY1, TOXIC1, RADIO1, COLD1, HOT1, CREATURE1, ROBOT1, ASTEROID1, ASTEROID2, ASTEROID3, GAS1, GAS2, GAS3, EX_YELLOW, EX_RED, EX_GREEN, EX_BLUE, PLANT_TOXIC, PLANT_SNOW, PLANT_RADIO, PLANT_DUST, PLANT_HOT, PLANT_LUSH, PLANT_CAVE, PLANT_WATER, PLANT_POOP, SPACEGUNK1, SPACEGUNK2, SPACEGUNK3, SPACEGUNK4, SPACEGUNK5, SPECIAL_POOP }
		public SubstanceEnum Substance;
    }
}
