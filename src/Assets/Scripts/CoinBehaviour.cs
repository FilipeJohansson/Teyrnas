using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {

    private PlayerController player;

    private Rigidbody2D rb;

    // Use this for initialization
    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {

            player.coins += 1;
            player.SaveCoins();
            Destroy(gameObject);

        }

        if (collision.CompareTag("Floor")) {
            Destroy(rb);
        }

    }

}
