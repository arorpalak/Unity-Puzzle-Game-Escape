using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject settingMenu;

    public GameObject gameMenu;

    public Toggle onMuteToggle;

    public Slider soundslider;

    public Toggle onEasyModeToggle;

    public void OnMute(bool onMute)
    {
        print("Mute");
    }

    public void OnSoundChanged(float value)
    {
        print("Sound Changed ------->"+value);
    }

    public void OnEasySelected(bool isActive)
    {
        print("Easy ------>" + isActive);
    }

    public void OnNormalSelected(bool isActive)
    {
        print("Normal ------>" + isActive);
    }

    public void OnNightmareSelected(bool isActive)
    {
        print("Nightmare ------>" + isActive);
    }

    /// <summary>
    /// Click Setting Button Event;
    /// </summary>
    public void OnSettingButtonClick()
    {
        iTween.MoveTo(settingMenu, settingMenu.transform.position+new Vector3(3000, 0,0), 0.5f);

        iTween.MoveTo(gameMenu, gameMenu.transform.position+new Vector3(3000, 0,0), 0.5f);
    }

    /// <summary>
    /// Click Confirm Button Event;
    /// </summary>
    public void OnConfirmButtonClick()
    {
        iTween.MoveTo(settingMenu, settingMenu.transform.position + new Vector3(-3000, 0, 0), 0.5f);

        iTween.MoveTo(gameMenu, gameMenu.transform.position + new Vector3(-3000, 0, 0), 0.5f);

    }

    /// <summary>
    /// Click Reset Button Event;
    /// </summary>
    public void OnResetButtonClick()
    {
        //Reset;
        onMuteToggle.isOn = false;

        soundslider.value = 0.6f;

        onEasyModeToggle.isOn = true;


        ////Go back to game menu;
        //iTween.MoveTo(settingMenu, settingMenu.transform.position + new Vector3(-2500, 0, 0), 0.5f);

        //iTween.MoveTo(gameMenu, gameMenu.transform.position + new Vector3(-2500, 0, 0), 0.5f);

    }

    /// <summary>
    /// Click Exit Button Event;
    /// </summary>
    public void OnExitbuttonClick()
    {
        Application.Quit();
    }


    /// <summary>
    /// Click Start Button Event;
    /// </summary>
    public void OnStartButtonClick()
    {
        SceneManager.LoadSceneAsync("MainFloor");
    }
}
