using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            GUILayout.Button("Weapons");
            GUILayout.Button("Armor");
            GUILayout.Button("Potions");
            GUILayout.Button("About");
            GUILayout.EndHorizontal();
        }
    }
}
