using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMainMenuButton : MonoBehaviour
{
    public void onClickGoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
