using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepObjectAlive : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
