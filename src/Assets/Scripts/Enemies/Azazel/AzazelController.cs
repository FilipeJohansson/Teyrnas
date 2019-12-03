using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzazelController : EnemiesBehaviour {

    private float startSpawnY;

    public float playerCheckX;
    public float playerCheckY;

    // Start is called before the first frame update
    void Start() {

        startSpawnY = transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate() {

        transform.position = Vector2.MoveTowards(transform.position, new Vector3(player.position.x, startSpawnY, 0), speed * Time.deltaTime);

        if (timeToShot <= 0) {

            if(CheckPlayerInRadius(playerCheckX, playerCheckY)) {

                Attack();

            }

        } else {

            timeToShot -= Time.deltaTime;

        }

    }

    private void OnDrawGizmosSelected() {

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPos.transform.position, new Vector3(playerCheckX, playerCheckY, 0));

    }

}
