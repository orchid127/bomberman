using UnityEngine;

public class BombExplose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
