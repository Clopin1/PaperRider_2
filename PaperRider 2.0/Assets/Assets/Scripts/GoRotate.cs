using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRotate : MonoBehaviour
{
    //Essa rotação á para o estilete que rode e fique andando
    public float speed = 5;
    private float leftEdge;
    public Rigidbody2D rb2D;
    [SerializeField] private Vector3 rotation;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
        transform.Rotate(rotation * Time.deltaTime);
        //rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
