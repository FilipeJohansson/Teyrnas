using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {

    public GameObject hagnes;
    public GameObject azazel;

    public GameObject hagnesSpawn;
    public GameObject azazelSpawn;

    public int timeToStartSpawn;
    public float timeToSpawn;
        
    private PlayerController player;
    public LevelController lvlController;

    void Start() {
    
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnEnemy", timeToStartSpawn, timeToSpawn);

    }

    void Update() {

        if (player.health <= 0f) {
            CancelInvoke();
        }
        
    }

    public void SpawnEnemy() {

        if (lvlController.maxQtyHagnes > lvlController.currentQtyHagnes) {

            Instantiate(hagnes, hagnesSpawn.transform.position, hagnesSpawn.transform.rotation);
            lvlController.currentQtyHagnes++;

        }

        if(lvlController.maxQtyAzazel > lvlController.currentQtyAzazel) {

            Instantiate(azazel, azazelSpawn.transform.position, azazelSpawn.transform.rotation);
            lvlController.currentQtyAzazel++;

        }

    }

}
