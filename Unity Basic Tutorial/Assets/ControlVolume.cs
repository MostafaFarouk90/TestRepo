using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolume : MonoBehaviour
{
    [SerializeField] Slider musicVolumeSlider, sfxVolumeSlider;

    [SerializeField] AudioSource musicAS, sfxAS;

    public void ChangeMusicVolume()
    {
        musicAS.volume = musicVolumeSlider.value;
        UIManager.Instance.musicVolumeTxt.text = Mathf.FloorToInt(musicAS.volume*100).ToString();
    }

    public void ChangeSFXVolume()
    {
        sfxAS.volume = sfxVolumeSlider.value;
        UIManager.Instance.sfxVolumeTxt.text = Mathf.FloorToInt(sfxAS.volume * 100).ToString();
    }
}
