using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquipable, IISGameObject
    {
        [SerializeField]int _minDamage;
        [SerializeField]int _durability;
        [SerializeField]int _maxDurability;

        public ISWeapon(int durability, int maxDurability)
        {
            _durability = durability;
            _maxDurability = maxDurability;
        }

        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
            set
            {
                _minDamage = value;
            }
        }

        public int Attack()
        {
            throw new System.NotImplementedException();
        }

        public int durability
        {
            get 
            {
                return durability;
            }
        }

        public int maxDurability
        {
            get 
            {
                return _maxDurability;
            }
        }

        public void TakeDamage(int amount)
        {
            _durability -= amount;

            if(_durability < 0)
            {
                _durability = 0;
            }
        }

        public void Break()
        {
            throw new System.NotImplementedException();
        }

        public void Repair()
        {
            throw new System.NotImplementedException();
        }
    }
}

