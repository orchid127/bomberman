using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject bombExplose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject,2f);
        Instantiate(bombExplose, this.transform.position, bombExplose.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
