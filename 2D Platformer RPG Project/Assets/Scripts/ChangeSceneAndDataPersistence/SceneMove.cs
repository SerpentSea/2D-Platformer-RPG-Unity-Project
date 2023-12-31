using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    [SerializeField] Animator transitionAnim;

    // Check the scene build index and move to that specific Scene
    public int sceneBuildIndex;

    // If collider is a player, moves game to another scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Entered");

        if (collision.tag == "Player")
        {
            print("Switching Scene to " + sceneBuildIndex);
            StartCoroutine(LoadLevel());
        }
    }
    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        transitionAnim.SetTrigger("Start");
    }
}
