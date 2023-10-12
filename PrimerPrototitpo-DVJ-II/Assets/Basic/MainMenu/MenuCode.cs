using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuCode : MonoBehaviour
{
    UIDocument mainMenu;
    [SerializeField]
    GameObject UiMenu, UiSettings, UiLevels;
    public UIDocument settings;
    Button btn_play;
    Button btn_settings;
    Button btn_levels;
    private void OnEnable()
    {        
        mainMenu = GetComponent<UIDocument>();
        VisualElement root = mainMenu.rootVisualElement;
        btn_play = root.Q<Button>("play");
        btn_play.RegisterCallback<ClickEvent,int>(SceneChange,1);
        btn_settings = root.Q<Button>("settings");
        btn_settings.RegisterCallback<ClickEvent>(UiChangeSettings);
        btn_levels = root.Q<Button>("level");
        btn_levels.RegisterCallback<ClickEvent>(UiChangeLevels);
    }

    private void UiChangeLevels(ClickEvent evt)
    {
        UiMenu.SetActive(false);
        UiLevels.SetActive(true);
    }

    private void UiChangeSettings(ClickEvent evt)
    {
        UiMenu.SetActive(false);
        UiSettings.SetActive(true);
    }

    private void SceneChange(ClickEvent evt,int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
