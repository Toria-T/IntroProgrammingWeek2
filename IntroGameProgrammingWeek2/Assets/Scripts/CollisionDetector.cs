using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public float hitCounter; //keeps track of collision events
    public float winState; //activates game over event

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        hitCounter += 1; //updates total times interacted
        print("I've been hit " + hitCounter + " times."); //prints the total number of interactions

        if(hitCounter == 4)
        {
            fORCEeRROR;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
