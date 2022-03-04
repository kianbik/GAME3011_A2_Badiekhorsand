using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{

    public GameObject easyBoard;

    public GameObject mediumBoard;

    public GameObject hardBoard;
    public GameObject difficultyCanvas;
    public void OnEasyClicked()
    {
        easyBoard.SetActive(true);
        difficultyCanvas.SetActive(false);
    }

    public void OnMediumClicked()
    {
        mediumBoard.SetActive(true);
        difficultyCanvas.SetActive(false);
    }


    public void OnHardClicked()
    {
        hardBoard.SetActive(true);
        difficultyCanvas.SetActive(false);
    }

    public void OnResetClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

  
}
