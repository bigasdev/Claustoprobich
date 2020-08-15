using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    [SerializeField] private Animator[] anim;
    [SerializeField] private GameObject[] buttons;
    private AudioSource music;

    private void Start()
    {
        music = GameObject.Find("MenuMusic").GetComponent<AudioSource>();
    }
    public void Play()
    {
        anim[0].SetTrigger("Play");
        buttons[0].SetActive(false);
        buttons[1].SetActive(false);
        buttons[2].SetActive(false);
        buttons[3].SetActive(false);
        buttons[4].SetActive(false);
    }

    public void Credits()
    {
        anim[0].SetTrigger("Credits");
        anim[1].SetTrigger("Credits");
        anim[2].SetTrigger("Credits");
        buttons[2].SetActive(false);
        buttons[4].SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Music()
    {
        if(dontDestroy.musicMute == false)
        {
            dontDestroy.musicMute = true;
            music.Stop();
        }
        else
        {
            dontDestroy.musicMute = false;
            music.Play();
        }
        anim[3].SetTrigger("Music");
    }
}
