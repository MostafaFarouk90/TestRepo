using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSize : MonoBehaviour
{
    Slider fontSlider;

    private void Start()
    {
        fontSlider = GetComponent<Slider>();
    }

    public void ChangeFontSize()
    {
        UIManager.Instance.ChangeMyFontSize((int)fontSlider.value);
    }
}
