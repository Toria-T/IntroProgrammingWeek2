using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{
    public int moveSpeed = 5; //controls player speed
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>(); //This function gets the rigidbody component from the asset it is attached to. The carrots are very important. Without them the whole code breaks
    }

 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rigidbody);
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigidbody.velocity.y, Input.GetAxis("Vertical") * moveSpeed); //controls the rigidbody. This already assumes the player is using WASD or the arrow keys
    }
}
