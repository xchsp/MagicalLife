﻿using EarthWithMagicAPI.API.Interfaces.Spells;
using System;
using System.Collections.Generic;

namespace EarthWithMagicAPI.API.Interfaces.Items
{
    public abstract class IItem
    {
        /// <summary>
        /// The damage this item does when it is used to attack.
        /// </summary>
        public Damage Damage = new Damage(Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), Util.Die.Zero(), new Util.Die(0, 0, 1));

        /// <summary>
        /// The ID of the item.
        /// </summary>
        public Guid ID = new Guid();

        public bool IsCursed = false;

        /// <summary>
        /// Holds whether or not the item is equipped.
        /// </summary>
        public bool IsEquipped = false;

        /// <summary>
        /// The level of the item. Used to determine what loot table to put it on.
        /// </summary>
        public int Level;

        /// <summary>
        /// The flavor text/lore of the item.
        /// </summary>
        public List<string> Lore;

        /// <summary>
        /// The human readable name of the item.
        /// </summary>
        public string Name;

        /// <summary>
        /// Any other information the item might display.
        /// </summary>
        public List<string> OtherInformation;

        /// <summary>
        /// The name of the creature that possesses this item.
        /// </summary>
        public string Owner = "";

        /// <summary>
        /// Returns if the item is a quest item.
        /// </summary>
        public bool QuestItem = false;

        /// <summary>
        /// The base value of the item, that if the player has 100% trading skills, they will get.
        /// </summary>
        public int Value;

        /// <summary>
        /// The weight of the item.
        /// </summary>
        public double Weight;

        /// <summary>
        /// Called whenever the item is bought.
        /// </summary>
        public abstract void Bought();

        public abstract void Equip();

        /// <summary>
        /// Gets the impact an item has on the character when it is equipped.
        /// </summary>
        /// <returns></returns>
        public abstract StatsImpact EquipImpact();

        /// <summary>
        /// Called whenever the item is sold.
        /// </summary>
        public abstract void Sold();

        /// <summary>
        /// Called whenever the player is hit by a spell, such as a dispel.
        /// </summary>
        public abstract void SpellHit(ISpell spell);

        /// <summary>
        /// Called whenever the player equips the item.
        /// </summary>
        /// <summary>
        /// Called whenever the player un equips the item.
        /// </summary>
        public abstract void Unequip();

        /// <summary>
        /// If the item has a special ability, or can be consumed it should happen when this is called.
        /// </summary>
        public abstract void Use();

        /// <summary>
        /// Called whenever the player is hit by a weapon.
        /// </summary>
        /// <param name="attacker"></param>
        public abstract void WeaponHit(IWeapon attacker);
    }

    /// <summary>
    /// Holds the impact an item will have on a player's stats.
    /// Ex: If you set Strength to -2, the player that equips this will have their strength lowered by 2.
    /// </summary>
    public struct StatsImpact
    {
        public int AC;
        public int AcidResistance;
        public int Charisma;
        public int CharmResistance;
        public int ColdResistance;
        public int Constitution;
        public int Dexterity;
        public int Dodge;
        public int ElectricResistance;
        public int FireResistance;
        public int Health;
        public int Initiative;
        public int MagicResistance;
        public int PoisonResistance;
        public int SleepResistance;
        public int Strength;
        public int WeightCapacity;
        public int Wisdom;

        public StatsImpact(int charisma, int dexterity, int strength, int constitution, int wisdom, int ac,
            int health, int weightCapacity, int fireResistance, int acidResistance, int poisonResistance, int electricResistance, int coldResistance, int magicResistance, int charmResistance,
            int sleepResistance, int initiative, int dodge)
        {
            this.Charisma = charisma;
            this.Dexterity = dexterity;
            this.Strength = strength;
            this.Constitution = constitution;
            this.Wisdom = wisdom;

            this.AC = ac;
            this.Health = health;
            this.WeightCapacity = weightCapacity;
            this.FireResistance = fireResistance;
            this.AcidResistance = acidResistance;
            this.PoisonResistance = poisonResistance;
            this.ElectricResistance = electricResistance;
            this.ColdResistance = coldResistance;
            this.MagicResistance = magicResistance;
            this.CharmResistance = charmResistance;
            this.SleepResistance = sleepResistance;
            this.Initiative = initiative;
            this.Dodge = dodge;
        }
    }
}