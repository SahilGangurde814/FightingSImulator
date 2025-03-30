using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Animator swordAnimator;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();

        if(Input.GetMouseButtonDown(0))
        {
            swordAnimator.SetBool("isAttacking", true);
        }
        else
        {
            swordAnimator.SetBool("isAttacking", false);
        }
    }

    void Movement()
    {
        Vector3 playerPos = transform.position;
        Vector3 PlayerForward = transform.forward;
        Vector3 playerRight = transform.right;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = playerPos + PlayerForward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = playerPos + -PlayerForward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = playerPos + playerRight * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = playerPos + -playerRight * speed * Time.deltaTime;
        }
    }
}
