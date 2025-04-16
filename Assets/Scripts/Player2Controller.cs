using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour
{
    public float speed2;
    public Rigidbody rigid2;
    public GameObject bomb;
    public int bombRes2 = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void FixedUpdate()
    {
        rigid2.linearVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            rigid2.linearVelocity = Vector3.forward * speed2;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid2.linearVelocity = Vector3.back * speed2;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid2.linearVelocity = Vector3.left * speed2;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid2.linearVelocity = Vector3.right * speed2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bomb, this.transform.position, bomb.transform.rotation);
        }
    }

    private IEnumerator PlaceBomb()
    {
        Instantiate(bomb, this.transform.position, bomb.transform.rotation);
        bombRes2--;
        yield return new WaitForSeconds(2f);
        bombRes2++;
    }

}