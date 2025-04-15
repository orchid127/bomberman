using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationCOntreoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);

        if((Physics.Raycast(ray, out hit, 100f, 1<<3)))
        {
            print("Ray hit at : " + hit.point);
            RotateToward(hit.point);
        }
    }

    void RotateToward(Vector3 pos)
    {
        pos = new Vector3(pos.x, this.transform.position.y, pos.z);
        this.transform.LookAt(pos);
    }
}
