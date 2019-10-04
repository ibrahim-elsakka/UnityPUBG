﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Items
{
    [CreateAssetMenu(menuName = "UnityPUBG Items/MeleeWeapon")]
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(int id, string name, ItemRarity rarity, float damage, float attackSpeed, float attackRange, float knockbackPower) : base(id, name, rarity, damage, attackSpeed, attackRange, knockbackPower)
        {
        }
    }
}
