using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectCollider : MonoBehaviour
{
    [SerializeField] private GameObject papel;
    [SerializeField] private bool isEnd;
    [SerializeField] private int nextroom;
    [SerializeField] private Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            papel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            papel.SetActive(false);
            if(isEnd)
            {
                StartCoroutine(endGameAnim());
            }
        }
    }

    IEnumerator endGameAnim()
    {
        anim.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextroom);
    }
}
