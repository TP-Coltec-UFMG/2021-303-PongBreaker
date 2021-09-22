using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepObjectAlive : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] filtro = GameObject.FindGameObjectsWithTag(this.tag);
        if( filtro.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
