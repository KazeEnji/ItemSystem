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

        string IISObject.Name
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

        int IISObject.Value
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

        Sprite IISObject.Icon
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

        int IISObject.Burden
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

        ISQuality IISObject.Quality
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
