﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x323F208221BE947D)]
    public class GcPlayerGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool InteractNearbyRadiusEnabled;
                     [NMS(Size = 0x07, Ignore = true)]
        /* 0x0001 */ public byte[] Padding1;
                     [NMS(Size = 0x10)]
        /* 0x0008 */ public string DebugSearchGroup;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0018 */ public byte[] Padding18;
        /* 0x0020 */ public Colour SearchGroupIconColour;
        /* 0x0030 */ public bool DebugExperience;
                     [NMS(Size = 0x80)]
        /* 0x0031 */ public string DefaultShipFilename;
                     [NMS(Size = 0x07, Ignore = true)]
        /* 0x00B1 */ public byte[] PaddingB1;
        /* 0x00B8 */ public GcSeed DefaultShipSeed;
        /* 0x00C8 */ public bool DebugExperienceRender;
        /* 0x00C9 */ public bool DebugDroneScanPlayer;
                     [NMS(Size = 0x06, Ignore = true)]
        /* 0x00CA */ public byte[] PaddingCA;
        /* 0x00D0 */ public Vector4f DebugDroneSpawn;
        /* 0x00E0 */ public Vector4f DebugDroneTarget;
        /* 0x00F0 */ public int DebugNumDrones;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x00F4 */ public byte[] PaddingF4;
        /* 0x0100 */ public Vector4f DebugWalkerSpawn;
        /* 0x0110 */ public Vector4f DebugWalkerTarget;
        /* 0x0120 */ public Vector4f DebugFlybyTarget;
        /* 0x0130 */ public Vector4f DebugFlybyDir;
        /* 0x0140 */ public float DebugFlybyRange;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x0144 */ public byte[] Padding144;
        /* 0x0148 */ public GcSeed DebugFlybySeed;
                     [NMS(Size = 0x10)]
        /* 0x0158 */ public string DebugExperienceCamShake;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0168 */ public byte[] Padding168;
        /* 0x0170 */ public GcScanEffectData ArmourHighlightScanEffect;
        /* 0x01C0 */ public float HitReactNoiseAmount;
        /* 0x01C4 */ public float HitReactBlendOutSpeedMin;
        /* 0x01C8 */ public float HitReactBlendOutSpeedMax;
        /* 0x01CC */ public float JetpackUnderwaterDrainRate;
        /* 0x01D0 */ public float JetpackUnderwaterFillRate;
        /* 0x01D4 */ public float UnderwaterMargin;
        /* 0x01D8 */ public float UnderwaterMinDepth;
        /* 0x01DC */ public float UnderwaterSurfaceTension;
        /* 0x01E0 */ public float UnderwaterSurfaceTensionOffset;
        /* 0x01E4 */ public float UnderwaterSurfaceForceFlattenAngleMin;
        /* 0x01E8 */ public float UnderwaterSurfaceForceFlattenAngleRange;
        /* 0x01EC */ public float UnderwaterImpact;
        /* 0x01F0 */ public float UnderwaterMaxSpeed;
        /* 0x01F4 */ public float UnderwaterForce;
        /* 0x01F8 */ public float UnderwaterMaxJetpackSpeed;
        /* 0x01FC */ public float UnderwaterJetpackForce;
        /* 0x0200 */ public float UnderwaterMaxJetpackEscapeSpeed;
        /* 0x0204 */ public float UnderwaterJetpackEscapeForce;
        /* 0x0208 */ public float UnderwaterBrake;
        /* 0x020C */ public float UnderwaterFloat;
        /* 0x0210 */ public float UnderwaterFloatForce;
        /* 0x0214 */ public float UnderwaterFloatRange;
        /* 0x0218 */ public float UnderwaterFloatFreq;
        /* 0x021C */ public float RespawnOnPadRadius;
        /* 0x0220 */ public float DeepWaterDepth;
        /* 0x0224 */ public float CockpitEjectTestRadius;
        /* 0x0228 */ public float CockpitEjectTestStartHeightOffset;
        /* 0x022C */ public float CockpitEjectTestEndHeightOffset;
        /* 0x0230 */ public float CockpitEjectFirstPersonOffsetTime;
        /* 0x0234 */ public float CockpitEjectFirstPersonOffset;
        /* 0x0238 */ public float BinocularRangePlanet;
        /* 0x023C */ public float BinocularRangeSpace;
        /* 0x0240 */ public float MinBinocActiveTime;
        /* 0x0244 */ public int RobotMultiplierWithFriends;
        /* 0x0248 */ public float DroneStartLocationRadius;
        /* 0x024C */ public float ShipSummonLastSafeMargin;
        /* 0x0250 */ public float CreativeModeDeathFadeInTime;
        /* 0x0254 */ public float CreativeModeDeathFadeOutTime;
        /* 0x0258 */ public int NumberOfWarpsRequiredForFreightersToSpawn;
        /* 0x025C */ public float SpawningDistanceBetweenPlayersAfterWarp;
        /* 0x0260 */ public float SpawningSpaceBattleLookOffset;
        /* 0x0264 */ public float SpawningSpaceBattleLookOffsetUp;
        /* 0x0268 */ public bool MultiplayerShareWanted;
        /* 0x0269 */ public bool ReportAllProjectileDamage;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x026A */ public byte[] Padding26A;
        /* 0x026C */ public int DefaultHitPoints;
        /* 0x0270 */ public int DefaultHealthPips;
        /* 0x0274 */ public int DefaultShipHealthPips;
        /* 0x0278 */ public int MaxHealthPips;
        /* 0x027C */ public bool UseLargeHealthBar;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x027D */ public byte[] Padding27D;
        /* 0x0280 */ public float DroneSpawnAccelerator;
        /* 0x0284 */ public float TrackArrowStaticTargetOffsetMultiplier;
        /* 0x0288 */ public float WitnessSenseEnhancementTime;
        /* 0x028C */ public float WitnessSenseEnhancement;
        /* 0x0290 */ public float MultiplayerMinWanteEscalationTime;
        /* 0x0294 */ public float HealthRechargeMinTimeSinceDamage;
        /* 0x0298 */ public float HealthPipRechargeRate;
        /* 0x029C */ public float MinEnergyPercentOnRespawn;
        /* 0x02A0 */ public float VehicleRaceResultsHintTime;
        /* 0x02A4 */ public float OtherPlayerTrackArrowRange;
        /* 0x02A8 */ public float WantedLevelPlayerRange;
        /* 0x02AC */ public float WantedLevelPlayerRangeSpace;
        /* 0x02B0 */ public float PlayerTransferRange;
        /* 0x02B4 */ public float PlayerSpaceTransferRange;
        /* 0x02B8 */ public float DroneScanTimeToForget;
        /* 0x02BC */ public float GhostbusterStartLength;
        /* 0x02C0 */ public float GhostbusterStart1;
        /* 0x02C4 */ public float GhostbusterSpeed1;
        /* 0x02C8 */ public float GhostbusterFreq1;
        /* 0x02CC */ public float GhostbusterAmp1;
        /* 0x02D0 */ public float GhostbusterStart2;
        /* 0x02D4 */ public float GhostbusterSpeed2;
        /* 0x02D8 */ public float GhostbusterFreq2;
        /* 0x02DC */ public float GhostbusterAmp2;
        /* 0x02E0 */ public float GhostbusterStart3;
        /* 0x02E4 */ public float GhostbusterSpeed3;
        /* 0x02E8 */ public float GhostbusterFreq3;
        /* 0x02EC */ public float GhostbusterAmp3;
        /* 0x02F0 */ public bool WeaponZoomEnabled;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x02F1 */ public byte[] Padding2F1;
        /* 0x02F4 */ public float WeaponZoomFOV;
        /* 0x02F8 */ public float WeaponZoomRecoilMultiplier;
        /* 0x02FC */ public float WeaponZoomVertRotation;
        /* 0x0300 */ public float WeaponZoomHorzRotation;
        /* 0x0304 */ public bool FrontShieldEnabled;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0305 */ public byte[] Padding305;
        /* 0x0308 */ public float FrontShieldOffsetOff;
        /* 0x030C */ public float FrontShieldOffsetOn;
        /* 0x0310 */ public float FrontShieldSpeedSlowdown;
        /* 0x0314 */ public float CombatSpawnMinWantedTime;
        /* 0x0318 */ public float ExperienceHardPiratesDamagePotentialMin;
        /* 0x031C */ public float ExperienceHardPiratesDamagePotentialRange;
        /* 0x0320 */ public float ExperienceHardPiratesDamageMaxOdds;
        /* 0x0324 */ public float ExperienceMediumPiratesDamagePotentialMin;
        /* 0x0328 */ public float ExperienceMediumPiratesDamagePotentialRange;
        /* 0x032C */ public float ExperienceMediumPiratesDamageMaxOdds;
        /* 0x0330 */ public float CommunicatorSpeed;
        /* 0x0334 */ public float GrenadeBounceDamping;
        /* 0x0338 */ public float GrenadeBounceMaxSpeed;
        /* 0x033C */ public float GrenadeStopExplodeTime;
        /* 0x0340 */ public float CockpitEjectTestSphereRadius;
        /* 0x0344 */ public float CockpitEjectTestSphereRange;
        /* 0x0348 */ public float CockpitEjectSideTestRange;
        /* 0x034C */ public float WeaponShotgunSlowdown;
        /* 0x0350 */ public int   MouseSmoothMode; // should be enum
        /* 0x0354 */ public Vector2f MouseSpringStrength;
        /* 0x035C */ public Vector2f MouseSpringStrengthMinDelta;
        /* 0x0364 */ public Vector2f MouseSpringStrengthMaxDelta;
        /* 0x036C */ public float HardModeEnergyDischargeRateLow;
        /* 0x0370 */ public float HardModeEnergyDischargeRateMedium;
        /* 0x0374 */ public float HardModeEnergyDischargeRateHigh;
        /* 0x0378 */ public float HazardDamageMinTime;
        /* 0x037C */ public float EnergyDamageMinTime;
        /* 0x0380 */ public float EnergyDischargeRateLow;
        /* 0x0384 */ public float EnergyDischargeRateMedium;
        /* 0x0388 */ public float EnergyDischargeRateHigh;
        /* 0x038C */ public float EnergyDischargeRateFloatingInSpace;
        /* 0x0390 */ public float EnergyPainRate;
        /* 0x0394 */ public float SolarRegenFactor;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0398 */ public byte[] Padding398;
        /* 0x03A0 */ public Colour DefaultMuzzleColour;
        /* 0x03B0 */ public Colour TerrainEditorMuzzleColourSubtract;
        /* 0x03C0 */ public Colour TerrainEditorMuzzleColourAdd;
        /* 0x03D0 */ public Colour TerrainEditorMuzzleColourUndo;
        /* 0x03E0 */ public Colour DefaultMuzzleLaserColour;
        /* 0x03F0 */ public float FreeJetpackRange;
        /* 0x03F4 */ public float FreeJetpackRangeNonTerrain;
        /* 0x03F8 */ public float JetpackDrainHorizontalFactor;
        /* 0x03FC */ public float MinTimeAfterMeleeBeforeBoost;
        /* 0x0400 */ public float MaxTimeAfterMeleeBeforeBoost;
        /* 0x0404 */ public float MeleeBoostAirForce;
        /* 0x0408 */ public float MeleeToAirBoostInitialImpulse;
        /* 0x040C */ public float MaxTimeInMeleeBoost;
        /* 0x0410 */ public bool RocketBootsEnabled;
        /* 0x0411 */ public bool RocketBootsUseCustomCamera;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x0412 */ public byte[] Padding412;
        /* 0x0414 */ public float RocketBootsActivationWindow;
        /* 0x0418 */ public float RocketBootsDoubleTapTime;
        /* 0x041C */ public float RocketBootsImpulse;
        /* 0x0420 */ public float RocketBootsBoostForce;
        /* 0x0424 */ public float RocketBootsDriftForce;
        /* 0x0428 */ public float RocketBootsForceStartTime;
        /* 0x042C */ public float RocketBootsForceDuration;
        /* 0x0430 */ public float RocketBootsMinDesiredHeight;
        /* 0x0434 */ public float RocketBootsMaxDesiredHeight;
        /* 0x0438 */ public float RocketBootsHeightAdjustTime;
        /* 0x043C */ public float RocketBootsHeightAdjustUpStrength;
        /* 0x0440 */ public float RocketBootsHeightAdjustDownStrength;
        /* 0x0444 */ public float RocketBootsJetpackMinLevel;
        /* 0x0448 */ public float RocketBootsBoostTankDrainSpeed;
        /* 0x044C */ public float RocketBootsDriftTankDrainSpeed;
        /* 0x0450 */ public float RocketBootsBoostOnTime;
        /* 0x0454 */ public float RocketBootsBoostOffTime;
        /* 0x0458 */ public float RocketBootsZigZagStrength;
        /* 0x045C */ public float RocketBootsZigZagForceDuration;
        /* 0x0460 */ public float RocketBootsMaxSpeed;
        /* 0x0464 */ public float RocketBootsDriftEndTime;
        /* 0x0468 */ public float RocketBootsWindUpBraking;
        /* 0x046C */ public float RocketBootsDriftBraking;
        /* 0x0470 */ public float RocketBootsDriftDownwardForce;
        /* 0x0474 */ public float JetpackForce;
        /* 0x0478 */ public float JetpackBrake;
        /* 0x047C */ public float JetpackMinLevel;
        /* 0x0480 */ public float JetpackMaxSpeed;
        /* 0x0484 */ public float JetpackMaxUpSpeed;
        /* 0x0488 */ public float JetpackUpForce;
        /* 0x048C */ public float JetpackIgnitionForce;
        /* 0x0490 */ public float JetpackIgnitionTime;
        /* 0x0494 */ public float JetpackMinIgnitionTime;
                     [NMS(Size = 0x03)]
        /* 0x0498 */ public float[] JetpackTankTimes;
        /* 0x04A4 */ public float JetpackFillRate;
        /* 0x04A8 */ public float JetpackFillRateHardMode;
        /* 0x04AC */ public float JetpackFillRateSpaceStationMultiplier;
        /* 0x04B0 */ public float JetpackUpForceDeadPlanetExtra;
        /* 0x04B4 */ public float JetpackForceDeadPlanetExtra;
        /* 0x04B8 */ public float JetpackIgnitionForceDeadPlanetExtra;
        /* 0x04BC */ public bool EnableHeadMovements;
        /* 0x04BD */ public bool ClampPitch;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x04BE */ public byte[] Padding4BE;
        /* 0x04C0 */ public float DamageRepairFactor;
        /* 0x04C4 */ public float DamageRepairFactorHardMode;
        /* 0x04C8 */ public float NormalModeHazardTimeMultiplier;
        /* 0x04CC */ public float NormalModeHazardDamageRateMultiplier;
        /* 0x04D0 */ public float NormalModeHazardDamageWoundRateMultiplier;
        /* 0x04D4 */ public float NormalModeSubstanceRewardMultiplier;
        /* 0x04D8 */ public float NormalModeHazardRechargeUnderground;
        /* 0x04DC */ public float HardModeHazardTimeMultiplier;
        /* 0x04E0 */ public float HardModeHazardDamageRateMultiplier;
        /* 0x04E4 */ public float HardModeHazardDamageWoundRateMultiplier;
        /* 0x04E8 */ public float HardModeSubstanceRewardMultiplier;
        /* 0x04EC */ public float HardModeHazardRechargeUnderground;
        /* 0x04F0 */ public float FreighterProbeScanTime;
        /* 0x04F4 */ public int MaxNumDestroyEffects;
        /* 0x04F8 */ public int MinNumDestroyEffects;
        /* 0x04FC */ public float ProjectileEndTime;
        /* 0x0500 */ public float ExplosionTimePerEffect;
        /* 0x0504 */ public float ExplosionTimeVariance;
        /* 0x0508 */ public float ExplosionScaleVariance;
        /* 0x050C */ public float ExplosionBoundingInset;
        /* 0x0510 */ public float ExplosionBoundingInsetRange;
        /* 0x0514 */ public float DestroyEffectFinalDelay;
        /* 0x0518 */ public float ShipPriceExp2;
        /* 0x051C */ public float WeaponPriceExp2;
        /* 0x0520 */ public float FreighterPriceExp2;
        /* 0x0524 */ public float ShipCoolFactor;
        /* 0x0528 */ public float WeaponCoolFactor;
        /* 0x052C */ public float FreighterCoolFactor;
        /* 0x0530 */ public bool MouseCrosshairVisible;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0531 */ public byte[] Padding531;
        /* 0x0534 */ public float MouseMaxLength;
        /* 0x0538 */ public float MouseDeadZone;
        /* 0x053C */ public float MouseAimZone;
        /* 0x0540 */ public float MouseCrosshairMaxAlpha;
        /* 0x0544 */ public float MouseCrosshairAlphaFade;
        /* 0x0548 */ public float MouseCrosshairAlphaFadeSpeed;
        /* 0x054C */ public float MouseCrosshairLineAlpha;
        /* 0x0550 */ public float MouseCrosshairLineWidth;
        /* 0x0554 */ public float MouseCrosshairShipStrength;
        /* 0x0558 */ public float MouseCrosshairMultiplier;
        /* 0x055C */ public bool UseEnergy;
        /* 0x055D */ public bool InventoryDamage;
        /* 0x055E */ public bool NeverPreyedOn;
        /* 0x055F */ public bool PermanantFire;
        /* 0x0560 */ public bool PermanantAltFire;
        /* 0x0561 */ public bool LuckyWithTech;
                     [NMS(Size = 0x02, Ignore = true)]
        /* 0x0562 */ public byte[] Padding562;
        /* 0x0564 */ public int BulletCostReducer;
        /* 0x0568 */ public int BulletClipMultiplier;
        /* 0x056C */ public float LootForceMultiplier;
        /* 0x0570 */ public float WoundTimeMinimum;
        /* 0x0574 */ public float WoundDamageLimit;
        /* 0x0578 */ public float WoundDamageLimitShip;
        /* 0x057C */ public float WoundDamageDecayTime;
        /* 0x0580 */ public float ResourceBlobFinalScaleDistance;
        /* 0x0584 */ public float LaserPlayerOffset;
        /* 0x0588 */ public float WalkerAlertRange;
        /* 0x058C */ public float WalkerSightRange;
        /* 0x0590 */ public float WalkerSightAngle;
        /* 0x0594 */ public float CombatEscalateTime;
        /* 0x0598 */ public float CombatEscapeRadius;
        /* 0x059C */ public float CombatEscapeTime;
        /* 0x05A0 */ public bool UpgradeExosuitWithProduct;
                     [NMS(Size = 0x07, Ignore = true)]
        /* 0x05A1 */ public byte[] Padding5A1;
                     [NMS(Size = 0x10)]
        /* 0x05A8 */ public string ExosuitUpgradeProduct;
        /* 0x05B8 */ public int SuitInventoryStartSeed;
        /* 0x05BC */ public int MaxNumShipsAttackingPlayer;
        /* 0x05C0 */ public float ObjectScanTime;
        /* 0x05C4 */ public float DroneProbeScanTime;
        /* 0x05C8 */ public int PirateHailPercent;
        /* 0x05CC */ public float PirateBountyInitTime;
        /* 0x05D0 */ public float PirateProbeInitTime;
        /* 0x05D4 */ public float PirateProbeAttackWaitTime;
        /* 0x05D8 */ public float PirateProbeAttackWarnTime;
        /* 0x05DC */ public float PirateProbeScanTime;
        /* 0x05E0 */ public float PirateProbeScanTotalTime;
        /* 0x05E4 */ public float PirateProbeHailPause;
        /* 0x05E8 */ public float PirateBattleMarkerRange;
        /* 0x05EC */ public float PirateBattleWarnTime;
        /* 0x05F0 */ public float PirateBattleMarkerTime;
        /* 0x05F4 */ public float PirateBattleMaxTime;
                     [NMS(Size = 0x20)]
        /* 0x05F8 */ public string TraderHailReceiveOSDLoc;
                     [NMS(Size = 0x20)]
        /* 0x0618 */ public string TraderHailRefusedOSDLoc;
        /* 0x0638 */ public float TraderHailTime;
        /* 0x063C */ public float TraderApproachTime;
        /* 0x0640 */ public float TraderHailDistance;
        /* 0x0644 */ public float TraderApproachDistance;
        /* 0x0648 */ public float TraderSpamTimeWait;
        /* 0x064C */ public float TraderStayCloseLockOffset;
        /* 0x0650 */ public float TraderStayCloseLockSin1Coeff;
        /* 0x0654 */ public float TraderStayCloseLockSin1Offset;
        /* 0x0658 */ public float TraderStayCloseLockSin2Coeff;
        /* 0x065C */ public float TraderStayCloseLockSin2Offset;
        /* 0x0660 */ public float TraderStayCloseLockSinsAdd;
        /* 0x0664 */ public float TraderStayCloseLockSpread;
        /* 0x0668 */ public float TraderStayCloseLockSpreadAdd;
        /* 0x066C */ public float TraderStayCloseLockSpreadTime;
        /* 0x0670 */ public float TraderHealthFightThreshold;
        /* 0x0674 */ public int TraderCommunicationBanMinTime;
        /* 0x0678 */ public int TraderCommunicationBanMaxTime;
        /* 0x067C */ public float LaserMiningDamageMultiplier;
        /* 0x0680 */ public float ShieldRechargeMinTimeSinceDamage;
        /* 0x0684 */ public float ShieldRechargeRate;
        /* 0x0688 */ public float MoveStickHighRangeLimit;
        /* 0x068C */ public float WitnessAIDamageDistance;
        /* 0x0690 */ public float WitnessAIDamageAngle;
        /* 0x0694 */ public float DeathDamageDrainChargeFactor;
        /* 0x0698 */ public int DeathDamageTechBrokenPercent;
        /* 0x069C */ public float MaxProjectileRadiusMultiplier;
        /* 0x06A0 */ public float HardLandPainTime;
        /* 0x06A4 */ public int GunBaseClipSize;
        /* 0x06A8 */ public int GrenadeBaseClipSize;
        /* 0x06AC */ public float MeleeCooldown;
        /* 0x06B0 */ public float ChargeMeleeCooldown;
        /* 0x06B4 */ public float MeleeDistance;
        /* 0x06B8 */ public float MeleeDistance3P;
        /* 0x06BC */ public float MeleeRadius;
        /* 0x06C0 */ public float MeleeHitTime;
        /* 0x06C4 */ public float MeleeSpeedBoost;
        /* 0x06C8 */ public float MeleeSpeedDamageBoost;
        /* 0x06CC */ public float MeleeSpeedBoostRangeMultiplier;
        /* 0x06D0 */ public float MeleeStaminaDrain;
        /* 0x06D4 */ public float TemperatureDisplaySampleTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x06D8 */ public byte[] Padding6D8;
        /* 0x06E0 */ public Colour StarFieldColour;
        /* 0x06F0 */ public float StarFieldRadius;
        /* 0x06F4 */ public float StarFieldDensity;
        /* 0x06F8 */ public float StarFieldStarSize;
        /* 0x06FC */ public float SpeedLinesSpeedMin;
        /* 0x0700 */ public float SpeedLinesSpeedMax;
        /* 0x0704 */ public float SpeedLinesLength;
        /* 0x0708 */ public float SpeedLinesTotalLength;
        /* 0x070C */ public float SpeedLinesWidthMin;
        /* 0x0710 */ public float SpeedLinesWidthMax;
        /* 0x0714 */ public float SpeedLinesRadiusStartMin;
        /* 0x0718 */ public float SpeedLinesRadiusStartMax;
        /* 0x071C */ public float SpeedLinesRadiusIncrement;
        /* 0x0720 */ public float SpeedLinesStartFade;
        /* 0x0724 */ public float SpeedLinesMinAlpha;
        /* 0x0728 */ public float SpeedLinesMaxAlpha;
        /* 0x072C */ public float SpeedLinesOffset;
        /* 0x0730 */ public float SleepFadeTime;
        /* 0x0734 */ public float StaminaRate;
        /* 0x0738 */ public float StaminaRecoveryRate;
        /* 0x073C */ public float StaminaRecoveredFactor;
        /* 0x0740 */ public float ScanLabelTime;
        /* 0x0744 */ public float ScanWobbleFreq;
        /* 0x0748 */ public float ScanWobbleAmp;
        /* 0x074C */ public float ScanWobbleFreq2;
        /* 0x0750 */ public float ScanWobbleAmp2;
        /* 0x0754 */ public float ScanRotate;
        /* 0x0758 */ public float ScanRotateDist;
        /* 0x075C */ public float ScanRotateWobbleAmp;
        /* 0x0760 */ public float ScanFadeInTime;
        /* 0x0764 */ public float ScanFadeOutTime;
        /* 0x0768 */ public float ScanBeamWidth;
        /* 0x076C */ public float ScanRotateBeamWdith;
        /* 0x0770 */ public float ScanBeamMainWidth;
        /* 0x0774 */ public float WantedDroneEventRadius;
        /* 0x0778 */ public float WantedMinSpaceTime;
        /* 0x077C */ public float WantedMinPlanetTime;
        /* 0x0780 */ public float WantedLevelDelay;
        /* 0x0784 */ public float WantedWitnessTimer;
        /* 0x0788 */ public float WantedWitnessFuzzyTime;
        /* 0x078C */ public float WantedMinorCrimeAmount;
        /* 0x0790 */ public float WantedTimeoutAggressive;
                     [NMS(Size = 0x05)]
        /* 0x0794 */ public float[] WantedTimeout;
                     [NMS(Size = 0x05)]
        /* 0x07A8 */ public float[] WantedEscalateTime;
                     [NMS(Size = 0x05)]
        /* 0x07BC */ public float[] WantedExtremeEscalateTime;
        /* 0x07D0 */ public int ControlModes; // should be enum
        /* 0x07D4 */ public float InteractionScanRange;
        /* 0x07D8 */ public float InteractionButtonRange;
        /* 0x07DC */ public float InteractionFocusTime;
        /* 0x07E0 */ public float InteractionSubstanceRange;
        /* 0x07E4 */ public float HeatShieldTime;
        /* 0x07E8 */ public float LaserShakeMin;
        /* 0x07EC */ public float LaserShakeMax;
        /* 0x07F0 */ public float GunRecoil;
        /* 0x07F4 */ public float LaserRecoil;
        /* 0x07F8 */ public float BeamRecoil;
        /* 0x07FC */ public float GrenadeRecoil;
        /* 0x0800 */ public float GunRecoilSpring;
        /* 0x0804 */ public float BlastRecoilSpring;
        /* 0x0808 */ public float RailRecoilSpring;
        /* 0x080C */ public float PulseRecoilSpring;
        /* 0x0810 */ public float GunRecoilSettleSpring;
        /* 0x0814 */ public float ThirdPersonRecoilMultiplier;
        /* 0x0818 */ public float GunRecoilMin;
        /* 0x081C */ public float GunRecoilMax;
        /* 0x0820 */ public float ProjectileDamageFalloff;
        /* 0x0824 */ public float ShotgunDispersion;
        /* 0x0828 */ public GcResourceCollectEffect TerrainResourceCollect;
        /* 0x085C */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        /* 0x0890 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        /* 0x08C4 */ public GcResourceCollectEffect CrystalResourceCollect;
        /* 0x08F8 */ public GcResourceCollectEffect ShardResourceCollect;
        /* 0x092C */ public GcBoidData MissileSwarm;
        /* 0x0958 */ public GcPlayerStickData StickData;
        /* 0x0974 */ public bool AutoAim;
                     [NMS(Size = 0x03, Ignore = true)]
        /* 0x0975 */ public byte[] Padding975;
        /* 0x0978 */ public float AutoAimMaxAccelFactor;
        /* 0x097C */ public float AutoAimFixedInterceptSpeed;
        /* 0x0980 */ public float AutoAimTimeOut;
        /* 0x0984 */ public float AutoAimMaxAngle;
        /* 0x0988 */ public float AutoAimMinScreenDistance;
        /* 0x098C */ public float AutoAimRadiusExtra;
        /* 0x0990 */ public float AutoAimStickyMin;
        /* 0x0994 */ public float AutoAimStickyMax;
        /* 0x0998 */ public TkCurveType AutoAimDotCurve;
        /* 0x099C */ public TkCurveType AutoAimCentreOffsetCurve;
        /* 0x09A0 */ public float AimDistanceShip;
        /* 0x09A4 */ public float AimSpeed;
        /* 0x09A8 */ public float AimWeightAdd;
        /* 0x09AC */ public float AimMinWeight;
        /* 0x09B0 */ public float AimDecay;
        /* 0x09B4 */ public float AimOffset;
        /* 0x09B8 */ public float AimShootableTargetAngle;
        /* 0x09BC */ public float AimDisperseTime;
        /* 0x09C0 */ public float AimDisperseMinTime;
        /* 0x09C4 */ public float AimDisperseCooldownTime;
        /* 0x09C8 */ public float AimDisperseCooldownFactor;
        /* 0x09CC */ public TkCurveType AimDisperseCurve;
        /* 0x09D0 */ public float CrosshairTime;
        /* 0x09D4 */ public float BeaconActivateRange;
        /* 0x09D8 */ public int ExperienceMaxCivilianShipSpawns;
        /* 0x09DC */ public float ExperiencePirateFreighterAttackRange;
        /* 0x09E0 */ public float ExperienceWalkerSize;
        /* 0x09E4 */ public float ExperienceInterestingShipDistance;
        /* 0x09E8 */ public float ExperienceInterestingFreighterDistance;
        /* 0x09EC */ public float ExperienceInterestingDroneDistance;
        /* 0x09F0 */ public float ExperienceShipTimeMin;
        /* 0x09F4 */ public float ExperienceShipTimeMax;
        /* 0x09F8 */ public int ExperiencePirateCloseAttackPercentage;
        /* 0x09FC */ public float ExperiencePirateTimeMin;
        /* 0x0A00 */ public float ExperiencePirateTimeMax;
        /* 0x0A04 */ public float ExperienceDroneTimeMin;
        /* 0x0A08 */ public float ExperienceDroneTimeMax;
        /* 0x0A0C */ public float ExperienceFlybyScareRadius;
        /* 0x0A10 */ public float ExperienceFlybyScareTime;
        /* 0x0A14 */ public Vector2f ExperienceFlybyStartAngle;
        /* 0x0A1C */ public float ExperienceAlertRange;
        /* 0x0A20 */ public float ExperienceAlertSightRange;
        /* 0x0A24 */ public float ExperienceAlertSightAngle;
        /* 0x0A28 */ public float ExperienceDroneSpawnOffset;
        /* 0x0A2C */ public float ExperienceDroneSpawnAngle;
        /* 0x0A30 */ public float ExperienceMessageBroadcastNearbyDistance;
        /* 0x0A34 */ public float WantedEnemyAttackAmount;
                     [NMS(Size = 0x80)]
        /* 0x0A38 */ public string Gun;
        /* 0x0AB8 */ public float StickDeadZoneMin;
        /* 0x0ABC */ public float StickDeadZoneMax;
        /* 0x0AC0 */ public TkCurveType StickCurve;
        /* 0x0AC4 */ public float AutoLandRange;
        /* 0x0AC8 */ public float AutoLandTime;
        /* 0x0ACC */ public float LabelSpringTime;
        /* 0x0AD0 */ public float LabelOffset;
        /* 0x0AD4 */ public float AtmosphereEffectTime;
        /* 0x0AD8 */ public float AtmosphereEffectOffset;
                     [NMS(Size = 0x07)]
        /* 0x0ADC */ public GcCreatureAlertData[] AlertTable;
        /* 0x0B84 */ public float PainFlickerAmount;
        /* 0x0B88 */ public float PainColourSeperateAmount;
        /* 0x0B8C */ public float PainTime;
        /* 0x0B90 */ public GcProjectileLineData PlayerBullet;
        /* 0x0BB8 */ public GcProjectileLineData RobotBullet;
        /* 0x0BE0 */ public GcProjectileLineData ShipBullet;
        /* 0x0C08 */ public float ExplodeShakeMaxDist;
        /* 0x0C0C */ public float ExplodeShakeMaxDistSpace;
        /* 0x0C10 */ public float ExplodeShakeStrength;
        /* 0x0C14 */ public float FlashSize;
        /* 0x0C18 */ public float FlashPosX;
        /* 0x0C1C */ public float FlashPosY;
        /* 0x0C20 */ public float FlashPosZ;
        /* 0x0C24 */ public float FlashSpeed;
        /* 0x0C28 */ public float FlashPulse;
        /* 0x0C2C */ public float FlashGrow;
        /* 0x0C30 */ public float GunRightOffset;
        /* 0x0C34 */ public float GunUpOffset;
        /* 0x0C38 */ public float LaserBeamMineRate;
        /* 0x0C3C */ public float LaserBeamCore;
        /* 0x0C40 */ public float LaserBeamFlickerAmp;
        /* 0x0C44 */ public float LaserBeamFlickerFreq;
        /* 0x0C48 */ public float LaserEndOffset;
        /* 0x0C4C */ public float GrenadeTerrainDeformRadius;
        /* 0x0C50 */ public float LaserBeamTerrainDeformRadius;
        /* 0x0C54 */ public float LaserBeamTerrainDeformVariance;
        /* 0x0C58 */ public float LaserBeamOverheatTime;
        /* 0x0C5C */ public float LaserBeamAmmoUseTime;
        /* 0x0C60 */ public float ReloadButtonHoldTimeToHolster;
        /* 0x0C64 */ public float WeaponChangeModeTime;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0C68 */ public byte[] PaddingC68;
        /* 0x0C70 */ public Vector4f WeaponBarrelOffset;
        /* 0x0C80 */ public Vector4f WeaponOffset;
        /* 0x0C90 */ public float WeaponLowerDelay;
        /* 0x0C94 */ public float WeaponHolsterDelay;
        /* 0x0C98 */ public float WeaponLag;
        /* 0x0C9C */ public float WeaponBobFactorWalkDeadZone;
        /* 0x0CA0 */ public float WeaponBobFactorWalk;
        /* 0x0CA4 */ public float WeaponBobFactorRun;
        /* 0x0CA8 */ public float WeaponBobBlendTime;
        /* 0x0CAC */ public TkCurveType WeaponBobBlendCurve;
        /* 0x0CB0 */ public float WeaponGrenadeTime;
        /* 0x0CB4 */ public float WeaponGunTime;
        /* 0x0CB8 */ public float WeaponRailFireTime;
        /* 0x0CBC */ public float WeaponRailRechargeTime;
        /* 0x0CC0 */ public int MaxBuildHeight;
        /* 0x0CC4 */ public float SpaceMaxGravityDist;
        /* 0x0CC8 */ public float SpaceMinGravityDist;
        /* 0x0CCC */ public float BulletBend;
        /* 0x0CD0 */ public float ShootSizeMinZ;
        /* 0x0CD4 */ public float ShootSizeMaxZ;
        /* 0x0CD8 */ public float ShootSizeMinXY;
        /* 0x0CDC */ public float ShootSizeMaxXY;
        /* 0x0CE0 */ public float ShootSizeTime;
        /* 0x0CE4 */ public float ShootSizeBase;
        /* 0x0CE8 */ public float ShootOffset;
        /* 0x0CEC */ public float ShootPrepTime;
        /* 0x0CF0 */ public float GrenadeCarveRadius;
        /* 0x0CF4 */ public float ChargeTime;
        /* 0x0CF8 */ public float EnergyBallSpeed;
        /* 0x0CFC */ public float ChargedEnergyBallSpeed;
        /* 0x0D00 */ public float LookRayRadius;
        /* 0x0D04 */ public float PickRange;
        /* 0x0D08 */ public float DamageRateWhenUnderNoGravity;
        /* 0x0D0C */ public float TakeDamageImpulse;
        /* 0x0D10 */ public float HardLandTime;
        /* 0x0D14 */ public float HardLandMin;
        /* 0x0D18 */ public float HardLandMax;
        /* 0x0D1C */ public float MeleeRange;
        /* 0x0D20 */ public float MeleeTime;
        /* 0x0D24 */ public float MeleeForcePush;
        /* 0x0D28 */ public float MeleeOffset;
        /* 0x0D2C */ public float PushForceAirFactor;
        /* 0x0D30 */ public int HUDHeightPosX;
        /* 0x0D34 */ public int HUDHeightPosY;
        /* 0x0D38 */ public float TargetDistance;
        /* 0x0D3C */ public float TargetRadius;
        /* 0x0D40 */ public float HoldForce;
        /* 0x0D44 */ public float HoldTime;
        /* 0x0D48 */ public float HoldActionDistX;
        /* 0x0D4C */ public float HoldActionDistY;
        /* 0x0D50 */ public float HoldActionDistZ;
        /* 0x0D54 */ public float HoldDistX;
        /* 0x0D58 */ public float HoldDistY;
        /* 0x0D5C */ public float HoldDistZ;
        /* 0x0D60 */ public float HoldMaxForce;
        /* 0x0D64 */ public float HoldRotate;
        /* 0x0D68 */ public float BalanceStrength;
        /* 0x0D6C */ public float BalanceSpeed;
        /* 0x0D70 */ public float GroundWalkForce;
        /* 0x0D74 */ public float GroundWalkBrake;
        /* 0x0D78 */ public float GroundWalkBrakeWhileMoving;
        /* 0x0D7C */ public float GroundWalkSpeed;
        /* 0x0D80 */ public float GroundRunSpeed;
        /* 0x0D84 */ public float GroundWalkRecoverySpeedDamper;
        /* 0x0D88 */ public float ExertionSmoothTime;
        /* 0x0D8C */ public float ExertionFromPainTime;
        /* 0x0D90 */ public float AnimWalkSpeed;
        /* 0x0D94 */ public float AnimRunSpeed;
        /* 0x0D98 */ public float AnimWalkToRunSpeed;
        /* 0x0D9C */ public float AnimWalkBlendPoint;
        /* 0x0DA0 */ public float AnimRunBlendPoint;
        /* 0x0DA4 */ public float MaxSlopeAngle;
        /* 0x0DA8 */ public float SlopeSlidingSpeed;
        /* 0x0DAC */ public float SlopeSlideBrake;
        /* 0x0DB0 */ public float MinSlideTime;
        /* 0x0DB4 */ public float MaxWalkableSlopeAngle;
        /* 0x0DB8 */ public float MinSpidermanSlopeAngle;
        /* 0x0DBC */ public float MinTimeToHoldSpidermanPose;
        /* 0x0DC0 */ public float MaxSpidermanSlopeAngle;
        /* 0x0DC4 */ public float MaxClingableSlopeAngle;
        /* 0x0DC8 */ public float MinimumPushOffForceToSlide;
        /* 0x0DCC */ public float FullClipReloadSpeedMultiplier;
        /* 0x0DD0 */ public float ReloadTapButtonSpeedIncrease;
        /* 0x0DD4 */ public float ClingBrakeMultiplier;
        /* 0x0DD8 */ public float ClingAngleThreshold;
        /* 0x0DDC */ public float ClingSpeedThreshold;
        /* 0x0DE0 */ public float ClimbableStickinessAngle;
        /* 0x0DE4 */ public float MinUpAmount;
        /* 0x0DE8 */ public float FootOffset;
        /* 0x0DEC */ public float MaxFallSpeed;
        /* 0x0DF0 */ public float PushForceDecay;
        /* 0x0DF4 */ public float LeanFwdMaxAngle;
        /* 0x0DF8 */ public float LeanBackMaxAngle;
        /* 0x0DFC */ public float LeanLeftMaxAngle;
        /* 0x0E00 */ public float LeanRightMaxAngle;
        /* 0x0E04 */ public float LeanAmount;
        /* 0x0E08 */ public float LeanAmountFwd;
        /* 0x0E0C */ public float HelmetLag;
        /* 0x0E10 */ public float HelmetMaxLag;
        /* 0x0E14 */ public float HelmetBob;
        /* 0x0E18 */ public float JetpackHelmetBob;
        /* 0x0E1C */ public float ShipCameraLag;
        /* 0x0E20 */ public float MaxResource;
        /* 0x0E24 */ public float ShieldRestoreSpeed;
        /* 0x0E28 */ public float ShieldRestoreDelay;
        /* 0x0E2C */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
        /* 0x0E30 */ public float DeathScreenFadeInThirdPerson;
        /* 0x0E34 */ public float DeathScreenFadeInUnderwaterThirdPerson;
        /* 0x0E38 */ public float DeathScreenFadeInTime;
        /* 0x0E3C */ public float DeathScreenShipFadeInTime;
        /* 0x0E40 */ public float DeathScreenPauseTime;
        /* 0x0E44 */ public float DeathScreenMaxRegenWaitTime;
        /* 0x0E48 */ public float DeathScreenMinRegenWaitTime;
        /* 0x0E4C */ public float DeathScreenFadeOutTime;
        /* 0x0E50 */ public GcPlayerStickData LookStickData;
        /* 0x0E6C */ public GcPlayerStickData AmbientModeLookStickData;
        /* 0x0E88 */ public int LowHealthEffectPips;
        /* 0x0E8C */ public int LowHealthEffectShield;
        /* 0x0E90 */ public float CriticalHitTime;
        /* 0x0E94 */ public float CriticalHitDesatTime;
        /* 0x0E98 */ public float CriticalHitDesatFreq;
                     [NMS(Size = 0x02)]
        /* 0x0E9C */ public GcCameraSpawnSetupData[] FirstSpawnDataTable;
        /* 0x0EBC */ public GcInventoryValueData ShipValueData;
        /* 0x0ED8 */ public GcInventoryValueData WeaponValueData;
        /* 0x0EF4 */ public GcInventoryValueData FreighterValueData;
                     [NMS(Size = 0x07)]
        /* 0x0F10 */ public float[] TechRarityData;
                     [NMS(Size = 0x06)]
        /* 0x0F2C */ public float[] TechLearningProbabilities;
        /* 0x0F44 */ public int NumTechShopSlots;
        /* 0x0F48 */ public float GrassPushDistance;
                     [NMS(Size = 0x04, Ignore = true)]
        /* 0x0F4C */ public byte[] PaddingF4C;
        /* 0x0F50 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        /* 0x0F90 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        /* 0x0FD0 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        /* 0x1010 */ public GcJourneyMedalTiers MedalTiers;
        /* 0x1020 */ public int LowGuildRank;
        /* 0x1024 */ public int MedGuildRank;
        /* 0x1028 */ public int HighGuildRank;
        /* 0x102C */ public int BestGuildRank;
        /* 0x1030 */ public float LaserWeaponRange;
        /* 0x1034 */ public float LaserShipRange;
        /* 0x1038 */ public float TerrainLaserRange;
        /* 0x103C */ public float VehicleLaserRange;
        /* 0x1040 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        /* 0x1090 */ public GcShipDialogue TraderHailMessages;
                     [NMS(Size = 0x04)]
        /* 0x12F8 */ public GcShipDialogueTreeEnum[] TraderHailReceiveRegular;
                     [NMS(Size = 0x02)]
        /* 0x1308 */ public GcShipDialogueTreeEnum[] TraderHailReceiveFight;
                     [NMS(Size = 0x04)]
        /* 0x1310 */ public GcShipDialogueTreeEnum[] TraderHailSend;
    }
}
