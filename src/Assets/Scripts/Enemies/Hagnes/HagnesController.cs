using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HagnesController : EnemiesBehaviour {

    public float stoppingDistance;
    public float retreadDistance;

    public float playerCheckX;
    public float playerCheckY;
    
    // Update is called once per frame
    void FixedUpdate() {

        /*Movement*////////////////////////////////////////////

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance) {

            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreadDistance) {

            transform.position = this.transform.position;

        } else if (Vector2.Distance(transform.position, player.position) < retreadDistance) {

            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

        }

        /*Attack*////////////////////////////////////////////

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
