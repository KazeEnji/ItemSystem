using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    [System.Serializable]
    public class ISQuality : IISQuality
    {
        [SerializeField]string name;
        [SerializeField]Sprite icon;

        public ISQuality()
        {
            name = "";
            icon = new Sprite();
        }

        public ISQuality(string _name, Sprite _icon)
        {
            name = _name;
            icon = _icon;
        }

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
    }
}
