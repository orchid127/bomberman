using UnityEngine;

public class EnnemyController2 : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
