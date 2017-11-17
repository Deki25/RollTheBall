using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuMenager : MonoBehaviour 
{
    public GameObject Phone;
    public GameObject Joystick;

    public void BackToMenu(string backTo)
    {
        SceneManager.LoadScene(backTo);
    }

    private void Update()
    {
        if (GameManager.Instance.useJoystick == 0)
        {
            Phone.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            Joystick.GetComponent<Toggle>().isOn = true;
        }
    }

    public void PhoneToggle()
    {
        GameManager.Instance.useJoystick = 0;
        GameManager.Instance.Save();
    }

    public void JoystickToggle()
    {
        GameManager.Instance.useJoystick = 1;
        GameManager.Instance.Save();
    }


}
