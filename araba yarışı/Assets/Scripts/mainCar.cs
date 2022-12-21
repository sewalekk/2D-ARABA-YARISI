using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float dikey_h�z,yatay_h�z,varsay�lan_h�z;
    private float dikey_hareket,yatay_hareket;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //klavyede hareket i�in
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatay_hareket * 50 * yatay_h�z * Time.deltaTime, varsay�lan_h�z+dikey_hareket*50*dikey_h�z*Time.deltaTime);
        
        if(transform.position.x>2.9f)
        {
            Vector3 right_limit = new Vector3(2.9f, transform.position.y);
            transform.position = right_limit; 
        } //SA� SINIR

        if (transform.position.x < -3.3f)
        {
            Vector3 left_limit = new Vector3(-3.3f, transform.position.y);
            transform.position = left_limit;
        } //SOL SINIR
    }
}
