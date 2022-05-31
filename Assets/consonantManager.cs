using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consonantManager : MonoBehaviour
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
    public GameObject O_12;
    public GameObject O_13;
    public GameObject O_14;
    public GameObject O_15;
    public GameObject O_16;
    public GameObject O_17;
    public GameObject O_18;
    public GameObject O_19;
    public GameObject O_20;
    public GameObject O_21;
    public GameObject O_22;
    public GameObject O_23;
    public GameObject O_24;
    public GameObject O_25;
    public GameObject O_26;
    public GameObject O_27;
    public GameObject O_28;
    public GameObject O_29;
    public GameObject O_30;
    public GameObject O_31;
    public GameObject O_32;
    public GameObject O_33;
    public GameObject O_34;
    public GameObject O_35; 
    public GameObject O_36;
    public GameObject O_37;
    public GameObject O_38;
    public GameObject O_39;
    public GameObject O_40;

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
    public void Object12()
    {
        StartCoroutine(enable12());
    }

    public void Object13()
    {
        StartCoroutine(enable13());
    }

    public void Object14()
    {
        StartCoroutine(enable14());
    }

    public void Object15()
    {
        StartCoroutine(enable15());
    }

    public void Object16()
    {
        StartCoroutine(enable16());
    }

    public void Object17()
    {
        StartCoroutine(enable17());
    }

    public void Object18()
    {
        StartCoroutine(enable18());
    }

    public void Object19()
    {
        StartCoroutine(enable19());
    }

    public void Object20()
    {
        StartCoroutine(enable20());
    }

    public void Object21()
    {
        StartCoroutine(enable21());
    }

    public void Object22()
    {
        StartCoroutine(enable22());
    }
    public void Object23()
    {
        StartCoroutine(enable23());
    }

    public void Object24()
    {
        StartCoroutine(enable24());
    }

    public void Object25()
    {
        StartCoroutine(enable25());
    }

    public void Object26()
    {
        StartCoroutine(enable26());
    }

    public void Object27()
    {
        StartCoroutine(enable27());
    }

    public void Object28()
    {
        StartCoroutine(enable28());
    }

    public void Object29()
    {
        StartCoroutine(enable29());
    }

    public void Object30()
    {
        StartCoroutine(enable30());
    }

    public void Object31()
    {
        StartCoroutine(enable31());
    }

    public void Object32()
    {
        StartCoroutine(enable32());
    }

    public void Object33()
    {
        StartCoroutine(enable33());
    }

    public void Object34()
    {
        StartCoroutine(enable34());
    }

    public void Object35()
    {
        StartCoroutine(enable35());

    }
    public void Object36()
    {
        StartCoroutine(enable36());
    }

    public void Object37()
    {
        StartCoroutine(enable37());
    }

    public void Object38()
    {
        StartCoroutine(enable38());
    }

    public void Object39()
    {
        StartCoroutine(enable39());
    }
    public void Object40()
    {
        StartCoroutine(enable40());
    }

    IEnumerator enable1()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(true);
        O_2.SetActive(false);
    }

    IEnumerator enable2()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_1.SetActive(false);
        O_2.SetActive(true);
        O_3.SetActive(false);
    }

    IEnumerator enable3()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_2.SetActive(false);
        O_3.SetActive(true);
        O_4.SetActive(false);
    }

    IEnumerator enable4()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_3.SetActive(false);
        O_4.SetActive(true);
        O_5.SetActive(false);
    }

    IEnumerator enable5()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_4.SetActive(false);
        O_5.SetActive(true);
        O_6.SetActive(false);
    }

    IEnumerator enable6()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_5.SetActive(false);
        O_6.SetActive(true);
        O_7.SetActive(false);
    }

    IEnumerator enable7()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_6.SetActive(false);
        O_7.SetActive(true);
        O_8.SetActive(false);
    }

    IEnumerator enable8()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_7.SetActive(false);
        O_8.SetActive(true);
        O_9.SetActive(false);
    }

    IEnumerator enable9()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_8.SetActive(false);
        O_9.SetActive(true);
        O_10.SetActive(false);
    }

    IEnumerator enable10()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_9.SetActive(false);
        O_10.SetActive(true);
        O_11.SetActive(false);
    }

    IEnumerator enable11()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_10.SetActive(false);
        O_11.SetActive(true);
        O_12.SetActive(false);
    }

    IEnumerator enable12()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_11.SetActive(false);
        O_12.SetActive(true);
        O_13.SetActive(false);
    }

    IEnumerator enable13()
    {
       yield return new WaitForSeconds(buttonAnimation);
        O_12.SetActive(false);
        O_13.SetActive(true);
        O_14.SetActive(false);
    }

    IEnumerator enable14()
    {
     yield return new WaitForSeconds(buttonAnimation);
        O_13.SetActive(false);
        O_14.SetActive(true);
        O_15.SetActive(false);
    }

    IEnumerator enable15()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_14.SetActive(false);
        O_15.SetActive(true);
        O_16.SetActive(false);
    }

    IEnumerator enable16()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_15.SetActive(false);
        O_16.SetActive(true);
        O_17.SetActive(false);
    }

    IEnumerator enable17()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_16.SetActive(false);
        O_17.SetActive(true);
        O_18.SetActive(false);
    }

    IEnumerator enable18()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_17.SetActive(false);
        O_18.SetActive(true);
        O_19.SetActive(false);
    }

    IEnumerator enable19()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_18.SetActive(false);
        O_19.SetActive(true);
        O_20.SetActive(false);
    }

    IEnumerator enable20()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_19.SetActive(false);
        O_20.SetActive(true);
        O_21.SetActive(false);
    }

    IEnumerator enable21()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_20.SetActive(false);
        O_21.SetActive(true);
        O_22.SetActive(false);
    }

    IEnumerator enable22()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_21.SetActive(false);
        O_22.SetActive(true);
        O_23.SetActive(false);
    }

    IEnumerator enable23()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_22.SetActive(false);
        O_23.SetActive(true);
        O_24.SetActive(false);
    }

    IEnumerator enable24()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_23.SetActive(false);
        O_24.SetActive(true);
        O_25.SetActive(false);
    }

    IEnumerator enable25()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_24.SetActive(false);
        O_25.SetActive(true);
        O_26.SetActive(false);
    }

    IEnumerator enable26()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_25.SetActive(false);
        O_26.SetActive(true);
        O_27.SetActive(false);
    }

    IEnumerator enable27()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_26.SetActive(false);
        O_27.SetActive(true);
        O_28.SetActive(false);
    }

    IEnumerator enable28()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_27.SetActive(false);
        O_28.SetActive(true);
        O_29.SetActive(false);
    }

    IEnumerator enable29()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_28.SetActive(false);
        O_29.SetActive(true);
        O_30.SetActive(false);
    }

    IEnumerator enable30()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_29.SetActive(false);
        O_30.SetActive(true);
        O_31.SetActive(false);
    }

    IEnumerator enable31()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_30.SetActive(false);
        O_31.SetActive(true);
        O_32.SetActive(false);
    }

    IEnumerator enable32()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_31.SetActive(false);
        O_32.SetActive(true);
        O_33.SetActive(false);
    }
    IEnumerator enable33()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_32.SetActive(false);
        O_33.SetActive(true);
        O_34.SetActive(false);
    }

    IEnumerator enable34()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_33.SetActive(false);
        O_34.SetActive(true);
        O_35.SetActive(false);
    }
    IEnumerator enable35()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_34.SetActive(false);
        O_35.SetActive(true);
        O_36.SetActive(false);
    }

    IEnumerator enable36()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_35.SetActive(false);
        O_36.SetActive(true);
        O_37.SetActive(false);
    }

    IEnumerator enable37()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_36.SetActive(false);
        O_37.SetActive(true);
        O_38.SetActive(false);
    }

    IEnumerator enable38()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_37.SetActive(false);
        O_38.SetActive(true);
        O_39.SetActive(false);
    }

    IEnumerator enable39()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_38.SetActive(false);
        O_39.SetActive(true);
        O_40.SetActive(false);
    }
    IEnumerator enable40()
    {
        yield return new WaitForSeconds(buttonAnimation);
        O_39.SetActive(false);
        O_40.SetActive(true);
    }
}

