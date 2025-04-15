using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float speed;
    public Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.linearVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W)){
            rigid.linearVelocity = (Vector3.forward * speed);
        }

        if(Input.GetKey(KeyCode.S)){
            rigid.linearVelocity = (Vector3.back * speed);
        }

        if(Input.GetKey(KeyCode.A)){
            rigid.linearVelocity = (Vector3.left * speed);
        }

        if(Input.GetKey(KeyCode.D)){
            rigid.linearVelocity = (Vector3.right * speed);
        }
    }
}
