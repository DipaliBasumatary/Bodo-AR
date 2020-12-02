using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    AudioSource mySource;
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }
    public void playClick()
    {
        mySource.Play();
    }
}
