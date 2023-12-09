using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private float volume = 0.5f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TextMeshProUGUI volumeText;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            volume = PlayerPrefs.GetFloat("Volume");
        }
        volumeSlider.value = volume;
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        volume = volumeSlider.value;
        volumeText.text = string.Format("{0:00}", volume * 100);
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
