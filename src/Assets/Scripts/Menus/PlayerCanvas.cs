using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvas : MonoBehaviour {

    public Slider healthBar;
    public Text coins;

    public PlayerController player;

    // Start is called before the first frame update
    void Start() {

        healthBar.maxValue = (int)player.health;
        healthBar.value = (int)player.health;
        coins.text = player.coins.ToString();

    }

    void FixedUpdate() {

        healthBar.value = (int)player.health;
        coins.text = player.coins.ToString();

    }

}
