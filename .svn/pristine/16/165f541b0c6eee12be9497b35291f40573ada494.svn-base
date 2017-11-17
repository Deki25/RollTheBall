using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMenager : MonoBehaviour 
{
    public static int money = 0;

    [Range(0, 360)]
    public float rotationSpeed;

    private void OnTriggerEnter(Collider coli)
    {
        if (coli.tag == "Player")
        {
            if (gameObject.tag == "Coin_1")
            {
                gameObject.SetActive(false);
                money++;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_2")
            {
                gameObject.SetActive(false);
                money += 2;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_5")
            {
                gameObject.SetActive(false);
                money += 5;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_10")
            {
                gameObject.SetActive(false);
                money +=10;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_25")
            {
                gameObject.SetActive(false);
                money +=25;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_50")
            {
                gameObject.SetActive(false);
                money += 50;
                Debug.Log(money);
            }
            else if (gameObject.tag == "Coin_100")
            {
                gameObject.SetActive(false);
                money += 100;
                Debug.Log(money);
            }
        }
    }

    private void Update()
    {
        transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
    }
}
