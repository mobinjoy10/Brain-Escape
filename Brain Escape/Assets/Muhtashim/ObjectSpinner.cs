using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpinner : MonoBehaviour
{
    [SerializeField][Range(1,85)]float RotateSpeed = 3f;
	[SerializeField][Range(0,1)] int rotateX = 0;
	[SerializeField][Range(0,1)] int rotateY = 1;
	[SerializeField][Range(0,1)] int rotateZ = 0;

    void Update()
    {
        Vector3 RotateVector = new Vector3(rotateX, rotateY, rotateZ);
		transform.Rotate(RotateVector * RotateSpeed);
    }
}
