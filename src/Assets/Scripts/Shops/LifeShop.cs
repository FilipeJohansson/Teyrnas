using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeShop : ShopBehaviour {

    private void Start() {
        LoadLifeShop();

        priceText.text = ((int)price).ToString();

    }

    void Update() {
        priceText.text = ((int)price).ToString();
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.CompareTag("Player")) {

            BuyLife(col.GetComponent<PlayerController>(), price, upIncrement, priceIncrement);
            SaveLifeShop();

        }

    }

    public void SaveLifeShop() {

        SaveSystem.SaveLifeShop(this);

    }

    public void LoadLifeShop() {

        ShopData data = SaveSystem.LoadLifeShop();

        price = (int)data.price;
        upIncrement = data.upIncrement;
        priceIncrement = data.priceIncrement;

    }

}
