using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] charPrefebs;
    public GameObject player;
    void Start()
    {
        player = Instantiate(charPrefebs[(int)DataMgr.instance.currentCharacter]);
        player.transform.position = transform.position;
    }
}
