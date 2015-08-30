using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISEquipable
    {
        ISEquipmentSlot EquipmentSlot
        {
            get;
        }

        //Equip Slot
        bool Equip();
    }
}
