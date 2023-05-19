using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static string path;
     public static void SaveMoney (SaveManager _saveManager)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        path = Application.persistentDataPath + "/SaveData.txt";
        FileStream stream = new FileStream(path, FileMode.Create);
        Debug.Log(path);

        PlayerData data = new PlayerData(_saveManager);
        Debug.Log(data.level + "\n" + data.time + "\n" + data.conpletion + "\n" + data.planetValue + "\n" + data.playerChoice);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadMoney()
    {
        //Debug.Log(Application.persistentDataPath);
        path = Application.persistentDataPath + "/SaveData.txt";
        if (File.Exists(path))
        {
            //Debug.Log("Path: " + path);
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found! Path: " + path);

            return null;
        }
    }
}
