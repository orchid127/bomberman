using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            print(this.transform.position);
            this.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            print(this.transform.position);
            this.transform.position -= Vector3.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            print(this.transform.position);
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            print(this.transform.position);
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}