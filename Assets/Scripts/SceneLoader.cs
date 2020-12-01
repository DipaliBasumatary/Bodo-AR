using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public Animator SelectionBackButton;
    public float transitionTime = 1f;
    public float buttonAnimation = 1f;
    //AR scene change
    public void start()
    {
        StartCoroutine(secondScene());
        Debug.Log("Loaded Vowel Scene!");
    }

    public void backButtonSelection()
    {
        StartCoroutine(prevScene());
        Debug.Log("Loaded Main Menu!");
    }

    public void startVowels()
    {
        StartCoroutine(vowelsScene());
        Debug.Log("Loaded Vowels Menu!");
    }

    public void backAR()
    {
        StartCoroutine(secondScene());
        Debug.Log("Loaded Second Scene!");
    }

    IEnumerator secondScene()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("selection_menu");
    }

    IEnumerator prevScene()
    {
        SelectionBackButton.SetTrigger("Start");
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("main_menu");
    }

    IEnumerator vowelsScene()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("vowels");
    }
}
