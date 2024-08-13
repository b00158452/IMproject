using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{

    public int speed;
    public Transform pointA, pointB;
    private Vector3 currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pointA.position)
        {
            currentTarget = pointB.position;
        }
        else if (transform.position == pointA.position)
        {
            currentTarget = pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}
