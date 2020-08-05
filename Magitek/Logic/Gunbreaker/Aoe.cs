﻿using ff14bot;
using ff14bot.Managers;
using Magitek.Extensions;
using Magitek.Models.Gunbreaker;
using Magitek.Utilities;
using System.Linq;
using System.Threading.Tasks;
using static ff14bot.Managers.ActionResourceManager.Gunbreaker;

namespace Magitek.Logic.Gunbreaker
{
    internal static class Aoe
    {
        public static async Task<bool> DemonSlice()
        {
            if (Combat.Enemies.Count(r => r.Distance(Core.Me) <= 5 + r.CombatReach) < GunbreakerSettings.Instance.DemonSliceEnemies)
                return false;
            if (Core.Me.HasAura(Auras.ReadytoRip) || Core.Me.HasAura(Auras.ReadytoTear) || Core.Me.HasAura(Auras.ReadytoGouge))
                return false;
            return await Spells.DemonSlice.Cast(Core.Me);
        }

        public static async Task<bool> DemonSlaughter()
        {
            if (ActionManager.LastSpell != Spells.DemonSlice)
                return false;
            if (Core.Me.HasAura(Auras.ReadytoRip) || Core.Me.HasAura(Auras.ReadytoTear) || Core.Me.HasAura(Auras.ReadytoGouge))
                return false;
            if (Combat.Enemies.Count(r => r.Distance(Core.Me) <= 5 + r.CombatReach) < 1)
                return false;

            return await Spells.DemonSlaughter.Cast(Core.Me);
        }

        public static async Task<bool> BowShock()
        {
            if (!Core.Player.HasAura(Auras.NoMercy))
                return false;

            //Only use in the last 1/3rd of GCD window
            if (ActionManager.LastSpell.Cooldown.TotalMilliseconds < 850)
                return false;


            if (Combat.Enemies.Count(r => r.Distance(Core.Me) <= 5 + r.CombatReach) == 1 && Spells.SonicBreak.Cooldown.TotalMilliseconds > 1)
                return await Spells.BowShock.Cast(Core.Me);
            else
                return await Spells.BowShock.Cast(Core.Me);
            return false;
        }

        public static async Task<bool> FatedCircle()
        {
            if (Cartridge == 0)
                return false;
            if (Core.Me.HasAura(Auras.ReadytoRip) || Core.Me.HasAura(Auras.ReadytoTear) || Core.Me.HasAura(Auras.ReadytoGouge))
                return false;
            if (Combat.Enemies.Count(r => r.Distance(Core.Me) <= 5 + r.CombatReach) < GunbreakerSettings.Instance.FatedCircleEnemies)
                return false;

            if (Combat.Enemies.Count(r => r.Distance(Core.Me) <= 5 + r.CombatReach) == 2 && Spells.GnashingFang.Cooldown.TotalMilliseconds < 7800 && Cartridge == 1)
                return false; 

            return await Spells.FatedCircle.Cast(Core.Me);
        }
    }
}