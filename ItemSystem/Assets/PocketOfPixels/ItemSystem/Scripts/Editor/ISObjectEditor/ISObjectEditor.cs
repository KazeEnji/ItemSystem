﻿using UnityEditor;
using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        [MenuItem("PoP/Database/Item System Editor %#i")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent = new GUIContent("Item System");
            window.Show();
        }

        void OnEnable()
        {

        }

        void OnGUI()
        {
            TopTabBar();
            ListView();
            ItemDetails();
        }
    }
}