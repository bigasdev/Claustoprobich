using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    [SerializeField] private int nextRoom;
    [SerializeField] private Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(endGameAnim());
    }

    IEnumerator endGameAnim()
    {
        anim.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextRoom);
    }

}
