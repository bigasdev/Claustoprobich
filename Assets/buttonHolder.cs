using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHolder : MonoBehaviour
{
    public bool onMouse;
    [SerializeField] private GameObject seta;
    [SerializeField] private Transform where;
    private GameObject[] setas;

    private void Update()
    {
        setas = GameObject.FindGameObjectsWithTag("Seta");
        
        if(onMouse)
        {
            Instantiate(seta, where.position, where.rotation);
        }
        
    }
}
