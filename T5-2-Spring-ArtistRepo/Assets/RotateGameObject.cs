using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public float rotateSpeed;
    public Vector3 rotate;

    void Update()
    {
        this.transform.Rotate(rotate * rotateSpeed);
    }
}
