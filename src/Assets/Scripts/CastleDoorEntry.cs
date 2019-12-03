using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleDoorEntry : MonoBehaviour {

    public string sceneName;
    public PlayerController player;
    public GameController gameController;
    public LifeShop lifeShop;
    public DamageShop damageShop;
    
    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {
            Scene scene = SceneManager.GetActiveScene();

            if(scene.name == "Castle") {
                player.SavePlayer();
                player.SaveCoins();
                lifeShop.SaveLifeShop();
                damageShop.SaveDamageShop();

            }

            if (scene.name == "Principal") {
                gameController.changeLevel();
                gameController.SaveLevel();

            }

            Application.LoadLevel(sceneName);

        }

    }

}
