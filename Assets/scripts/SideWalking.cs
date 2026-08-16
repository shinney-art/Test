using UnityEngine;

public class SideWalking : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed = 5;
    public float horizontal;
    public float walkspeed = 5f;
    public float runspeed = 12f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Speed = runspeed;
        }
        else
        {
            Speed = walkspeed;
        }
        
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2 (horizontal * Speed, rb.linearVelocity.y);
    }

}
