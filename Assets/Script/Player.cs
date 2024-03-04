using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float HorizantalInput;
    float VerticalInput;
    public float speed = 1.0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizantalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(HorizantalInput*speed*Time.deltaTime,0,VerticalInput*speed*Time.deltaTime);
    }
}
