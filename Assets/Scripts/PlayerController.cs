using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float cooldown = 0;
    private float speed = 5.0f;
    public float xRange = 10.0f;
    private float turnSpeed = 25.0f;
    private float forwardInput;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //This where we get playeer Input  from
       
        forwardInput = Input.GetAxis("Vertical");
        //move the vechile foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We turn the vechile
        transform.Rotate(Vector3.up, Time.deltaTime* turnSpeed * horizontalInput);

        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        if (cooldown >= 0) {
            cooldown -= Time.deltaTime;
        }


        

    }
}
