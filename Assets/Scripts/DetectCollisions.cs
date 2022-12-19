using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
   
    //When it hits the object
    private void OnTriggerEnter(Collider other)
    {//Game object gets destroyed
        Destroy(gameObject);
 
    }

}   
