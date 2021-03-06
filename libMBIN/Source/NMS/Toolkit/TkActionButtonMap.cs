﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0xD0BF3BAF4263B9DA)]
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ActionId;
        /* 0x10 */ public bool ScaleToFitFont;
        /* 0x14 */ public TkInputEnum PadButtonId; 
        /* 0x18 */ public List<TkPlatformButtonPair> Platforms;
    }
}
