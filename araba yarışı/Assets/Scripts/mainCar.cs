using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float dikey_hýz,yatay_hýz,varsayýlan_hýz;
    private float dikey_hareket,yatay_hareket;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //klavyede hareket için
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(yatay_hareket * 50 * yatay_hýz * Time.deltaTime, varsayýlan_hýz+dikey_hareket*50*dikey_hýz*Time.deltaTime);
        
        if(transform.position.x>2.9f)
        {
            Vector3 right_limit = new Vector3(2.9f, transform.position.y);
            transform.position = right_limit; 
        } //SAÐ SINIR

        if (transform.position.x < -3.3f)
        {
            Vector3 left_limit = new Vector3(-3.3f, transform.position.y);
            transform.position = left_limit;
        } //SOL SINIR
    }
}
