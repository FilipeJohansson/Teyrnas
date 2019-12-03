using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    /*Movement variables*/
    public float speed;

    /*Attack variables*/
    public float startTimeToAttack;
    public float damage;

    /*Others variables*/
    public float health;

    public PlayerData (PlayerController player) {

        speed = player.speed;
        startTimeToAttack = player.startTimeToAttack;
        damage = player.damage;
        health = player.health;

    }

}
