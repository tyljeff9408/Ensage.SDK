// <copyright file="phantom_assassin_phantom_strike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_phantom_assassin
{
    public class phantom_assassin_phantom_strike : RangedAbility, IHasModifier
    {
        public phantom_assassin_phantom_strike(Ability ability)
            : base(ability)
        {
        }

        public string ModifierName { get; } = "modifier_phantom_assassin_phantom_strike";
    }
}