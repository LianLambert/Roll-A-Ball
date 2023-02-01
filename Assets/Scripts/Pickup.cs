using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float heightMagnitude = 1;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.position = new Vector3(pos.x, Mathf.Abs(Mathf.Sin(Time.time * heightMagnitude)), pos.z) * heightMagnitude;
    }
}
    