using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    [SerializeField] private LayerMask button;
    private buttonHolder bh;
    private SpriteRenderer opacity;
    private Vector2 cursorPos;

    private void Start()
    {
        opacity = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        opacity.color = new Color(0f, 0f, 0f, 0f);

        RaycastHit2D hit = Physics2D.Raycast(UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, button);

        if(hit)
        {
            opacity.color = new Color(1f, 1f, 1f, 1f);

            cursorPos = hit.collider.gameObject.transform.position;
            gameObject.transform.position = new Vector2(cursorPos.x + .35f, cursorPos.y + .75f);

            if(hit.collider.gameObject.tag == "FirstSequence" && Input.GetButtonDown("Fire1"))
            {
                algorithm.firstSequence += 1;
            }

            if (hit.collider.gameObject.tag == "SecondSequence" && Input.GetButtonDown("Fire1"))
            {
                algorithm.secondSequence += 1;
            }

            if (hit.collider.gameObject.tag == "ThirdSequence" && Input.GetButtonDown("Fire1"))
            {
                algorithm.thirdSequence += 1;
            }

            if (hit.collider.gameObject.tag == "ForthSequence" && Input.GetButtonDown("Fire1"))
            {
                algorithm.forthSequence += 1;
            }
        }

    }
}
