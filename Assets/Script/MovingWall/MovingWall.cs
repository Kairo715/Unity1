using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    private float speed = 5.0f;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.z >= -19)
            flag = true;

        else if (transform.position.z <= -25)
            flag = false;

        if (flag)
            transform.position =
            Vector3.MoveTowards(transform.position, new Vector3(4, (float)1.5, -25), speed * Time.deltaTime);

        else if (!flag)
            transform.position =
            Vector3.MoveTowards(transform.position, new Vector3(4, (float)1.5, -19), speed * Time.deltaTime);
    }
}