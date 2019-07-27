﻿using System.ComponentModel;
using System.Configuration;
using Magitek.Enumerations;
using Magitek.Models.Roles;
using PropertyChanged;

namespace Magitek.Models.Bard
{
    [AddINotifyPropertyChangedInterface]
    public class BardSettings : PhysicalDpsSettings, IRoutineSettings
    {
        public BardSettings() : base(CharacterSettingsDirectory + "/Magitek/Bard/BardSettings.json") { }

        public static BardSettings Instance { get; set; } = new BardSettings();

        [Setting]
        [DefaultValue(50)]
        public int UserLatencyOffset { get; set; }

        #region SingleTarget

        [Setting]
        [DefaultValue(true)]
        public bool UseHeavyShot { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseStraightShot { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseBloodletter { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool PrioritizeBloodletterDuringMagesBallard { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseSidewinder { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseEmpyrealArrow { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool DelayEmpyrealArrowUntilAPEnds { get; set; }

        [Setting]
        [DefaultValue(1)]
        public int DontUseEmpyrealArrowWhenSongEndsInXSeconds { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UsePitchPerfect { get; set; }

        [Setting]
        [DefaultValue(3)]
        public int UsePitchPerfectAtRepertoire { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UsePitchPerfectAtTheEndOfWanderersMinuet { get; set; }

        [Setting]
        [DefaultValue(2)]
        public int UsePitchPerfectWithinTheLastXSecondsOfWanderersMinuet { get; set; }

        #endregion

        #region DamageOverTime

        [Setting]
        [DefaultValue(3)]
        public int RefreshDotsWithLessThanXSecondsRemaining { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool DontDotIfEnemyIsDyingSoon { get; set; }

        [Setting]
        [DefaultValue(20)]
        public int DontDotIfEnemyIsDyingWithinXSeconds { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseWindBite { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseVenomousBite { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseIronJaws { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool SnapShotWithIronJaws { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool EnableMultiDotting { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool MultiDotWindBite { get; set; }

        [Setting]
        [DefaultValue(0)]
        public int MultiDotWindBiteUpToXEnemies { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool MultiDotVenomousBite { get; set; }

        [Setting]
        [DefaultValue(0)]
        public int MultiDotVenomousBiteUpToXEnemies { get; set; }

        #endregion

        #region AoE

        [Setting]
        [DefaultValue(true)]
        public bool UseApexArrow { get; set; }

        [Setting]
        [DefaultValue(100)]
        public int UseApexArrowWithAtLeastXSoulVoice { get; set; }

        #endregion

        #region Songs

        [Setting]
        [DefaultValue(SongStrategy.WM_MB_AP)]
        public SongStrategy CurrentSongPlaylist { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseSongs { get; set; }

        [Setting]
        [DefaultValue(1)]
        public int DefaultSongTransitionTime { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool EndArmysPaeonEarly { get; set; }

        [Setting]
        [DefaultValue(10)]
        public int EndArmysPaeonEarlyWithXSecondsRemaining { get; set; }

        #endregion

        #region Cooldowns

        [Setting]
        [DefaultValue(BuffStrategy.Always)]
        public BuffStrategy UseCoolDowns { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseRageingStrikes { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool DelayRageingStrikes { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseRageingStrikesOnlyDuringWanderersMinuet { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool DelayRageingStrikesUntilBarrageIsReady { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool DelayRageingStrikesDuringWanderersMinuet { get; set; }

        [Setting]
        [DefaultValue(4)]
        public int DelayRageingStrikesDuringWanderersMinuetUntilXSecondsInWM { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseBarrage { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseBarrageOnlyWithRageingStrikes { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseBattleVoice { get; set; }

        #endregion

        #region Utilities

        [Setting]
        [DefaultValue(false)]
        public bool ForceTroubadour { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool UseHeadGraze { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool OnlyInterruptCurrentTarget { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool RepellingShot { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool RepellingShotOnlyWhenTargeted { get; set; }

        #endregion

        [Setting]
        [DefaultValue(true)]
        public bool UseAoe { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseAoeBeforeDots { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool QuickNock { get; set; }

        [Setting]
        [DefaultValue(3)]
        public int QuickNockEnemiesInCone { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool RainOfDeath { get; set; }

        [Setting]
        [DefaultValue(3)]
        public int RainOfDeathEnemies { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool Dispel { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool NaturesMinne { get; set; }

        [Setting]
        [DefaultValue(50.0f)]
        public float NaturesMinneHealthPercent { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool NaturesMinneTanks { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool NaturesMinneHealers { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool NaturesMinneDps { get; set; }

        [Setting]
        [DefaultValue(70.0f)]
        public float RestHealthPercent { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool UseSideWinderOnlyOnTrick { get; set; }

    }
}