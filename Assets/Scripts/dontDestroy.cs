using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public static bool musicMute;
    [SerializeField] private bool isEnd;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
