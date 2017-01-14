﻿using Ensage;
using Ensage.Common.Extensions;

namespace Zaio.Helpers
{
    public static class MyUnitExtension
    {
        private static readonly string[] CantAttackModifiers =
        {
            "modifier_obsidian_destroyer_astral_imprisonment_prison",
            "modifier_abaddon_borrowed_time",
            "modifier_brewmaster_primal_split",
            "modifier_phoenix_supernova_hiding",
            "modifier_juggernaut_omnislash_invulnerability",
            "modifier_naga_siren_song_of_the_siren",
            "modifier_puck_phase_shift",
            "modifier_shadow_demon_disruption",
            "modifier_winter_wyvern_winters_curse_aura",
            "modifier_winter_wyvern_winters_curse",
            "modifier_storm_spirit_ball_lightning"
        };

        private static readonly string[] CantKillModifiers =
        {
            "modifier_dazzle_shallow_grave",
            "modifier_oracle_false_promise",
            "modifier_skeleton_king_reincarnation_scepter_active"
            // "modifier_slark_shadow_dance",
        };

        private static readonly string[] CantKillModifiersAxe =
        {
            "modifier_skeleton_king_reincarnation_scepter_active"
        };

        public static float MagicResistance(this Unit unit)
        {
            return unit.HasModifier("modifier_oracle_fates_edict") ? 1.0f : unit.MagicDamageResist;
        }

        public static bool CantBeKilled(this Unit unit)
        {
            return unit.HasModifiers(CantKillModifiers, false);
        }
        public static bool CantBeKilledByAxeUlt(this Unit unit)
        {
            return unit.HasModifiers(CantKillModifiersAxe, false);
        }

        public static bool CantBeAttacked(this Unit unit)
        {
            return unit.HasModifiers(CantAttackModifiers, false);
        }
    }
}