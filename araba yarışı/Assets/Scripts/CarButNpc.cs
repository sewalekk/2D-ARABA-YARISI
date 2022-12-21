using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButNpc : MonoBehaviour
{
    private float varsay�lan_h�z;
    private int gidilen_serit;
    public int car_sprite;
    public Sprite car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12, car13, car14, car15, car16, car17, car18;
    
    Rigidbody2D rb;
    SpriteRenderer spr;

    void Start()
    {
        spr= GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
       
        gidilen_serit = Random.Range(1, 5);
        varsay�lan_h�z = Random.Range(2.9f,3.3f);
        car_sprite = Random.Range(1, 19);

        if(gidilen_serit==1)
        {
            transform.position = new Vector3(-3.26f, transform.position.y + 10, 0);
        } //random �erit atama
        else if (gidilen_serit == 2)
        {
            transform.position = new Vector3(-1.28f, transform.position.y + 10, 0);
        } //random �erit atama
        else if (gidilen_serit == 3)
        {
            transform.position = new Vector3(0.73f, transform.position.y + 10, 0);
        } //random �erit atama
        else 
        {
            transform.position = new Vector3(2.67f, transform.position.y + 10, 0);
        } //random �erit atama

        switch(car_sprite)
        {
            case 1:
                spr.sprite = car1;
                break;

            case 2: 
                spr.sprite = car2;
                break;

            case 3: 
                spr.sprite = car3;
                break;

            case 4:
                spr.sprite = car4;
                break;

            case 5:
                spr.sprite = car5;
                break;

            case 6:
                spr.sprite = car6;
                break;

            case 7:
                spr.sprite = car7;
                break;

            case 8:
                spr.sprite = car8;
                break;

            case 9:
                spr.sprite = car9;
                break;

            case 10:
                spr.sprite = car10;
                break;

            case 11:
                spr.sprite = car11;
                break;

            case 12:
                spr.sprite = car12;
                break;

            case 13:
                spr.sprite = car13;
                break;

            case 14:
                spr.sprite = car14;
                break;

            case 15:
                spr.sprite = car15;
                break;

            case 16:
                spr.sprite = car16;
                break;

            case 17:
                spr.sprite = car17;
                break;

            case 18:
                spr.sprite = car18;
                break;

        }//arac�n sprite kontrol�

    }

    void fixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x,varsay�lan_h�z*50*Time.deltaTime,0);
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="mainCar")
        {
            SceneManager.LoadScene(2);
        }
    }
}
