using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class MenuButtons : MonoBehaviour
{
    public Button PlayBTN;
    public GameObject ControlsPainel;
    public GameObject CreditsPainel;


    public void PlayBTNAction()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OpenCtrlPainel()
    {
        if(ControlsPainel != null) { 
            ControlsPainel.SetActive(true);
        }
    }
    public void OpenCreditsPainel()
    {
        if (CreditsPainel != null)
        {
            CreditsPainel.SetActive(true);
        }
    }
    public void LoadMenuFromCredits()
    {
        CreditsPainel.SetActive(false);
    }
    public void LoadMenuFromCtrls()
    {
        ControlsPainel.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
