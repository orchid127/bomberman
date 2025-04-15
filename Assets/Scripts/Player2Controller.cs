using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.O)){
            this.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.L)){
            this.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.K)){
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.M)){
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
