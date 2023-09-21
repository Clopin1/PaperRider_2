using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManagement : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject GameOverPainel;
  
    private void Awake()
    {
        isGameOver = false;
    }
    private void Update()
    {
        if (isGameOver)
        {
            GameOverPainel.SetActive(true);
        }
    }  
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void LoadMenu()
    {
        GameOverPainel.SetActive(false);
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }
}
