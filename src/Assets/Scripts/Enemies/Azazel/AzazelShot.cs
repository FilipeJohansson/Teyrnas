using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzazelShot : ShotBehaviour {

    //private Vector2 target;

    public float timeToDestroy;

    void Start() {


        //target = new Vector2(transform.position.x, player.position.y);

        InvokeRepeating("DestroyProjectile", timeToDestroy, timeToDestroy);

    }

    void Update() {

        if(PauseMenu.gameIsPaused || !PlayerController.isAlive) {

            transform.Translate(Vector3.down * 0);

        } else {

            transform.Translate(Vector3.down * speed);

        }

        
        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

}
