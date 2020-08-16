using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class algorithm : MonoBehaviour
{
    public static int firstSequence;
    public static int secondSequence;
    public static int thirdSequence;
    public static int forthSequence;

    public static bool first = true;
    public static bool second;
    public static bool third;
    public static bool forth;

    [SerializeField] private Animator anim;
    [SerializeField] private Animator transtion;

    private void Update()
    {
        if(first && firstSequence == 1)
        {
            StartCoroutine(wiatforNext());
            first = false;
            second = true;
        }

        if(second && firstSequence == 2 && secondSequence == 1)
        {
            StartCoroutine(wiatforNext());
            second = false;
            third = true;
        }

        if (third && firstSequence == 3 && secondSequence == 2 && thirdSequence == 1)
        {
            StartCoroutine(wiatforNext());
            third = false;
            forth = true;
        }

        if (forth && firstSequence == 4 && secondSequence == 3 && thirdSequence == 2 && forthSequence == 1)
        {
            StartCoroutine(endGameAnim());
        }
    }

    IEnumerator wiatforNext()
    {
        yield return new WaitForSeconds(1f);
        anim.SetTrigger("Yes");
    }

    IEnumerator endGameAnim()
    {
        transtion.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(12);
    }
}
