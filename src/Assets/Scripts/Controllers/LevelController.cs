using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

    public int maxQtyHagnes;
    public int maxQtyAzazel;

    public int currentQtyHagnes;
    public int currentQtyAzazel;

    private GameController gameController;
    private CastleDoorBehaviour castleDoor;
    public int qtyEnemiesOnMap;

    private bool x = false;

    public GameObject levelText;

    void Awake() {

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        castleDoor = GameObject.FindGameObjectWithTag("CastleDoor").GetComponent<CastleDoorBehaviour>();
        maxQtyHagnes = 0;
        maxQtyAzazel = 0;

    }

    void Start() {

        CalculateEnemiesQty(gameController.level);
        showLevel(gameController.level);

    }

    void Update() {
            
        if(qtyEnemiesOnMap == 0 && x) {
            castleDoor.openCastleDoor();
        }

    }

    public void CalculateEnemiesQty(int level) {
        
        /*if(level%5 == 0) {

            this.maxQtyHagnes = 0;
            this.maxQtyAzazel = 0;

        } else {*/

            this.maxQtyHagnes = (int)Mathf.Round(1 + 1.2f * Mathf.Pow(level, 1.2f));
            this.maxQtyAzazel = (int)Mathf.Round(0.2f + 0.24f * Mathf.Pow(level, 1.4f));

        //}

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Enemy")) {
            x = true;
            qtyEnemiesOnMap++;

        }

    }

    void OnTriggerExit2D(Collider2D collision) {

        if (collision.CompareTag("Enemy")) {
            qtyEnemiesOnMap--;

        }

    }

    void showLevel(int level) {

        levelText.SetActive(true);
        levelText.GetComponent<Text>().text = "Level " + level;
        StartCoroutine(TimerRoutine());

    }

    IEnumerator TimerRoutine() {

        yield return new WaitForSeconds(3f);
        levelText.SetActive(false);

    }

}
