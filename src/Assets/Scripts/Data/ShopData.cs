using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopData {

    public float price;
    public float upIncrement;
    public float priceIncrement;

    public ShopData (ShopBehaviour shop) {

        price = shop.price;
        upIncrement = shop.upIncrement;
        priceIncrement = shop.priceIncrement;

    }

}
