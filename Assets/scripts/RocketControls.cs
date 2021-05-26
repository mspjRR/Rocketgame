using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketControls : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float Thrust;
    [SerializeField]
    float Rotation;
    [SerializeField]
    private Text fuelmeter;
    private int fuelamount;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuelamount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        RocketThrust();
        Rocketrotation();
    }

    private void RocketThrust()
    {
        //fuelmeter.text = "Fuel:" + fuelamount.ToString() + "%";
        if (Input.GetKey(KeyCode.UpArrow) && fuelamount > 0)
        {
            rb.AddRelativeForce(Vector3.up * Thrust);

        }
        else
        {

        }
    }
    
    private void Rocketrotation()
    {
        rb.freezeRotation = true;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.forward * Rotation * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * Rotation * Time.deltaTime);
        }
        rb.freezeRotation = false;
    }
}

