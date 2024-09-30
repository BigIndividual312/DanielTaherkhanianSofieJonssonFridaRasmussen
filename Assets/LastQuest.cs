using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastQuest : MonoBehaviour
{

    [SerializeField] private int questGoal = 1;
    [SerializeField] private int levelToLoad;


    private bool levelIsLoading = false;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<PlayerMovement>().applesCollected >= questGoal)
            {

                Invoke("LoadNextLevel", 2.5f);
                levelIsLoading = true;
            }
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

}