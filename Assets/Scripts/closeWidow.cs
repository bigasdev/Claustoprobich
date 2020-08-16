using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class closeWidow : MonoBehaviour
{
    [SerializeField] private GameObject[] layouts;
    private float timer;
    private float reachT = 5f;
    private int numberScreens = 0;
    [SerializeField] private int roomNumber;
    [SerializeField] private AudioSource heart;
    private bool isHeart;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= reachT && numberScreens <= 12)
        {           
            layouts[numberScreens].SetActive(true);
            numberScreens += 1;
            timer = 0f;
        }

        if(numberScreens == 7)
        {
            isHeart = true;
        }

        if(isHeart)
        {
            heart.Play();
            isHeart = false;
        }

        if(numberScreens >= 13)
        {
            SceneManager.LoadScene(roomNumber);
        }
    }
}
