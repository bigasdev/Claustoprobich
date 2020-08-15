using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public static bool musicMute;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
