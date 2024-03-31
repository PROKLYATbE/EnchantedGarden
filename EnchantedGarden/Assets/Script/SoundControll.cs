using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundControll : MonoBehaviour
{
    public GameObject BGMusic;  //объект с фоновой музыкой
    private AudioSource audioSrc;
    public static float musicVolume;
    public Slider VolValue; //Слайдер
    public GameObject[] objs1;

    void Awake()
    {
        objs1 = GameObject.FindGameObjectsWithTag("Sound");
        if (objs1.Length == 0)
        {
            BGMusic = Instantiate(BGMusic);
            BGMusic.name = "BGMusic";
            DontDestroyOnLoad(BGMusic.gameObject);
        }
        else
        {
            BGMusic = GameObject.Find("BGMusic");
        }
        if (!PlayerPrefs.HasKey("MusicVol"))
        {
            musicVolume = 0.1f;
        }
        else
        {
            musicVolume = PlayerPrefs.GetFloat("MusicVol");
            VolValue.value = PlayerPrefs.GetFloat("MusicVol");
        }
    }
    void Start()
    {
        audioSrc = BGMusic.GetComponent<AudioSource>();
    }


    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("MusicVol", vol);
    }
}