using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestCheckerFinal : MonoBehaviour
{
    [SerializeField] private GameObject crab1, crab2, crab3, crab4, particle;
    [SerializeField] private int questGoal = 0;
    // [SerializeField] private int levelToLoad;

    // private Animator anim;
    // private bool levelIsLoading = false;

    //  private void Start()
    //  {
    //      anim = GetComponent<Animator>();
    //  }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<PlayerMovement>().applesCollected >= questGoal)
                // {
           //     dialogueBox.SetActive(true);
            crab1.SetActive(true);
            crab2.SetActive(true);
            crab3.SetActive(true);
            crab4.SetActive(true);
            particle.SetActive(true);
            /* anim.SetTrigger("Flag");
             Invoke("LoadNextLevel", 3.0f);
              levelIsLoading = true;
          }
          else
          {
              dialogueBox.SetActive(true);
              unfinishedText.SetActive(true);
          }*/
        }
    }
}

  //  private void LoadNextLevel()
  //  {
 //       SceneManager.LoadScene(levelToLoad);
  //  }
  /*
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !levelIsLoading)
        {
            dialogueBox.SetActive(false);
            finishedText.SetActive(false);
            unfinishedText.SetActive(false);
        }
    }
}*/
