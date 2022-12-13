using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggScript : MonoBehaviour
{
    public Score scoreText;

    public void OnTriggerEnter ()
    {
        scoreText.scoreText.fontSize = 40;
        scoreText.scoreText.color = Color.red;
        scoreText.scoreText.text = "UNLIMITTEDD POWWWERRR!!!\n YOU FOUND THE EASTEREGG!";
        scoreText.enabled = false;

    }



}
