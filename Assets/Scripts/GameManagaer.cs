﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagaer : MonoBehaviour
{

    private bool gameHasEnded = false;

    public Rotator rotator;

    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
           
            if (gameHasEnded==true)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("end game");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
