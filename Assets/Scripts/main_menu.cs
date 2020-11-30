using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    //For Audio Initialization
    AudioSource mySource;
    void Start()
    {
        mySource = GetComponent<AudioSource>(); 
    }

    //Exit-Quit Button
    public void exitButton()
    {
        StartCoroutine(actionAfterQuit());
        Debug.Log("Exit Done!");
    }

    IEnumerator actionAfterQuit()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }

    //AR scene change
    public void startAR()
    {
        StartCoroutine(actionAfterAR());
        Debug.Log("Loaded Vowel Scene!");
    }

    IEnumerator actionAfterAR()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("vowels");
    }

    //Audio Playback
    public void playClick()
    {
        mySource.Play();
    }

    
}
