using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSizeText : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        UIManager.fontSizeChanged += ChangeFontSize;
    }

    private void ChangeFontSize(int fontSize)
    {
        text.fontSize = fontSize;
    }

}
