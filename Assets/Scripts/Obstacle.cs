using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject box;

    private Animator anim;
    private bool hasPlayedAnimation = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !hasPlayedAnimation)
        {
            box.SetActive(false);
            hasPlayedAnimation = true;
            anim.SetTrigger("Move");
        }
    }
}
