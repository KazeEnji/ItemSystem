using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PocketOfPixels
{
    public class ScriptableObjectDatabase<T> : ScriptableObject where T: class
    {
        [SerializeField]List<T> database = new List<T>();

        public void Add(T _item)
        {
            database.Add(_item);
            EditorUtility.SetDirty(this);
        }

        public void Insert(int _index, T _item)
        {
            database.Insert(_index, _item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(T _item)
        {
            database.Remove(_item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(int _index)
        {
            database.RemoveAt(_index);
            EditorUtility.SetDirty(this);
        }

        public int Count
        {
            get
            {
                return database.Count;
            }
        }

        public T Get(int _index)
        {
            return database.ElementAt(_index);
        }

        public void Replace(int _index, T _item)
        {
            database[_index] = _item;
            EditorUtility.SetDirty(this);
        }

        public static U GetDatabase<U>(string _dbPath, string _dbName) where U : ScriptableObject
        {
            string _dbFullPath = @"Assets/" + _dbPath + "/" + _dbName;

            U db = AssetDatabase.LoadAssetAtPath(_dbFullPath, typeof(U)) as U;

            if (db == null)
            {
                //Check to see if the folder exists.
                if (!AssetDatabase.IsValidFolder(@"Assets/" + _dbPath))
                {
                    AssetDatabase.CreateFolder(@"Assets", _dbPath);
                }

                //Create the database andrefresh the AssetDatabase
                db = ScriptableObject.CreateInstance<U>() as U;
                AssetDatabase.CreateAsset(db, _dbFullPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }

            return db;
        }
    }
}
