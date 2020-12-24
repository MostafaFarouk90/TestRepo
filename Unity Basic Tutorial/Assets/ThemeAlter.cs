using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeAlter : MonoBehaviour
{
    Toggle toggle;
    Text text;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        text = GetComponentInChildren<Text>();
    }

    public void StatusChanged()
    {
        if (toggle.isOn)
            UIManager.Instance.ChangeMyTheme(0);
        else
            UIManager.Instance.ChangeMyTheme(1);
        text.text = toggle.isOn ? "Dark" : "Light";
    }
}
