using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {
    
    public static void SavePlayer(PlayerController player) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadPlayer() {

        string path = Application.persistentDataPath + "/player.save";

        if(File.Exists(path)) {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        } else {

            //Debug.Log("Save file not found in " + path);
            return null;

        }

    }

    public static void SaveCoins(PlayerController player) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/coins.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        CoinData data = new CoinData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static CoinData LoadCoins() {

        string path = Application.persistentDataPath + "/coins.save";

        if(File.Exists(path)) {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            CoinData data = formatter.Deserialize(stream) as CoinData;
            stream.Close();

            return data;

        } else {

            //Debug.Log("Save file not found in " + path);
            return null;

        }

    }

    public static void SaveLevel(GameController gameController) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/level.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        //Debug.Log(Application.persistentDataPath);

        LevelData data = new LevelData(gameController);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static LevelData LoadLevel() {

        string path = Application.persistentDataPath + "/level.save";

        if(File.Exists(path)) {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelData data = formatter.Deserialize(stream) as LevelData;
            stream.Close();

            return data;

        } else {

            //Debug.Log("Save file not found in " + path);
            return null;

        }

    }

    public static void SaveDamageShop(ShopBehaviour shop) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/damageShop.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        //Debug.Log(Application.persistentDataPath);

        ShopData data = new ShopData(shop);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static ShopData LoadDamageShop() {

        string path = Application.persistentDataPath + "/damageShop.save";

        if(File.Exists(path)) {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShopData data = formatter.Deserialize(stream) as ShopData;
            stream.Close();

            return data;

        } else {

            //Debug.Log("Save file not found in " + path);
            return null;

        }

    }

    public static void SaveLifeShop(ShopBehaviour shop) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/lifeShop.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        //Debug.Log(Application.persistentDataPath);

        ShopData data = new ShopData(shop);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static ShopData LoadLifeShop() {

        string path = Application.persistentDataPath + "/lifeShop.save";

        if(File.Exists(path)) {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShopData data = formatter.Deserialize(stream) as ShopData;
            stream.Close();

            return data;

        } else {

            //Debug.Log("Save file not found in " + path);
            return null;

        }

    }

}