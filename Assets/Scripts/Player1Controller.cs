using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour
{
    public float speed;
    public Rigidbody rigid;
    public GameObject bombP;
    public int bombRes = 2;

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

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && bombRes > 0){    
            StartCoroutine(PlaceBomb());
        }
    }

    private IEnumerator PlaceBomb(){
        GameObject bomb = Instantiate(bombP,this.transform.position,bombP.transform.rotation);
        bombRes--;
        yield return new WaitForSeconds(2f);
        Destroy(bomb);
        bombRes++;
    }

}