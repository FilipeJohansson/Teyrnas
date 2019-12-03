using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int level;
    public PlayerController player;

    void Awake() {
        
        level = 1;

        LoadLevel(); 

        player.LoadPlayer();
        player.LoadCoins();

    }

    public void changeLevel() {

        this.level += 1;
        SaveLevel();

    }

    public void SaveLevel() {

        SaveSystem.SaveLevel(this);

    }

    public void LoadLevel() {

        LevelData data = SaveSystem.LoadLevel();

        level = data.level;

    }

}
