using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void savePlayerData()
    {
        /*var player = gameObject.transform;
        string playerJson = JsonUtility.ToJson(player);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/player_info.json", playerJson);
        Debug.Log("data saved");*/
    }

    public void loadPlayerAsSaved()
    {
       /* Debug.Log("Try laoding data");

        string jsonString = System.IO.File.ReadAllText(Application.persistentDataPath + "/player_info.json");
        Transform saved_transform = JsonUtility.FromJson<Transform>(jsonString);

        gameObject.transform.position = saved_transform.position;*/
    }
}
