using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vowelManager : MonoBehaviour
{
    public float buttonAnimation;
    public GameObject O_1;
    public GameObject O_2;
    public GameObject O_3;
    public GameObject O_4;
    public GameObject O_5;
    public GameObject O_6;
    public GameObject O_7;
    public GameObject O_8;
    public GameObject O_9;
    public GameObject O_10;
    public GameObject O_11;


    public void Object1()
    {
        StartCoroutine(enable1());
    }

    public void Object2()
    {
        StartCoroutine(enable2());
    }

    public void Object3()
    {
        StartCoroutine(enable3());
    }

    public void Object4()
    {
        StartCoroutine(enable4());
    }

    public void Object5()
    {
        StartCoroutine(enable5());
    }

    public void Object6()
    {
        StartCoroutine(enable6());
    }

    public void Object7()
    {
        StartCoroutine(enable7());
    }

    public void Object8()
    {
        StartCoroutine(enable8());
    }

    public void Object9()
    {
        StartCoroutine(enable9());
    }

    public void Object10()
    {
        StartCoroutine(enable10());
    }

    public void Object11()
    {
        StartCoroutine(enable11());
    }

    IEnumerator enable1()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(true);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable2()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(true);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable3()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(true);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable4()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(true);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable5()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(true);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable6()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(true);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable7()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(true);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable8()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(true);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable9()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(true);
        O_10.SetActive(false);
        O_11.SetActive(false);
    }

    IEnumerator enable10()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(true);
        O_11.SetActive(false);
    }

    IEnumerator enable11()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(false);
        O_3.SetActive(false);
        O_4.SetActive(false);
        O_5.SetActive(false);
        O_6.SetActive(false);
        O_7.SetActive(false);
        O_8.SetActive(false);
        O_9.SetActive(false);
        O_10.SetActive(false);
        O_11.SetActive(true);
    }
}
