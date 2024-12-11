using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    public float x, y, z;
    float speed = 20f;
    float rotSpeed = 80f;

    // Update is called once per frame
    void Update()
    {
        float forw = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        float Side = Input.GetAxisRaw("Horizontal") * rotSpeed * Time.deltaTime;
        //gameObject.transform.position += new Vector3(Side, y, forw);
        gameObject.transform.Translate(0, 0, forw);
        transform.Rotate(0, Side, 0);
    }
}