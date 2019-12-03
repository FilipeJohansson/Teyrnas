using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBehaviour : MonoBehaviour {

    public int health;
    public float startSpeed;
    protected float speed;

    protected float dazedTime;
    public float startDazedTime;

    protected float timeToShot;
    public float startTimeToShot;

    private bool playerIsInRadius;
    public LayerMask whatIsPlayer;
    public Transform player;

    public GameObject projectile;
    public GameObject attackPos;
    public GameObject coin;
    public GameObject bloodParticle;

    public PlayerController playerController;

    private bool facingRight = true;

    void Awake() {

        timeToShot = startTimeToShot;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    void Update() {

        if (player.position.x < transform.position.x && facingRight) {

            Flip();

        } else if (player.position.x > transform.position.x && !facingRight) {

            Flip();

        }

        if (health <= 0) {

            DropCoin();
            Destroy(gameObject);

        }

        if(dazedTime <= 0) {

            speed = startSpeed;

        } else {

            speed = 0;
            dazedTime -= Time.deltaTime;

        }
        
    }

    public void TakeDamage(int damage) {

        dazedTime = startDazedTime;

        health -= damage;

        Instantiate(bloodParticle, transform.position, Quaternion.identity);

    }

    protected bool CheckPlayerInRadius(float x, float y) {

        playerIsInRadius = Physics2D.OverlapBox(attackPos.transform.position, new Vector2(x, y), 0, whatIsPlayer);

        if(playerIsInRadius) {
            return true;
        } else {
            return false;
        }


    }

    protected void Attack() {

        Instantiate(projectile, transform.position, transform.rotation);
        timeToShot = startTimeToShot;

    }

    void Flip() {

        facingRight = !facingRight;

        transform.Rotate(new Vector3(0, 180, 0));

    }

    void DropCoin() {
    
        Instantiate(coin, transform.position, transform.rotation);

    }
    
}
