using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HagnesShot : ShotBehaviour {

    //private Vector2 target;
    private bool goToRight = true;

    public float timeToDestroy;

    void Start() {
  
        //target = new Vector2(player.position.x, transform.position.y);

        InvokeRepeating("DestroyProjectile", timeToDestroy, timeToDestroy);

    }

    void Update() {

        Vector3 corretDirection;
        if(goToRight) {
            
            corretDirection = Vector3.right;

        } else {

            corretDirection = Vector3.left;

        }

        if(PauseMenu.gameIsPaused || !PlayerController.isAlive) {

            transform.Translate(Vector3.right * 0);

        } else {

            transform.Translate(Vector3.right * speed);

        }

        
        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
    }

    public void SetDirection(bool right) {

        goToRight = right;

        if(!right) {

            Vector3 newDirection = transform.localScale;
            newDirection.x *= -1;
            transform.localScale = newDirection;

        }

    }

}
