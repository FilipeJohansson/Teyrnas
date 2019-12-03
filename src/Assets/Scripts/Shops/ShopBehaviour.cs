using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopBehaviour : MonoBehaviour {

    public float price;
    public float upIncrement;
    public float priceIncrement;
    public TextMeshProUGUI priceText;

    public void BuyLife(PlayerController player, float price, float upIncrement, float priceIncrement) {

        if (player.coins >= price) {

            player.health *= upIncrement;

            player.coins -= (int)price;
            this.price *= priceIncrement;

        } else {

            Debug.Log("Você não tem dinheiro");

        }

    }

    public void BuyDamage(PlayerController player, float price, float upIncrement, float priceIncrement) {

        if (player.coins >= price) {

            player.damage *= upIncrement;

            player.coins -= (int)price;
            this.price *= priceIncrement;

        } else {

            Debug.Log("Você não tem dinheiro");

        }

    }

}
