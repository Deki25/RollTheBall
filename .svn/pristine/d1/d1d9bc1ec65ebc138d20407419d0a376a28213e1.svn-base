using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopMenager : MonoBehaviour
{

    public GameObject ShopPanel;
    public GameObject ShopButton;

    public GameObject Player;

    public Text coinsText;

    public Material[] playerMaterial;
    public Sprite[] playerTexture;


    private void Awake()
    {
        //ChangePlayerSkin(GameManager.Instance.skinIndex);
        coinsText.text = "Coins: " + GameManager.Instance.coins.ToString();
        int textureIndex = 0;

        playerMaterial = Resources.LoadAll<Material>("Skin Material");
        playerTexture = Resources.LoadAll<Sprite>("PlayerTexture");

        foreach (Sprite texture in playerTexture)
        {
            GameObject container = Instantiate(ShopButton, ShopPanel.transform) as GameObject;
            container.GetComponent<Image>().sprite = texture;

            int index = textureIndex;

            container.GetComponent<Button>().onClick.AddListener(() => ChangePlayerSkin(index));
            textureIndex++;
        }
    }

    public void ChangePlayerSkin(int index)
    {
        Player.GetComponent<MeshRenderer>().sharedMaterial = playerMaterial[index];
        GameManager.Instance.skinIndex = index;
        GameManager.Instance.Save();
        Debug.Log(Player.GetComponent<MeshRenderer>().sharedMaterial);
    }

    public void Back(string loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }
    
}
