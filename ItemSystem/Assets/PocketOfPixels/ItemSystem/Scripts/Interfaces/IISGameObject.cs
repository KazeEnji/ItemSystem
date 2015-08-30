using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISGameObject
    {
        GameObject Prefab
        {
            get;
            set;
        }
    }
}
