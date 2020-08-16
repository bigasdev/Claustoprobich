using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeWidow : MonoBehaviour
{
    [SerializeField] private GameObject[] layouts;
    private float timer;
    private float reachT = 5f;
    private int numberScreens = 0;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= reachT && numberScreens <= 12)
        {           
            layouts[numberScreens].SetActive(true);
            numberScreens += 1;
            timer = 0f;
        }
    }
}
