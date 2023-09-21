using UnityEngine;

public class GoLine : MonoBehaviour
{
    //Esse spaw nas reguas, e igual aos dos canos do Flappy Bird
    public float speed = 5;
    private float leftEdge;
    public Rigidbody2D rb2D;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
        //rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
