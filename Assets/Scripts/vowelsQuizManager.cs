using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vowelsQuizManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    AudioSource mySource;
    public AudioClip correctTune;
    public AudioClip wrongTune;
    public vowelsQuestions[] vowels;
    private static List<vowelsQuestions> unansweredVowels;
    private static int counter = 1;
    private int vowelscore = 0;

    [SerializeField]
    private Text vowelText;

    [SerializeField]
    private Text firstButtonText;

    [SerializeField]
    private Text secondButtonText;

    [SerializeField]
    private Text firstAnswerText;

    [SerializeField]
    private Text secondAnswerText;

    [SerializeField]
    private Text gameOverText;

    [SerializeField]
    private Text gameOverScore;

    [SerializeField]
    private Text score;

    [SerializeField]
    private float vowelDelay = 1f;

    [SerializeField]
    private Animator answerAnimator;

    private vowelsQuestions currentVowel;

    void Start()
    {
        mySource = GetComponent<AudioSource>();
        unansweredVowels = vowels.ToList<vowelsQuestions>();
        SetCurrentQuestion();
        
    }

    public void playClick()
    {
        mySource.Play();
    }

    void SetCurrentQuestion()
    {
        

        int randomVowelIndex = Random.Range(0, unansweredVowels.Count);
        currentVowel = unansweredVowels[randomVowelIndex];

        currentVowel.questionObject.SetActive(true);
        vowelText.text = currentVowel.question;
        firstButtonText.text = currentVowel.buttonOne;
        secondButtonText.text = currentVowel.buttonTwo;

        if (currentVowel.isFirst)
        {
            firstAnswerText.text = "CORRECT";
            secondAnswerText.text = "WRONG";
        }
        else
        {
            firstAnswerText.text = "WRONG";
            secondAnswerText.text = "CORRECT";
        }
        
    }

    IEnumerator TransitionToNextVowel()
    {
        score.text = vowelscore.ToString() + " / 5";
        counter++;
        yield return new WaitForSeconds(vowelDelay);
        if (counter > 5)
        {
            counter = 1;
            gameOver();
        }
        else
        {
            answerAnimator.SetTrigger("normal");
            currentVowel.questionObject.SetActive(false);
            unansweredVowels.Remove(currentVowel);


            SetCurrentQuestion();
        }
        
    }

    public void UserSelectFirst()
    {
        answerAnimator.SetTrigger("first");
        if (currentVowel.isFirst)
        {
            Debug.Log("CORRECT!!");
            mySource.PlayOneShot(correctTune, 0.7f);
            vowelscore++;
        }
        else
        {
            Debug.Log("WRONG!!");
            mySource.PlayOneShot(wrongTune, 0.7f);
        }
        
        StartCoroutine(TransitionToNextVowel());
    }

    public void UserSelectSecond()
    {
        answerAnimator.SetTrigger("second");
        if (!currentVowel.isFirst)
        {
            Debug.Log("CORRECT!!");
            mySource.PlayOneShot(correctTune, 0.7f);
            vowelscore++;
        }
        else
        {
            Debug.Log("WRONG!!");
            mySource.PlayOneShot(wrongTune, 0.7f);
        }

        StartCoroutine(TransitionToNextVowel());
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverScore.text = vowelscore.ToString() + " / 5";
        if (vowelscore == 5)
        {
            gameOverText.text = "PERFECT!";
        }
        else if (vowelscore >= 3)
        {
            gameOverText.text = "GOOD";
        }
        else
        {
            gameOverText.text = "TRY AGAIN";
        }
    }

}
