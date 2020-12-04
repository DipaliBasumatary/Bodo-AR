using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class main_menu : MonoBehaviour
{
    public float buttonAnimation = 1f;
    public float optionTime = 1f;
    public Animator secondaryMenu;
    public Animator tertiaryMenu;
    public AudioMixer audioMixer;
   
    GameObject Learn;
    GameObject Exit;
    GameObject Options;
    GameObject Information;
    GameObject OptionsMenu;
    GameObject InfoMenu;
    GameObject CreditsMenu;

    //For Audio Initialization
    AudioSource mySource;
    void Start()
    {
        mySource = GetComponent<AudioSource>();
        Learn = GameObject.Find("Learn");
        Exit = GameObject.Find("Exit");
        Options = GameObject.Find("Options");
        Information = GameObject.Find("Info");
        OptionsMenu = GameObject.Find("Options_Menu");
        InfoMenu = GameObject.Find("Info_Menu");
        
        OptionsMenu.SetActive(false);
        InfoMenu.SetActive(false);
        
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

    //Audio Playback
    public void playClick()
    {
        mySource.Play();
    }

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void option()
    {
        StartCoroutine(enableOptionsMenu());

    }

    public void info()
    {
        StartCoroutine(enableInfoMenu());
    }

    public void back1()
    {
        StartCoroutine(disableInfoMenu());
    }

    public void back()
    {
        StartCoroutine(disableOptionsMenu());
    }

    

    IEnumerator enableOptionsMenu()
    {
        yield return new WaitForSeconds(buttonAnimation);
        //transition.SetTrigger("Start");
        //yield return new WaitForSeconds(transitionTime);

        Learn.SetActive(false);
        Exit.SetActive(false);
        Options.SetActive(false);
        Information.SetActive(false);
        OptionsMenu.SetActive(true);
        secondaryMenu.SetTrigger("opt");
    }
    IEnumerator enableInfoMenu()
    {
        yield return new WaitForSeconds(buttonAnimation);
        //transition.SetTrigger("Start");
        //yield return new WaitForSeconds(transitionTime);

        Learn.SetActive(false);
        Exit.SetActive(false);
        Options.SetActive(false);
        Information.SetActive(false);
        InfoMenu.SetActive(true);
        tertiaryMenu.SetTrigger("info");
    }

    




    IEnumerator disableOptionsMenu()
    {
        secondaryMenu.SetTrigger("back");
        yield return new WaitForSeconds(buttonAnimation);
        //transition.SetTrigger("Start");
        //yield return new WaitForSeconds(transitionTime);

        Learn.SetActive(true);
        Exit.SetActive(true);
        Options.SetActive(true);
        Information.SetActive(true);
        OptionsMenu.SetActive(false);
        
    }

    IEnumerator disableInfoMenu()
    {
        tertiaryMenu.SetTrigger("back");
        yield return new WaitForSeconds(buttonAnimation);
        //transition.SetTrigger("Start");
        //yield return new WaitForSeconds(transitionTime);

        Learn.SetActive(true);
        Exit.SetActive(true);
        Options.SetActive(true);
        Information.SetActive(true);
        InfoMenu.SetActive(false);
    }



}
