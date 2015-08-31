using UnityEngine;
using UnityEditor;
using System.Collections;

namespace PocketOfPixels.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor
    {
        //List all of the stored qualities in the database.
        void ListView()
        {
            _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));

            DisplayQualities();

            EditorGUILayout.EndScrollView();
        }

        void DisplayQualities()
        {
            for(int i = 0; i < qualityDatabase.Count; i++)
            {
                GUILayout.BeginHorizontal("Box");

                //Sprite
                if(qualityDatabase.Get(i).Icon)
                {
                    selectedTex = qualityDatabase.Get(i).Icon.texture;
                }
                else
                {
                    selectedTex = null;
                }

                if(GUILayout.Button(selectedTex, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                {
                    int _controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                    EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, _controllerID);
                    selectedIndex = i;
                }

                string _commandName = Event.current.commandName;

                if (_commandName == "ObjectSelectorUpdated")
                {
                    if(selectedIndex != -1)
                    {
                        qualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        //selectedIndex = -1;
                    }
                    Repaint();
                }
                GUILayout.BeginVertical();
                //Name
                qualityDatabase.Get(i).Name = GUILayout.TextField(qualityDatabase.Get(i).Name);

                //Delete button
                if (GUILayout.Button("x", GUILayout.Width(30), GUILayout.Height(25)))
                {
                    if(EditorUtility.DisplayDialog("Delete Quality",
                                                    "Are you sure that you want to delete: " + qualityDatabase.Get(i).Name + "?",
                                                    "Delete",
                                                    "Cancel"))
                    {
                        qualityDatabase.Remove(i);
                    }
                }
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();
            }
        }
    }
}