using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepObjectAlive : MonoBehaviour
{
    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Music").Length <= 1)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
