using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicOnMenu : MonoBehaviour
{
    public AudioSource musicaMenu;

    void Start(){
        musicaMenu.clip = Resources.Load<AudioClip>("AvenidaBrasil");
        musicaMenu.Play();
        DontDestroyOnLoad(musicaMenu);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        if(scene.buildIndex == 1 && !musicaMenu.isPlaying){
            musicaMenu.Play();
        }
        if(scene.buildIndex == 2 || scene.buildIndex == 3){
            musicaMenu.Stop();
        }
    }
}
