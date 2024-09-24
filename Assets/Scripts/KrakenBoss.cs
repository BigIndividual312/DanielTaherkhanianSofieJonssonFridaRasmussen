using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrakenBoss : MonoBehaviour
{
    public Transform player;
  //  public float dirX;
    //private Rigidbody2D rgbd;
  //  private bool facingRight = false;
   // private Vector3 localScale;
  //  private float moveSpeed;

    public bool isFlipped = false;

    //private void Start()
    //{
        //localScale = transform.localScale;
      //  rgbd = GetComponent<Rigidbody2D>();
      //  dirX = 1f;
      //  moveSpeed = 1f;
    //}
 /*   private void FixedUpdate()
    {
        rgbd.velocity = new Vector2(dirX * moveSpeed, rgbd.velocity.y);
    }
    public void LateUpdate()
    {*/
        
    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
}
