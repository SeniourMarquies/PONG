


using UnityEngine;
using Random = UnityEngine.Random;


public class Ball : MonoBehaviour
{
     private Rigidbody2D _rigidbody;
    private float speed = 200f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
        
        
    }

    public void AddStartingForce()
    {
        
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1f : 1f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
            : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}
