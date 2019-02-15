using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private float speed = 1f,tilt = 30f;
    private Vector3 target = new Vector3(0,3f,0);
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y !=1.5f)
            target.y = 1.5f;
        else if (transform.position == target && target.y == 1.5f)
            target.y = 3f;
        transform.Rotate(Vector3.up * Time.deltaTime*tilt);
    }
}
    