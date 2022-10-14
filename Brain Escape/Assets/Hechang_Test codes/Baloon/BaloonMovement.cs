using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] Transform balloonMovePoint1;
    [SerializeField] Transform balloonMovePoint2;
    [SerializeField] Transform balloonMovePoint3;

    int target = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == 0)
        {
            transform.position = (Vector3.MoveTowards(transform.position, balloonMovePoint1.position, 0.5f * Time.deltaTime));
            if (Vector3.Distance(transform.position, balloonMovePoint1.position) < 0.5)
            {
                target = 1;
            }
        }
        else if (target == 1)
        {
            transform.position = (Vector3.MoveTowards(transform.position, balloonMovePoint2.position, 0.5f * Time.deltaTime));
            if (Vector3.Distance(transform.position, balloonMovePoint2.position) < 0.5)
            {
                target = 2;
            }
        }
        else if (target == 2)
        {
            transform.position = (Vector3.MoveTowards(transform.position, balloonMovePoint3.position, 0.5f * Time.deltaTime));
            if (Vector3.Distance(transform.position, balloonMovePoint3.position) < 0.5)
            {
                target = 0;
            }
        }
    
    }
}
