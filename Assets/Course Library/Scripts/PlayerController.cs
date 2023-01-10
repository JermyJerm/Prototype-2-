using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalnput; 
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float zRange = 15;
    public float zzRange = 0;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalnput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalnput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.x); 
        }
        if (transform.position.z < zzRange)
        {
            transform.position = new Vector3(zzRange, transform.position.y, transform.position.x); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
