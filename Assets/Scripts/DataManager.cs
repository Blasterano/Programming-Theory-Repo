using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance { get; private set; }

    public string playerName;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /*[System.Serializable]
    class SaveData
    {
        public string name;
    }

    public void SaveName()
    {

    }

    public void LoadName()
    {

    }*/
}
