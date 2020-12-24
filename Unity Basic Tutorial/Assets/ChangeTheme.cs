using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTheme : MonoBehaviour
{
    Image image;
    [SerializeField] Sprite[] themeSprites;
    [SerializeField] Color[] themeColors;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        UIManager.themeChanged += ChangeMyTheme;
    }

    private void ChangeMyTheme(int themeIndex)
    {
        image.sprite = themeSprites[themeIndex];
        image.color = themeColors[themeIndex];
    }
}
