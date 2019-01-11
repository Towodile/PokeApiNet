﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Net.Models
{
    class Move
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The percent value of how likely this move is to be successful.
        /// </summary>
        public int Accuracy { get; set; }

        /// <summary>
        /// The percent value of how likely it is this moves effect will happen.
        /// </summary>
        public int EffectChance { get; set; }

        /// <summary>
        /// Power points. The number of times this move can be used.
        /// </summary>
        public int Pp { get; set; }

        /// <summary>
        /// A value between -8 and 8. Sets the order in which moves are executed
        /// during battle. See
        /// [Bulbapedia](http://bulbapedia.bulbagarden.net/wiki/Priority)
        /// for greater detail.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// The base power of this move with a value of 0 if it does not have
        /// a base power.
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// A detail of normal and super contest combos that require this move.
        /// </summary>
        public ContestComboSets ContestCombos { get; set; }

        /// <summary>
        /// The type of appeal this move gives a Pokémon when used in a contest.
        /// </summary>
        public NamedApiResource ContestType { get; set; }

        /// <summary>
        /// The effect the move has when used in a contest.
        /// </summary>
        public ApiResource ContestEffect { get; set; }

        /// <summary>
        /// The type of damage the move inflicts on the target, e.g. physical.
        /// </summary>
        public NamedApiResource DamageClass { get; set; }

        /// <summary>
        /// The effect of this move listed in different languages.
        /// </summary>
        public List<VerboseEffect> EffectEntries { get; set; }

        /// <summary>
        /// The list of previous effects this move has had across version
        /// groups of the games.
        /// </summary>
        public List<AbilityEffectChange> EffectChanges { get; set; }

        /// <summary>
        /// The flavor text of this move listed in different languages.
        /// </summary>
        public List<MoveFlavorText> FlavorTextEntries { get; set; }

        /// <summary>
        /// The generation in which this move was introduced.
        /// </summary>
        public NamedApiResource Generation { get; set; }

        /// <summary>
        /// A list of the machines that teach this move.
        /// </summary>
        public List<MachineVersionDetail> Machines { get; set; }

        /// <summary>
        /// Metadata about this move
        /// </summary>
        public MoveMetaData Meta { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }

        /// <summary>
        /// A list of move resource value changes across version groups
        /// of the game.
        /// </summary>
        public List<PastMoveStatValues> PastValues { get; set; }

        /// <summary>
        /// A list of stats this moves effects and how much it
        /// effects them.
        /// </summary>
        public List<MoveStatChange> StatChanges { get; set; }

        /// <summary>
        /// The effect the move has when used in a super contest.
        /// </summary>
        public ApiResource SuperContestEffect { get; set; }

        /// <summary>
        /// The type of target that will receive the effects of the attack.
        /// </summary>
        public NamedApiResource Target { get; set; }

        /// <summary>
        /// The elemental type of this move.
        /// </summary>
        public NamedApiResource Type { get; set; }
    }

    class ContestComboSets
    {
        /// <summary>
        /// A detail of moves this move can be used before or after,
        /// granting additional appeal points in contests.
        /// </summary>
        public ContestComboDetail Normal { get; set; }

        /// <summary>
        /// A detail of moves this move can be used before or after,
        /// granting additional appeal points in super contests.
        /// </summary>
        public ContestComboDetail Super { get; set; }
    }

    class ContestComboDetail
    {
        /// <summary>
        /// A list of moves to use before this move.
        /// </summary>
        public List<NamedApiResource> UseBefore { get; set; }

        /// <summary>
        /// A list of moves to use after this move.
        /// </summary>
        public List<NamedApiResource> UseAfter { get; set; }
    }

    class MoveFlavorText
    {
        /// <summary>
        /// The localized flavor text for an api resource in a
        /// specific language.
        /// </summary>
        public string FlavorText { get; set; }

        /// <summary>
        /// The language this name is in.
        /// </summary>
        public NamedApiResource Language { get; set; }

        /// <summary>
        /// The version group that uses this flavor text.
        /// </summary>
        public NamedApiResource VersionGroup { get; set; }
    }

    class MoveMetaData
    {
        /// <summary>
        /// The status ailment this move inflicts on its target.
        /// </summary>
        public NamedApiResource Ailment { get; set; }

        /// <summary>
        /// The category of move this move falls under, e.g. damage or
        /// ailment.
        /// </summary>
        public NamedApiResource Category { get; set; }

        /// <summary>
        /// The minimum number of times this move hits. Null if it always
        /// only hits once.
        /// </summary>
        public int MinHits { get; set; }

        /// <summary>
        /// The maximum number of times this move hits. Null if it always
        /// only hits once.
        /// </summary>
        public int MaxHits { get; set; }

        /// <summary>
        /// The minimum number of turns this move continues to take effect.
        /// Null if it always only lasts one turn.
        /// </summary>
        public int MinTurns { get; set; }

        /// <summary>
        /// The maximum number of turns this move continues to take effect.
        /// Null if it always only lasts one turn.
        /// </summary>
        public int MaxTurns { get; set; }

        /// <summary>
        /// HP drain (if positive) or Recoil damage (if negative), in percent
        /// of damage done.
        /// </summary>
        public int Drain { get; set; }

        /// <summary>
        /// The amount of hp gained by the attacking Pokemon, in percent of
        /// it's maximum HP.
        /// </summary>
        public int Healing { get; set; }

        /// <summary>
        /// Critical hit rate bonus.
        /// </summary>
        public int CritRate { get; set; }

        /// <summary>
        /// The likelihood this attack will cause an ailment.
        /// </summary>
        public int AilmentChance { get; set; }

        /// <summary>
        /// The likelihood this attack will cause the target Pokémon to flinch.
        /// </summary>
        public int FlinchChance { get; set; }

        /// <summary>
        /// The likelihood this attack will cause a stat change in the target
        /// Pokémon.
        /// </summary>
        public int StatChance { get; set; }
    }

    class MoveStatChange
    {
        /// <summary>
        /// The amount of change
        /// </summary>
        public int Change { get; set; }

        /// <summary>
        /// The stat being affected.
        /// </summary>
        public NamedApiResource Stat { get; set; }
    }

    class PastMoveStatValues
    {
        /// <summary>
        /// The percent value of how likely this move is to be successful.
        /// </summary>
        public int Accuracy { get; set; }

        /// <summary>
        /// The percent value of how likely it is this moves effect will
        /// take effect.
        /// </summary>
        public int EffectChance { get; set; }

        /// <summary>
        /// The base power of this move with a value of 0 if it does not have
        /// a base power.
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Power points. The number of times this move can be used.
        /// </summary>
        public int Pp { get; set; }

        /// <summary>
        /// The effect of this move listed in different languages.
        /// </summary>
        public List<VerboseEffect> EffectEntries { get; set; }

        /// <summary>
        /// The elemental type of this move.
        /// </summary>
        public NamedApiResource Type { get; set; }

        /// <summary>
        /// The version group in which these move stat values were in effect.
        /// </summary>
        public NamedApiResource VersionGroup { get; set; }
    }

    class MoveAilment
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of moves that cause this ailment.
        /// </summary>
        public List<NamedApiResource> Moves { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }
    }

    class MoveBattleStyle
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }
    }

    class MoveCategory
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of moves that fall into this category.
        /// </summary>
        public List<NamedApiResource> Moves { get; set; }

        /// <summary>
        /// The description of this resource listed in different languages.
        /// </summary>
        public List<Descriptions> Descriptions { get; set; }
    }

    class MoveDamageClass
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of moves that fall into this damage class.
        /// </summary>
        public List<NamedApiResource> Moves { get; set; }

        /// <summary>
        /// The description of this resource listed in different languages.
        /// </summary>
        public List<Descriptions> Descriptions { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }
    }

    class MoveLearnMethod
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this resource listed in different languages.
        /// </summary>
        public List<Descriptions> Descriptions { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }

        /// <summary>
        /// A list of version groups where moves can be learned through this method.
        /// </summary>
        public List<NamedApiResource> VersionGroups { get; set; }
    }

    class MoveTarget
    {
        /// <summary>
        /// The identifier for this resource.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name for this resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of this resource listed in different languages.
        /// </summary>
        public List<Descriptions> Descriptions { get; set; }

        /// <summary>
        /// A list of moves that that are directed at this target.
        /// </summary>
        public List<NamedApiResource> Moves { get; set; }

        /// <summary>
        /// The name of this resource listed in different languages.
        /// </summary>
        public List<Names> Names { get; set; }
    }
}