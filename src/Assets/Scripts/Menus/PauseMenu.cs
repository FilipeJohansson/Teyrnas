﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update() {

        if(Input.GetKeyDown(KeyCode.Escape)) {

            if(gameIsPaused) {

                Resume();

            } else {

                Pause();

            }

        }
        
    }

    public void Resume() {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;

    }

    void Pause() {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;

    }

    public void Menu() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame() {

        Application.Quit();

    }

}
