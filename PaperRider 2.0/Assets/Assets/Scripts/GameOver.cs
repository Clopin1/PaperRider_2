using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int health;

    public void Start()
    {
        health = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LifePowerUp"))
        {
            health++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "Obstacle")
        {
            health--;

            if (health <= 0) 
            {
                PlayerManagement.isGameOver = true;
                gameObject.SetActive(false);
                Time.timeScale = 0f;
            }
        }
    }    
}
