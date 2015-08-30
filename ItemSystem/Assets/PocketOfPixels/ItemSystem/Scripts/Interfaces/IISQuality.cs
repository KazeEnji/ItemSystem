using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISQuality
    {
        string Name
        {
            get;
            set;
        }

        Sprite Icon
        {
            get;
            set;
        }
    }
}
