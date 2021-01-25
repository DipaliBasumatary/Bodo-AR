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
        Debug.Log("Loaded Vowels Scene!");
    }

    public void startNumbers()
    {
        StartCoroutine(numbersScene());
        Debug.Log("Loaded Numbers Scene!");
    }

    public void startVowelsQuiz()
    {
        StartCoroutine(vowelsQuizScene());
        Debug.Log("Loaded Vowels Quiz Scene!");
    }

    public void startNumbersQuiz()
    {
        StartCoroutine(numbersQuizScene());
        Debug.Log("Loaded Numbers Quiz Scene!");
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

    IEnumerator numbersScene()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("numbers_1");
    }

    IEnumerator vowelsQuizScene()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("vowel_Quiz");
    }

    IEnumerator numbersQuizScene()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("numbers_1_quiz");
    }

    IEnumerator creditsMenu()
    {
        yield return new WaitForSeconds(buttonAnimation);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("credits");
    }

}
