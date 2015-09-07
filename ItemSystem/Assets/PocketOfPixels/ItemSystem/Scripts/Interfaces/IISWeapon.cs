using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISWeapon
    {
        int MinDamage
        {
            get;
            set;
        }

        int Attack();
    }
}
