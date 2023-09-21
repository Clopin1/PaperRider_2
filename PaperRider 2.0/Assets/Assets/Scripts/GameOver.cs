using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            PlayerManagement.isGameOver = true;
            gameObject.SetActive(false);
            Time.timeScale = 0f;
            
        }
    }    
}
