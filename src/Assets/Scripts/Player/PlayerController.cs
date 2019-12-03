using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    /*Movement variables*/
    public float speed;
    public float jumpForce;
    private float moveInput;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    /*Attack variables*/
    private float timeToAttack;
    public float startTimeToAttack;
    public float damage;
    public float attackRange;

    public Transform attackPos;
    public LayerMask whatIsEnemy;

    /*Others variables*/
    public float health;
    public int coins;
    public static bool isAlive;

    private Rigidbody2D rb;

    public GameObject bloodParticle;

    private Animator anim;

    void Awake() {
        //Pega o rigidbody do player
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        isAlive = true;

    }

    void FixedUpdate() {

        /*Movement*////////////////////////////////////////////

        if (isAlive) {

            //Cria um círculo em uma posição x para verificar se o jogador está no chão
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

            //Pega o valor da movimentação horizontal e aplica ao velocity do rigidbody
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        }

        if(moveInput == 0 && isAlive) {

            anim.SetBool("isRunning", false);

        } else {

            anim.SetBool("isRunning", true);

        }
        
        //Verifica o lado que o player está olhando para fazer o Flip
        if (facingRight == false && moveInput > 0 && isAlive) {

            Flip();

        } else if (facingRight == true && moveInput < 0 && isAlive) {

            Flip();

        }

        /*Attack*////////////////////////////////////////////
        if(timeToAttack <= 0 && isAlive) {

            if (Input.GetKey(KeyCode.Mouse0)) {

                anim.SetBool("isAttacking", true);

                Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy);
                
                for (int i = 0; i < enemies.Length; i++) {

                    if(enemies[i].CompareTag("Enemy")) {
                        enemies[i].GetComponent<EnemiesBehaviour>().TakeDamage((int)damage);
                    }

                }

                timeToAttack = startTimeToAttack;

            }

        } else {

            anim.SetBool("isAttacking", false);

            timeToAttack -= Time.deltaTime;

        }

        /*Others*////////////////////////////////////////////

        if ((int)health <= 0) {

            isAlive = false;
            anim.SetBool("isDying", true);

        }

    }

    void Update() {
        //Verifica se o espaço foi pressionado e aplica força para o pulo
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && isAlive) {

            rb.velocity = Vector2.up * jumpForce;

        }

    }

    public void TakeDamage(int damage) {

        health -= (int)damage;
        Instantiate(bloodParticle, transform.position, Quaternion.identity);

    }

    void Flip() {

        facingRight = !facingRight;

        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }

    private void OnDrawGizmosSelected() {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
        
    }

    public void SavePlayer() {

        SaveSystem.SavePlayer(this);

    }

    public void LoadPlayer() {

        PlayerData data = SaveSystem.LoadPlayer();

        speed = data.speed;
        startTimeToAttack = data.startTimeToAttack;
        damage = data.damage;
        health = data.health;

    }

    public void SaveCoins() {

        SaveSystem.SaveCoins(this);

    }

    public void LoadCoins() {

        CoinData data = SaveSystem.LoadCoins();

        coins = (int)data.coins;

    }

}
