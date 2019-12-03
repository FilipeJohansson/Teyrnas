using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenShop : MonoBehaviour {

    public GameObject damageCabinet;
    public GameObject lifeCabinet;

    private Animator damageAnim;
    private Animator lifeAnim;

    public GameObject damagePriceText;
    public GameObject lifePriceText;

    public bool isOpened = false;

    // Start is called before the first frame update
    void Awake() {
        damageAnim = damageCabinet.GetComponent<Animator>();
        lifeAnim = lifeCabinet.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.CompareTag("Player")) {

            damageAnim.SetBool("opened", true);
            lifeAnim.SetBool("opened", true);

            StartCoroutine(TimerRoutine());

            isOpened = true;

        }

    }

    private void OnTriggerExit2D(Collider2D col) {

        if (col.CompareTag("Player")) {

            damageAnim.SetBool("opened", false);
            lifeAnim.SetBool("opened", false);

            damagePriceText.SetActive(false);
            lifePriceText.SetActive(false);

            isOpened = false;

        }

    }

    IEnumerator TimerRoutine() {

        yield return new WaitForSeconds(1.1f);

        damagePriceText.SetActive(true);
        lifePriceText.SetActive(true);

    }

}
