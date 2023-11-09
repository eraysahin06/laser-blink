using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    public float movementSpeed;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(movementSpeed, 0, 0);
    }
}
