using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    [SerializeField] private GameObject miniBox;
    [SerializeField] private Transform spawnerPlace;
    private bool onPlace;


    private void Update()
    {
        if(onPlace)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(miniBox, spawnerPlace.position, spawnerPlace.rotation);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            onPlace = true;
        }
    }
}
