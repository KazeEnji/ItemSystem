using UnityEditor;
using UnityEngine;
using System.Collections;

namespace PocketOfPixels.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        ISWeaponDatabase weaponDatabase;

        const string DATABASE_NAME = @"PoPWeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

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
            if(weaponDatabase == null)
            {
                weaponDatabase = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
            }
        }

        void OnGUI()
        {
            TopTabBar();

            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

            BottomStatusBar();
        }
    }
}
