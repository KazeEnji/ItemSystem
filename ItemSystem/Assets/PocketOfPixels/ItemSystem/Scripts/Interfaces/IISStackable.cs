using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem
{
    public interface IISStackable
    {
        int Stack(int _amount); //Default of 0

        int MaxStack
        {
            get;
        }
    }
}
