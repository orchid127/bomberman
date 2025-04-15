using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public GameObject bulletPreFab;
    public GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * speed * Time.deltaTime;
            print(this.transform.position);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * speed * Time.deltaTime;
            print(this.transform.position);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            print(this.transform.position);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            print(this.transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPreFab, this.transform.position, bulletPreFab.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            gameOverScreen.SetActive(true);
        }
    }
}
