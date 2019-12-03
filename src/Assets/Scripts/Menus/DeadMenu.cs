using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour {

    public GameObject deadMenuUI;

    // Update is called once per frame
    void Update() {

        if(!PlayerController.isAlive) {

            StartCoroutine(TimerRoutine());

        }
        
    }

    void DeadUI() {

        deadMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Castle() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Castle");

    }

    IEnumerator TimerRoutine() {

        yield return new WaitForSeconds(1f);
        DeadUI();

    }

}
