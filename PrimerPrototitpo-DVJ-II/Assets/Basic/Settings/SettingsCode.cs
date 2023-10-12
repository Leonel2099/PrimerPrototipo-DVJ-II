using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsCode : MonoBehaviour
{
    UIDocument settings;
    [SerializeField]
    GameObject UiMenu, UiSettings;
    Button btn_back;
    private void OnEnable()
    {
        settings = GetComponent<UIDocument>();
        VisualElement root = settings.rootVisualElement;
        btn_back = root.Q<Button>("btn-Back");
        btn_back.RegisterCallback<ClickEvent>(UiChangeMainMenu);
    }

    private void UiChangeMainMenu(ClickEvent evt)
    {
        UiMenu.SetActive(true);
        UiSettings.SetActive(false);
    }
}
