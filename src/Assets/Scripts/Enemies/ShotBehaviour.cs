using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehaviour : MonoBehaviour {

    public float speed;
    public int damage;

    public PlayerController player;

    void Awake() {

        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {

            player.TakeDamage(damage);
            DestroyProjectile();

        }

        if (collision.CompareTag("Floor")) {

            Destroy(gameObject);

        }

    }

    void DestroyProjectile() {

        Destroy(gameObject);

    }

}
