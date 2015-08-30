using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISObject
    {
        //Name
        string Name
        {
            get;
            set;
        }

        //Value - money
        int Value
        {
            get;
            set;
        }

        //Icon
        Sprite Icon
        {
            get;
            set;
        }

        //Burden system
        int Burden
        {
            get;
            set;
        }

        //Quality Level
        ISQuality Quality
        {
            get;
            set;
        }

        //These go to other item interfaces.
        //Key Item flag - something that doesn't take damage
    }
}
