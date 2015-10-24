using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    [System.Serializable]
    public class ISObject : IISObject
    {
        [SerializeField]Sprite icon;
        [SerializeField]string name;
        [SerializeField]int itemValue;
        [SerializeField]int burden;
        [SerializeField]ISQuality quality;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Value
        {
            get
            {
                return itemValue;
            }
            set
            {
                itemValue = value;
            }
        }

        public Sprite Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
            }
        }

        public int Burden
        {
            get
            {
                return burden;
            }
            set
            {
                burden = value;
            }
        }

        public ISQuality Quality
        {
            get
            {
                return quality;
            }
            set
            {
                quality = value;
            }
        }
    }
}
