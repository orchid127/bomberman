using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        LoadGame();
    }

    private void OnApplicationQuit()
    {
        SaveGame();
        print("Game quit");
    }

    void SaveGame()
    {
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerZ", player.transform.position.z);
    }

    void LoadGame()
    {
        player.transform.position = 
        new Vector3(PlayerPrefs.GetFloat("PlayerX"), player.transform.position.y, PlayerPrefs.GetFloat("PlayerZ"));

    }
}