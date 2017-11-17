using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; }}

    public int coins = 0;
    public int skinIndex = 0;
    public int skinAvailability = 1;
    public int useJoystick = 0;

	private void Awake () 
	{
        //instance = this;
        //DontDestroyOnLoad(gameObject);

        DontDestroyOnLoad(this);

        if (instance == null)
             instance = this;
        else
            DestroyObject(gameObject);
        

        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
            skinIndex = PlayerPrefs.GetInt("SkinIndex");
            skinAvailability = PlayerPrefs.GetInt("SkinAvailability");
            useJoystick = PlayerPrefs.GetInt("UseJoystick");
            PlayerPrefs.DeleteAll();

        }
        else
            Save();
	}

    public void Save()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("SkinIndex", skinIndex);
        PlayerPrefs.SetInt("SkinAvailability", skinAvailability);
        PlayerPrefs.SetInt("UseJoystick", useJoystick);
    }
	
	void Update () 
	{
        
	}
}
