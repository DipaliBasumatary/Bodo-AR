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
    public float creditsScrollTime = 20f;
    //AR scene change
    public void start()
    {
        StartCoroutine(secondScene());
        Debug.Log("Loaded Selection Scene!");
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

    public void credits()
    {
        StartCoroutine(creditsMenu());
        Debug.Log("Started the Credit Scene!");
    }

    public void backCredits()
    {
        StartCoroutine(creditToMainMenu());
        Debug.Log("In the Homescreen!");
    }

    IEnumerator creditToMainMenu()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("main_menu");
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

    IEnumerator creditsMenu()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("credits");
    }

}
