using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour
{
    public float speed;
    public GameObject bombe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S)){
            this.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bombe, this.transform.position, bombe.transform.rotation);
        }
    }
}
