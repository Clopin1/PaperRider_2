using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    [SerializeField] private Rigidbody2D rb2D;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        rb2D.velocity = new Vector2(0,vertical * speed);
    }
}
