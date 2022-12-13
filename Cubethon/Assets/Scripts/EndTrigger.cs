using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        Debug.Log("Enterd TiggerEnter");
        gameManager.CompleteLevel();

        FindObjectOfType<Score>().enabled = false;
    }
}
