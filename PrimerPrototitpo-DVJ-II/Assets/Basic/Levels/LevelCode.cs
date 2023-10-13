using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelCode : MonoBehaviour
{
    UIDocument levels;
    [SerializeField]
    GameObject UiMenu, UiLevels;
    Button btn_lvl1, btn_lvl2, btn_lvl3,btn_lock1, btn_lock2, btn_lock3, btn_close, btn_back;
    VisualElement mainContainer;
    private void OnEnable()
    {
        levels = GetComponent<UIDocument>();
        VisualElement root = levels.rootVisualElement;
        btn_lvl1 = root.Q<Button>("level1");
        btn_lvl1.RegisterCallback<ClickEvent,int>(ChangeScene,1);
        btn_lvl2 = root.Q<Button>("level2");
        btn_lvl2.RegisterCallback<ClickEvent,int>(ChangeScene,2);
        btn_lvl3 = root.Q<Button>("lock4");
        btn_lvl3.RegisterCallback<ClickEvent>(ShowAlert);
        btn_lock1 = root.Q<Button>("lock1");
        btn_lock1.RegisterCallback<ClickEvent>(ShowAlert);
        btn_lock2 = root.Q<Button>("lock2");
        btn_lock2.RegisterCallback<ClickEvent>(ShowAlert);
        btn_lock3 = root.Q<Button>("lock3");
        btn_lock3.RegisterCallback<ClickEvent>(ShowAlert);
        btn_close = root.Q<Button>("close");
        btn_close.RegisterCallback<ClickEvent>(CloseAlert);
        btn_back = root.Q<Button>("btn-back");
        btn_back.RegisterCallback<ClickEvent>(UiChangeMenu);
        mainContainer = root.Q<VisualElement>("container");
    }

    private void UiChangeMenu(ClickEvent evt)
    {
        UiMenu.SetActive(true);
        UiLevels.SetActive(false);
    }

    private void CloseAlert(ClickEvent evt)
    {
        mainContainer.style.flexShrink = 0;
        mainContainer.RemoveFromClassList("alertTransition");
    }

    private void ChangeScene(ClickEvent evt,int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene(level);
                break;
            case 2:
                SceneManager.LoadScene(level);
                break;
        }
    }

    private void ShowAlert(ClickEvent evt)
    {
        mainContainer.style.flexShrink = 1;
        mainContainer.AddToClassList("alertTransition");
    }
}
