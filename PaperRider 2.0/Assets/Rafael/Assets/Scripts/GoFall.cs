using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoFall : MonoBehaviour
{
    //Essa velocidade e para o transferidor, que vai de cima para baixo
    public float speed;
    private float downEdge;
    public Rigidbody2D rb2D;

    private void Start()
    {
        System.Random rand = new System.Random();
        speed = rand.Next(10, 20);
        downEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < downEdge)
        {
            Destroy(gameObject);
        }
    }
}
