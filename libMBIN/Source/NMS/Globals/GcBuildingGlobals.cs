﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x6FE36EAD5A79276C )]
    public class GcBuildingGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool AllowBuildingUsingIntermediates;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0001 */ public byte[] Padding1;
        /* 0x0004 */ public float BuildingWaterMargin;
        /* 0x0008 */ public float BuildingLineFadeStart;
        /* 0x000C */ public float BuildingLineFadeEnd;
        /* 0x0010 */ public float BuildingLineAlpha;
        /* 0x0014 */ public float BuildingLineWidth;
        /* 0x0018 */ public float BuildingLineMoveSpeed;
        /* 0x001C */ public float BuildingLineMoveAmount;
        /* 0x0020 */ public float BuildingLineShrink;
        /* 0x0024 */ public float BuildingLineMaxSize;
        /* 0x0028 */ public int BuildingLineCount;
        /* 0x002C */ public float IconSpringTime;
        /* 0x0030 */ public float HoverFadeAlpha;
        /* 0x0034 */ public float HoverTime;
        /* 0x0038 */ public float HoverVisibilityTime;
        /* 0x003C */ public float HoverFadeTime;
        /* 0x0040 */ public float HoverMinToStayActiveTime;
        /* 0x0044 */ public float HoverStayActiveTime;
        /* 0x0048 */ public float HoverLockedInitTime;
        /* 0x004C */ public float HoverLockedActiveTime;
        /* 0x0050 */ public float HoverLockedIconScale;
        /* 0x0054 */ public float HoverInactiveSize;
        /* 0x0058 */ public float LineMinDistance;
        /* 0x005C */ public float LineDistanceRange;
        /* 0x0060 */ public float MaxLineLength;
        /* 0x0064 */ public float MinLineLength;
        /* 0x0068 */ public TkCurveType LineCurve;
        /* 0x006C */ public float BuildingYOffset;
        /* 0x0070 */ public float InteractMarkerYOffset;
        /* 0x0074 */ public float MinRadius;
        /* 0x0078 */ public float FadeRadius;
        /* 0x007C */ public float CloseFadeRadius;
        /* 0x0080 */ public float CloseScaleRadius;
        /* 0x0084 */ public float PlanetSectorSize;
        /* 0x0088 */ public float ChanceOfAddingShelter;
        /* 0x008C */ public float SectorMessageReshowDistance;
        /* 0x0090 */ public float SectorMessageCenterDistance;
        /* 0x0094 */ public float SectorMessageMinTime;
        /* 0x0098 */ public float MinTimeBetweenBuildingEntryMessage;
        /* 0x009C */ public float FadeStart;
        /* 0x00A0 */ public float FadeDistance;
        /* 0x00A4 */ public float NearMinAlpha;
        /* 0x00A8 */ public float MinAlpha;
        /* 0x00AC */ public float LineScaleFactor;
        /* 0x00B0 */ public float BuildingNearDistance;
        /* 0x00B4 */ public float BuildingNearArcDistance;
        /* 0x00B8 */ public float BuildingVisitDistance;
        /* 0x00BC */ public float NearMaxLineLength;
        /* 0x00C0 */ public float NearMinLineLength;
        /* 0x00C4 */ public float NearLineScaleFactor;
        /* 0x00C8 */ public float MinElevatedHeight;
        /* 0x00CC */ public float MaxLowHeight;
        /* 0x00D0 */ public float TextStringXOffset;
        /* 0x00D4 */ public float TextTagXOffset;
        /* 0x00D8 */ public float TextTagYOffset;
        /* 0x00DC */ public float TextTagWidthOffset;
        /* 0x00E0 */ public float DistanceTextXOffset;
        /* 0x00E4 */ public float DistanceTagXOffset;
        /* 0x00E8 */ public float TextTagLength;
        /* 0x00EC */ public float DistanceForVisited;
        /* 0x00F0 */ public float DistanceForTooltip;
        /* 0x00F4 */ public float SmallIconSize;
        /* 0x00F8 */ public float LargeIconSize;
        /* 0x00FC */ public float LargeIconArrowOffset;
        /* 0x0100 */ public float CompassIconSize;
        /* 0x0104 */ public float SmallIconArrowOffset;
        /* 0x0108 */ public float SpaceMarkerOffset;
        /* 0x010C */ public float SpaceMarkerOffsetPlanet;
        /* 0x0110 */ public float SpaceMarkerOffsetSamePlanet;
        /* 0x0114 */ public float MarkerLineWidth;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0118 */ public byte[] Padding118;
        /* 0x0120 */ public Colour MarkerLineColour;
        /* 0x0130 */ public float AmountToMoveMarkerRoundSphere;
        /* 0x0134 */ public float MarkerTransitionDistance;
        /* 0x0138 */ public float SpaceMarkerMinHeight;
        /* 0x013C */ public float SpaceMarkerMaxHeight;
        /* 0x0140 */ public float MaxTimeBetweenEvents;
        /* 0x0144 */ public float ShowTimeNotDistance;
        /* 0x0148 */ public float UnknownBuildingRange;
        /* 0x014C */ public float MaxIconRange;
        /* 0x0150 */ public float MarkerTimeIncrease;
        /* 0x0154 */ public float FlyingBuildingIconTime;
        /* 0x0158 */ public int MinShipScanBuildings;
        /* 0x015C */ public int MaxShipScanBuildings;
        /* 0x0160 */ public float MinRadiusForBases;
        /* 0x0164 */ public float BaseRadiusExtension;
        /* 0x0168 */ public float MaxRadiusForBases;
        /* 0x016C */ public float BuildingPlacementMaxDistance;
        /* 0x0170 */ public float BuildingPlacementSphereCastRadius;
        /* 0x0174 */ public float BuildingPlacementSphereCastBefore;
        /* 0x0178 */ public float BuildingPlacementSphereCastAfter;
        /* 0x017C */ public float BuildingPlacementAngleOffset;
        /* 0x0180 */ public float BuildingPlacementAnglePower;
        /* 0x0184 */ public float BuildingPlacementDepthPower;
        /* 0x0188 */ public float BuildingPlacementDepthScale;
        /* 0x018C */ public float BuildingPlacementTwistScale;
        /* 0x0190 */ public float BuildingPlacementDeviancePower;
        /* 0x0194 */ public float BuildingPlacementMaxScore;
        /* 0x0198 */ public int VisibleComplexityLimit;
        /* 0x019C */ public int InactiveVisibleComplexityLimit;
        /* 0x01A0 */ public float MaximumComplexityDensity;
        /* 0x01A4 */ public float ComplexityDensityTestRange;
        /* 0x01A8 */ public float ComplexityDensitySigmaSquared;
        /* 0x01AC */ public float StartCrashSiteMinDistance;
        /* 0x01B0 */ public float StartCrashSiteMaxDistance;
        /* 0x01B4 */ public float StartShelterMinDistance;
        /* 0x01B8 */ public float StartShelterMaxDistance;
                     [NMS(Size = 0x80)]
        /* 0x01BC */ public string FreighterBaseSpawnOverride;
        /* 0x023C */ public bool BaseBuildingTerrainEditBoundsOverride;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x023D */ public byte[] Padding23D;
        /* 0x0240 */ public float BaseBuildingTerrainEditBaseYOffset;
        /* 0x0244 */ public float BaseBuildingTerrainEditTopYOffset;
        /* 0x0248 */ public float BaseBuildingTerrainEditBoundsScalar;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x024C */ public byte[] Padding24C;
    }
}
