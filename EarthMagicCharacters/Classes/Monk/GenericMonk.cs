﻿// <copyright file="GenericMonk.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EarthMagicCharacters.Classes.Monk.Generic_Monk
{
    using EarthWithMagicAPI.API.Creature;
    using EarthWithMagicAPI.API.Interfaces.Items;
    using EarthWithMagicAPI.API.Util;
    using EarthWithMagicMagic.Abilities.Monk;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The base monk.
    /// </summary>
    public class GenericMonk : ICharacter
    {
        private bool _Hostile;

        /// <summary>
        /// Constructor for the GenericMonk class.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="race"></param>
        /// <param name="alignment"></param>
        /// <param name="name"></param>
        /// <param name="isHostile"></param>
        public GenericMonk(Gender gender, Race race = Race.Human, Alignment alignment = Alignment.LawfulGood, string name = "Monk", bool isHostile = false)
            : base(GetAtt(gender, race, alignment), new CreatureAbilities(),
            "EarthMagicDocumentation.Classes.Monk_Class_Info.md", "EarthMagicDocumentation.ASCII_Art.Monk.txt", new MonkAI())
        {
            this.creatureType = CreatureType.Humanoid;
            this.Name = name;
            this.Title = "Trainee";
            this._Hostile = isHostile;
            this.BareHands.Damage.BluntDamage = new Die(1, 8, 0);
        }

        public override void EquipItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public override bool IsHostile()
        {
            return this._Hostile;
        }

        public override void LevelUp()
        {
            if (this.Attributes.XP.LevelUpsAvailible > 0)
            {

                this.Attributes.BaseHealth += Dice.RollDice(new Die(1, 10, 2), this.Name + " gains hit points: ");

                switch (this.Attributes.XP.CreatureLevel)
                {
                    case 1:
                        this.Level2();
                        break;

                    case 2:
                        this.Level3();
                        break;

                    case 3:
                        this.Level4();
                        break;

                    case 4:
                        this.Level5();
                        break;

                    case 5:
                        this.Level6();
                        break;

                    case 6:
                        this.Level7();
                        break;

                    case 7:
                        this.Level8();
                        break;

                    case 8:
                        this.Level9();
                        break;

                    case 9:
                        this.Level10();
                        break;

                    case 10:
                        this.Level11();
                        break;

                    case 11:
                        this.Level12();
                        break;

                    case 12:
                        this.Level13();
                        break;

                    case 13:
                        this.Level14();
                        break;

                    case 14:
                        this.Level15();
                        break;

                    case 15:
                        this.Level16();
                        break;

                    case 16:
                        this.Level17();
                        break;

                    case 17:
                        this.Level18();
                        break;

                    case 18:
                        this.Level19();
                        break;

                    case 19:
                        this.Level20();
                        break;

                    case 20:
                        this.Level21();
                        break;

                    case 21:
                        this.Level22();
                        break;

                    case 22:
                        this.Level23();
                        break;

                    case 23:
                        this.Level24();
                        break;

                    case 24:
                        this.Level25();
                        break;

                    case 25:
                        this.Level26();
                        break;

                    case 26:
                        this.Level27();
                        break;

                    case 27:
                        this.Level28();
                        break;

                    case 28:
                        this.Level29();
                        break;

                    case 29:
                        this.Level30();
                        break;

                    case 30:
                        this.Level31();
                        break;

                    case 31:
                        this.Level32();
                        break;

                    case 32:
                        this.Level33();
                        break;

                    case 33:
                        this.Level34();
                        break;

                    case 34:
                        this.Level35();
                        break;

                    case 35:
                        this.Level36();
                        break;

                    case 36:
                        this.Level37();
                        break;

                    case 37:
                        this.Level38();
                        break;

                    case 38:
                        this.Level39();
                        break;

                    case 39:
                        this.Level40();
                        break;

                    case 40:
                        this.Level41();
                        break;

                    case 41:
                        this.Level42();
                        break;

                    case 42:
                        this.Level43();
                        break;

                    case 43:
                        this.Level44();
                        break;

                    case 44:
                        this.Level45();
                        break;

                    case 45:
                        this.Level46();
                        break;

                    case 46:
                        this.Level47();
                        break;

                    case 47:
                        this.Level48();
                        break;

                    case 48:
                        this.Level49();
                        break;

                    case 49:
                        this.Level50();
                        break;

                    case 50:
                        this.Level51();
                        break;

                    default:
                        Console.WriteLine("Level up not supported!");
                        break;
                }
            }
            else
            {
                Util.WriteLine("Level up not available!");
            }
        }

        public override void OnCreatureDied(ICreature dead)
        {
            if (!dead.IsHostile() && Dice.RollDice(new Die(1, 100, 0)) > 80)
            {
                switch (Dice.RollDice(new Die(1, 2, 0)))
                {
                    case 1:
                        Console.WriteLine("We have lost a comrade today. No matter " + dead.HimHerIT() + "'s personal struggles, " + dead.HimHerIT() + " was a valuable member of this party.");
                        break;

                    case 2:
                        Console.Write(dead.HeSheIT() + "was a friend. " + dead.HeSheIT() + " will be remembered.");
                        break;

                    default:
                        throw new Exception("Error! Switch not handled!");
                }
            }
        }

        public override void OnCreatureHealed(ICreature healer)
        {
        }

        public override void OnDealDamage()
        {
        }

        public override void OnItemUnequipped(IItem item)
        {
        }

        private static CreatureAttributes GetAtt(Gender gender, Race race, Alignment alignment)
        {
            int startingHealth = Dice.RollDice(new Die(2, 10, 2), "Starting Health");
            return new CreatureAttributes(gender, alignment, race, .04, startingHealth, startingHealth,
            Dice.RollDice(new Die(3, 6, 0), "Dexterity"), Dice.RollDice(new Die(3, 6, 0), "Strength"),
            Dice.RollDice(new Die(3, 6, 0), "Constitution"), Dice.RollDice(new Die(3, 6, 0), "Charisma"),
            Dice.RollDice(new Die(3, 6, 0), "Wisdom"), 0, 0, 0, 0, 0, 0, 0, 0, true, 12, .4, 30, Dice.RollDice(new Die(3, 6, 0), "Intelligence"));
        }

        #region LevelUps

        /// <summary>
        /// Gives this monk the ability to do 1 more stunning blow.
        /// </summary>
        private void AddStunningBlow()
        {
            StunningBlow a = new StunningBlow();
            foreach (IAbility item in this.ClassAbilities)
            {
                if (item.Name == a.Name)
                {
                    item.MaxUses++;
                    return;
                }
            }
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level10()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Disciple", "+10% dodge", "+1 stunning blow", "+5% hide in shadows", "+5% walk silently", "To hit: +1", "AC: +1" };

            this.Title = "Faithful Disciple";
            this.Attributes.BaseDodge += 10;
            this.AddStunningBlow();
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level11()
        {
            List<string> levelUpReport = new List<string> { "Title: Elite Disciple", "AC: +1", "+5% magic resistance" };

            this.Title = "Elite Disciple";
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level12()
        {
            List<string> levelUpReport = new List<string> { "Title: Master", "+5% hide in shadows", "+5% walk silently", "To hit: +1", "AC: +1" };

            this.Title = "Master";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level13()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Master", "Fist: 1d12 +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Faithful Master";
            this.BareHands.Damage.BluntDamage = new Die(1, 12, 1);
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level14()
        {
            List<string> levelUpReport = new List<string> { "Title: Elite Master", "+5% hide in shadows", "+5% walk silently", "To hit: +1", "AC: +1" };

            this.Title = "Elite Master";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level15()
        {
            List<string> levelUpReport = new List<string> { "Title: Superior Master", "+5% hide in shadows", "+5% walk silently", "+1 stunning blow", "AC: +1", "+5% magic resistance" };

            this.Title = "Superior Master";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.AddStunningBlow();
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level16()
        {
            List<string> levelUpReport = new List<string> { "Title: Dragonmaster", "Fist: 1d12 +2", "TH: +1", "AC: +1" };

            this.Title = "Dragonmaster";
            this.BareHands.Damage.BluntDamage = new Die(1, 12, 2);
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level17()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of the North Wind", "+5% hide in shadows", "+5% walk silently", "AC: +1", "+5% magic resistance" };

            this.Title = "Master of the North Wind";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level18()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of the West Wind", "Immunity to Non Magical Weapons", "TH: +1", "AC: +1" };

            this.Title = "Master of the West Wind";
            this.Abilities.BaseImmunityToNonMagicWeapons = true;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level19()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of the South Wind", "Fist: 1d14 +3", "+5% hide in shadows", "+5% walk silently", "AC: +1", "+5% magic resistance" };

            this.Title = "Master of the South Wind";
            this.BareHands.Damage.BluntDamage = new Die(1, 14, 3);
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level2()
        {
            List<string> levelUpReport = new List<string> { "Level up report: ", "Title: Faithless", "HP: +  1d10 +2", "AC: +1", "To hit: +1", "+20% poison resistance.", "+30% hide in shadows", "+30% walk silently" };

            this.Attributes.BasePoisonResistance += 20;
            this.Abilities.BaseHideInShadows += 30;
            this.Abilities.BaseWalkSilently += 30;
            this.Attributes.BaseHealth += Dice.RollDice(new Die(1, 10, 2));
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Title = "Faithless";
            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level20()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of the East Wind", "+1 stunning blow", "TH: +1", "+5% hide in shadows", "+5% walk silently", "AC: +1" };

            this.Title = "Master of the East Wind";
            this.AddStunningBlow();
            this.Attributes.BaseToHit++;
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level21()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of Winter", "Fist: 1d16 +3", "AC: +1", "+5% magic resistance" };

            this.Title = "Master of Winter";
            this.BareHands.Damage.BluntDamage = new Die(1, 16, 3);
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level22()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of Autumn", "+5% hide in shadows", "+5% walk silently", "TH: +1", "AC: +1" };

            this.Title = "Master of Autumn";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level23()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of Summer", "Fist: 1d18 +3", "AC: +1", "+5% magic resistance" };

            this.Title = "Master of Summer";
            this.BareHands.Damage.BluntDamage = new Die(1, 18, 3);
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level24()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of Spring", "+5% hide in shadows", "+5% walk silently", "TH: +1", "AC: +1" };

            this.Title = "Master of Spring";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level25()
        {
            List<string> levelUpReport = new List<string> { "Title: Student of the Oceans", "Fist: 1d20 +3", "+1 stunning blow", "AC: +1" };

            this.Title = "Student of the Oceans";
            this.BareHands.Damage.BluntDamage = new Die(1, 20, 3);
            this.AddStunningBlow();
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level26()
        {
            List<string> levelUpReport = new List<string> { "Title: Equal of the Oceans", "+5% hide in shadows", "+5% walk silently", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Equal of the Oceans";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level27()
        {
            List<string> levelUpReport = new List<string> { "Title: Master of the Oceans", "Breath Water", "Fist: 1d20 +4", "AC: +1" };

            this.Title = "Master of the Oceans";
            this.Abilities.BaseBreathWater = true;
            this.BareHands.Damage.BluntDamage = new Die(1, 20, 4);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level28()
        {
            List<string> levelUpReport = new List<string> { "Title: Eldritch Apprentice", "+5% hide in shadows", "+5% walk silently", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Eldritch Apprentice";
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level29()
        {
            List<string> levelUpReport = new List<string> { "Title: Eldritch Master", "Fist: 1d20 +5", "AC: +1" };

            this.Title = "Eldritch Master";
            this.BareHands.Damage.BluntDamage = new Die(1, 20, 5);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level3()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful", "AC: +1", "+20% fire resistance" };

            this.Title = "Faithful";
            ++this.Attributes.BaseAC;
            this.Attributes.BaseFireResistance += 20;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level30()
        {
            List<string> levelUpReport = new List<string> { "Title: Windwalker", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Windwalker";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level31()
        {
            List<string> levelUpReport = new List<string> { "Title: Elder", "Fist: 1d20 +5, 1d4 fire damage", "AC: +1" };

            this.Title = "Elder";
            this.BareHands.Damage.BluntDamage = new Die(1, 20, 5);
            this.BareHands.Damage.FireDamage = new Die(1, 4, 0);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level32()
        {
            List<string> levelUpReport = new List<string> { "Title: Sacred Elder", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Sacred Elder";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level33()
        {
            List<string> levelUpReport = new List<string> { "Title: Divinely Guided", "AC: +1" };

            this.Title = "Divinely Guided";
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level34()
        {
            List<string> levelUpReport = new List<string> { "Title: Mistwalker", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Mistwalker";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level35()
        {
            List<string> levelUpReport = new List<string> { "Title: Blinding Light", "Fist: 1d20 +5, 1d6 fire", "+1 stunning blow", "AC: +1" };

            this.Title = "Blinding Light";
            this.BareHands.Damage.FireDamage = new Die(1, 6, 0);
            this.AddStunningBlow();
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level36()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Soldier", "Fist: 1d20 +5, 1d6 +1 fire", "AC: +1" };

            this.Title = "Faithful Soldier";
            this.BareHands.Damage.FireDamage = new Die(1, 8, 1);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level37()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Leader", "Fist: 1d20 +5, 1d8 +1 fire", "AC: +1" };

            this.Title = "Faithful Leader";
            this.BareHands.Damage.FireDamage = new Die(1, 8, 1);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level38()
        {
            List<string> levelUpReport = new List<string> { "Title: Chosen One", "TH: +1", "AC: +1", "+5% magic resistance" };

            this.Title = "Chosen One";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level39()
        {
            List<string> levelUpReport = new List<string> { "Title: Divine Servant", "Fist: 1d20 +5, 1d10 +1 fire", "Immunity to poison", "AC: +1" };

            this.Title = "Divine Servant";
            this.BareHands.Damage.FireDamage = new Die(1, 10, 1);
            this.Abilities.ImmunityToPoison = true;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level4()
        {
            List<string> levelUpReport = new List<string> { "Apprentice", "AC: +1", "To hit +1", "+5% hide in shadows", "+5% walk silently" };

            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            ++this.Attributes.BaseToHit;
            ++this.Attributes.BaseAC;
            this.Title = "Apprentice";

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level40()
        {
            List<string> levelUpReport = new List<string> { "Title: Beacon of Faith", "+1 stunning blow", "AC: +1", "TH: +1", "+5% magic resistance" };

            this.Title = "Beacon of Faith";
            this.AddStunningBlow();
            this.Attributes.BaseAC++;
            this.Attributes.BaseToHit++;
            this.Attributes.BaseMagicResistance += 5;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level41()
        {
            List<string> levelUpReport = new List<string> { "Title: Beacon of Hope", "Fist: 1d20 +5, 1d14 +2 fire", "AC: +1" };

            this.Title = "Beacon of Hope";
            this.BareHands.Damage.FireDamage = new Die(1, 14, 2);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level42()
        {
            List<string> levelUpReport = new List<string> { "Title: Hero", "TH: +1", "AC: +1" };

            this.Title = "Hero";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level43()
        {
            List<string> levelUpReport = new List<string> { "Title: Renown Hero", "Fist: 1d20 +5, 1d16 +3 fire", "AC: +1" };

            this.Title = "Renown Hero";
            this.BareHands.Damage.FireDamage = new Die(1, 16, 3);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level44()
        {
            List<string> levelUpReport = new List<string> { "Title: Legendary Hero", "TH: +1", "AC: +1" };

            this.Title = "Legendary Hero";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level45()
        {
            List<string> levelUpReport = new List<string> { "Title: Inspiring Legend", "Fist: 1d20 +5, 1d20 +4 fire", "+1 stunning blow", "AC: +1" };

            this.Title = "Inspiring Legend";
            this.BareHands.Damage.FireDamage = new Die(1, 20, 4);
            this.AddStunningBlow();
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level46()
        {
            List<string> levelUpReport = new List<string> { "Title: Grandmaster", "Immunity to charm", "TH: +1", "AC: +1" };

            this.Title = "Grandmaster";
            this.Abilities.ImmunityToCharm = true;
            this.Attributes.BaseAC++;
            this.Attributes.BaseToHit++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level47()
        {
            List<string> levelUpReport = new List<string> { "Title: Elder Grandmaster", "Fist: 1d20 +5, 1d20 +5 fire", "TH: +1", "AC: +1" };

            this.Title = "Elder Grandmaster";
            this.BareHands.Damage.FireDamage = new Die(1, 20, 5);
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level48()
        {
            List<string> levelUpReport = new List<string> { "Title: Divine Apprentice", "TH: +1", "AC: +1" };

            this.Title = "Divine Apprentice";
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level49()
        {
            List<string> levelUpReport = new List<string> { "Title: Holy Commander", "Summon 4 angels", "Fist: 1d24 +5, 1d20 +5 fire", "AC: +1" };

            this.Title = "Holy Commander";
            SummonHolySection a = new SummonHolySection(1);
            a.DisplayImage();
            this.ClassAbilities.Add(a);
            this.BareHands.Damage.BluntDamage = new Die(1, 24, 5);
            this.BareHands.Damage.FireDamage = new Die(1, 20, 5);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level5()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Apprentice", "+1 stunning blow", "Fist: 1d10", "AC: +1" };

            this.Title = "Faithful Apprentice";
            StunningBlow a = new StunningBlow();
            a.DisplayImage();
            this.ClassAbilities.Add(a);
            ++this.Attributes.BaseAC;
            this.BareHands.Damage.BluntDamage = new Die(1, 10, 0);

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level50()
        {
            List<string> levelUpReport = new List<string> { "Title: Lesser Divinity", "Fists: 1d24 +5, 1d24 +5 fire", "AC: +1",
                "+3 dexterity", "+3 strength", "+1 charisma", "+1 wisdom", "+3 constitution", "+ 5d10 HP", "You are no longer a mere mortal"
            };

            this.Title = "Lesser Divinity";
            this.BareHands.Damage.FireDamage = new Die(1, 24, 5);
            this.Attributes.BaseAC++;
            this.Attributes.BaseDexterity += 3;
            this.Attributes.BaseStrength += 3;
            this.Attributes.BaseCharisma++;
            this.Attributes.BaseWisdom++;
            this.Attributes.BaseConstitution += 3;
            this.Attributes.BaseHealth += Dice.RollDice(new Die(5, 10, 0));
            this.IsMortal = false;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level51()
        {
            List<string> levelUpReport = new List<string> { "Title: Divine Commander", "Summon 8 angels", "+1 stunning blow", "TH: +1", "AC: +1" };

            this.Title = "Divine Commander";

            SummonHolySection a = new SummonHolySection(1);

            foreach (IAbility item in this.ClassAbilities)
            {
                if (item.Name == a.Name)
                {
                    item.MaxUses++;
                }
            }

            this.AddStunningBlow();
            this.Attributes.BaseToHit++;
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level6()
        {
            List<string> levelUpReport = new List<string> { "Title: Novice", "+20% cold resistance", "+5% hide in shadows", "+5% walk silently", "To hit: +1", "Ac: +1" };

            this.Title = "Novice";
            this.Attributes.BaseColdResistance += 20;
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            ++this.Attributes.BaseToHit;
            ++this.Attributes.BaseAC;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level7()
        {
            List<string> levelUpReport = new List<string> { "Title: Brother", "+20% resistance to sleep", "AC: +1" };

            this.Title = "Brother";
            this.Attributes.BaseSleepResistance += 20;
            ++this.Attributes.BaseAC;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level8()
        {
            List<string> levelUpReport = new List<string> { "Title: Faithful Brother", "+20% resistance to charms", "+5% hide in shadows", "+5% walk silently", "To hit +1", "AC: +1" };

            this.Title = "Faithful Brother";
            this.Attributes.BaseCharmResistance += 20;
            this.Abilities.BaseHideInShadows += 5;
            this.Abilities.BaseWalkSilently += 5;
            ++this.Attributes.BaseToHit;
            ++this.Attributes.BaseAC;

            Util.WriteLine(levelUpReport);
        }

        /// <summary>
        /// Does level up logic to bring the monk up to the next level.
        /// </summary>
        private void Level9()
        {
            List<string> levelUpReport = new List<string> { "Title: Disciple", "+5% magic resistance", "Fist: 1d10 +1", "AC: +1" };

            this.Title = "Disciple";
            this.Attributes.BaseMagicResistance += 5;
            this.BareHands.Damage.BluntDamage = new Die(1, 10, 1);
            this.Attributes.BaseAC++;

            Util.WriteLine(levelUpReport);
        }

        #endregion LevelUps
    }
}