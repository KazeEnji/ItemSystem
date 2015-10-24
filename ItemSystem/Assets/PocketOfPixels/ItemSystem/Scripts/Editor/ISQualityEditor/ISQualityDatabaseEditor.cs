using UnityEngine;
using UnityEditor;
using System.Collections;

namespace PocketOfPixels.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        ISQualityDatabase qualityDatabase;
        Texture2D selectedTex;
        int selectedIndex = -1;
        Vector2 _scrollPos; //Scroll position for the list view.

        const int SPRITE_BUTTON_SIZE = 46;

        const string DATABASE_NAME = @"PoPQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

        [MenuItem("PoP/Database/Quality Editor %#w")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.titleContent = new GUIContent("Quality DB");
            window.Show();
        }

        void OnEnable()
        {
            if(qualityDatabase == null)
            {
                qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
            }
        }

        void OnGUI()
        {
            if(qualityDatabase == null)
            {
                Debug.LogWarning("Quality Database not loaded.");
                return;
            }

            ListView();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            //Count
            GUILayout.Label("Qualities: " + qualityDatabase.Count);

            //Add button
            if(GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }
    }
}
