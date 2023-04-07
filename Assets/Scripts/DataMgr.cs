using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Player, Player2
}

public class DataMgr : MonoBehaviour
{
    public static DataMgr instance;
    public void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}