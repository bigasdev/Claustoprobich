using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialMenu : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private endGame eg;
    private int whereis;

    public void click()
    {
        if (whereis != 3)
        {
            anim.SetTrigger("Hit");
            whereis += 1;
        }
        else
        {
            eg.IAnim();
        }
    }
}
