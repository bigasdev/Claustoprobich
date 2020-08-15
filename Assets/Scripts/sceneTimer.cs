using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTimer : MonoBehaviour
{
    [SerializeField] private float reachT;
    [SerializeField] private int nextScene;
    private float timer;
    [SerializeField] private bool needMusic;
    private AudioSource music;
    private void Start()
    {
        music = GameObject.Find("MenuMusic").GetComponent<AudioSource>();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= reachT)
        {
            SceneManager.LoadScene(nextScene);
        }

        if(timer>= reachT && needMusic)
        {
            music.Stop();
        }
    }
}
