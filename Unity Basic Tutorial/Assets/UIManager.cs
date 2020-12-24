using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public static Action<int> themeChanged;
    public static int themeIndexRef;

    public static Action<int> fontSizeChanged;
    public static int fontSizeRef;

    public Text fontSizeTxt, musicVolumeTxt, sfxVolumeTxt;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void ChangeMyTheme(int themeIndex)
    {
        if (themeIndexRef != themeIndex)
        {
            themeIndexRef = themeIndex;
            themeChanged?.Invoke(themeIndex);
        }
    }

    public void ChangeMyFontSize(int fontSize)
    {
        if (fontSizeRef != fontSize)
        {
            fontSizeRef = fontSize;
            fontSizeChanged?.Invoke(fontSize);
            fontSizeTxt.text = fontSize.ToString();
        }
    }
}
