using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnClick : MonoBehaviour
{
    public AudioClip pronounceClip;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.enabled = false;
    }

    public void Initialize()
    {
        source.enabled = true;
    }

    public void pronounceOnAppear()
    {
        source.clip = pronounceClip;
        source.Play();
    }
}
