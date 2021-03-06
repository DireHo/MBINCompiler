﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x88, GUID = 0xD6DA8D9BCBAC1DBB)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
		/* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<NMSString0x100> TkMonitorNames;
		/* 0x20 */ public bool UseScreenResolution;
        /* 0x24 */ public int ResolutionWidth;
        /* 0x28 */ public int ResolutionHeight;
		public enum VsyncExEnum { Off, On, Adaptive }
        /* 0x2C */ public VsyncExEnum VsyncEx;
        /* 0x30 */ public bool GSync;
		public enum ShadowDetailEnum { Low, Normal, High, Ultra }
		/* 0x34 */ public ShadowDetailEnum ShadowDetail;
		public enum TextureDetailEnum { Low, Normal, High }
		/* 0x38 */ public TextureDetailEnum TextureDetail;
		public enum GenerationDetailEnum { Low, Normal, High }
		/* 0x3C */ public GenerationDetailEnum GenerationDetail;
		public enum ReflectionsQualityEnum { Low, Normal, High }
		/* 0x40 */ public ReflectionsQualityEnum ReflectionsQuality;
		public enum AntiAliasingEnum { Auto, None, FXAA, TAA_LOW, TAA, TAA_FXAA, SSAA4 }
        /* 0x44 */ public AntiAliasingEnum AntiAliasingEx2;
		public enum MotionBlurQualityEnum { Auto, Off, Normal, High, Ultra }
		/* 0x48 */ public MotionBlurQualityEnum MotionBlurQuality;
		public enum TerrainQualityExEnum { Auto, Low, Normal, High, Ultra }
		/* 0x4C */ public TerrainQualityExEnum TerrainQualityEx;
		/* 0x50 */ public float MotionBlurStrength;
        /* 0x54 */ public int AnisotropyLevel;
        /* 0x58 */ public float FoVOnFoot;
        /* 0x5C */ public float FoVInShip;
        /* 0x60 */ public int Brightness;
        /* 0x64 */ public int MaxframeRate;
		/* 0x68 */ public int NumHighThreads;
		/* 0x6C */ public int NumLowThreads;
		public enum TextureStreamingExEnum { Off, On, Auto, NonDynamic }
		/* 0x70 */ public TextureStreamingExEnum TextureStreamingEx;
		/* 0x74 */ public bool ShowRequirementsWarnings;
		/* 0x75 */ public bool RemoveBaseBuildingRestrictions;
        /* 0x78 */ public float MouseClickSpeedMultiplier;
		public enum AmbientOcclusionEnum { SSAO, HBAO, Off }
		/* 0x7C */ public AmbientOcclusionEnum AmbientOcclusion;
        /* 0x80 */ public bool UseTerrainTextureCache;
        /* 0x81 */ public bool UseArbSparseTexture;
        /* 0x82 */ public bool EnableTessellation;
        /* 0x83 */ public bool UseHDR;
        /* 0x84 */ public bool UseLightShafts;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x85 */ public byte[] EndPadding;
    }
}
