using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    //This script is no longer used for the player character, I'm keeping this more really as a reference material
    public int moveSpeed = 5; //controls player speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) //if the player hits the D key, the object moves right
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }
        if(Input.GetKey(KeyCode.A)) //if the player hits the A key, the object moves left
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if(Input.GetKey(KeyCode.W)) //if the player hits the W key, the object moves forward
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if(Input.GetKey(KeyCode.S)) //if the player hits the S key, the object moves backwards
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }
    }
}
