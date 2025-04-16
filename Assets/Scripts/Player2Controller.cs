using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour
{
    public float speed;
    public Rigidbody rigid;
    public GameObject bomb;
    public int bombRes = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void FixedUpdate()
    {
        rigid.linearVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.O))
        {
            rigid.linearVelocity = (Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.L))
        {
            rigid.linearVelocity = (Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.K))
        {
            rigid.linearVelocity = (Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.Semicolon))
        {
            rigid.linearVelocity = (Vector3.right * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(bomb, this.transform.position, bomb.transform.rotation);
        }
    }

    private IEnumerator PlaceBomb()
    {
        Instantiate(bomb, this.transform.position, bomb.transform.rotation);
        bombRes--;
        yield return new WaitForSeconds(2f);
        bombRes++;
    }
}
