using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISDestructable
    {
        int durability
        {
            get;
        }

        int maxDurability
        {
            get;
        }

        void TakeDamage(int _amount);

        void Break();

        void Repair();
    }
}
