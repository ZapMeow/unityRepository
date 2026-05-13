using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rg2d;
    [SerializeField] private SpriteRenderer sr;
    private float speed = 1;

    [SerializeField] private Vector2 vector;

    [SerializeField] private float horizontalInput = 0;
    [SerializeField] private float verticalInput = 0;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if (horizontalInput == 0 && verticalInput == 0)
        {
            return;
        }

        vector.x = horizontalInput * speed * Time.fixedDeltaTime;
        vector.y = verticalInput * speed * Time.fixedDeltaTime;
        rg2d.MovePosition(rg2d.position + vector);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Se ha detectado colisión con " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisión con " + other.gameObject.name);
    }
}
