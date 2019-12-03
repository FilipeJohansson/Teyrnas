using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageShop : ShopBehaviour {

    private void Start() {
        LoadDamageShop();

        priceText.text = ((int)price).ToString();

    }

    void Update() {
        priceText.text = ((int)price).ToString();
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.CompareTag("Player")) {

            BuyDamage(col.GetComponent<PlayerController>(), price, upIncrement, priceIncrement);
            SaveDamageShop();

        }

    }

    public void SaveDamageShop() {

        SaveSystem.SaveDamageShop(this);

    }

    public void LoadDamageShop() {

        ShopData data = SaveSystem.LoadDamageShop();

        price = (int)data.price;
        upIncrement = data.upIncrement;
        priceIncrement = data.priceIncrement;

    }

}
