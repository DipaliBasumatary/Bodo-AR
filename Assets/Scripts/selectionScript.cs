using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionScript : MonoBehaviour
{
    public Animator vowelsCardAnimation;
    public Animator vowelsQuizAnimation;
    AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }
    
    public void animateVowelsCard()
    {
        vowelsCardAnimation.SetTrigger("Start");
    }

    public void animateVowelsQuizCard()
    {
        vowelsQuizAnimation.SetTrigger("Start");
    }

    public void playClick()
    {
        buttonSound.Play();
    }

    
}
