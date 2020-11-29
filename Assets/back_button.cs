using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("main_menu");
    }
}
