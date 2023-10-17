using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffSpeed : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(PowerUpCollet(collision.gameObject));
        }
    }

    private IEnumerator PowerUpCollet(GameObject player)
    {

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        player.transform.localScale /= 1.5f;


        yield return new WaitForSeconds(5.0f);

        player.transform.localScale *= 1.5f;

        Destroy(gameObject);
    }

}