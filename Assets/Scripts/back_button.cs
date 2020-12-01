using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    AudioSource mySource;
    void Start()
    {
        mySource = GetComponent <AudioSource>();
    }
    public void playClick()
    {
        mySource.Play();
    }
}
