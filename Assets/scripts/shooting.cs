using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform cannon;
    public GameObject shot;

    public float shotPower = 20f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
    }

    //function for making bullet
    void shoot()
    { 
        //makes cannonball
        GameObject cannonball = Instantiate(shot,cannon.position, cannon.rotation);
        //gives cannonball rigid body
        Rigidbody2D rb = cannonball.GetComponent<Rigidbody2D>();
        //adds force in up direction
        rb.AddForce(cannon.up * shotPower, ForceMode2D.Impulse);
    }


}

