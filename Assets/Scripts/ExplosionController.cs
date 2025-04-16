using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Player"){
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}