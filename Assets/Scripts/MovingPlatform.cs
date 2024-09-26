using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform target1, target2;
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private SpriteRenderer ratSpriteRenderer;

    private Transform currentTarget;
    private SpriteRenderer rend;
    private bool canMove = true;


    // Start is called before the first frame update
    void Start()
    {
        currentTarget = target1;

 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position == target1.position)
        {
            currentTarget = target2;
            FlipRatSprite(false);
        }

        if (transform.position == target2.position)
        {
            currentTarget = target1;
            FlipRatSprite(true);
        }

        transform.position = Vector2.MoveTowards(transform.position, currentTarget.position, moveSpeed * Time.deltaTime);
    }

    private void FlipRatSprite(bool facingLeft)
    {
        if(facingLeft)
        {
            ratSpriteRenderer.flipX = false;
        }
        else
        {
            ratSpriteRenderer.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && other.transform.position.y > transform.position.y)
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
