using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour

   
{
    public float speed;
    public float rotateSpeed;
    public Transform bullet;
    public GameObject shotSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          this.transform.Rotate(new Vector3(0,0,1) * rotateSpeed * Time.deltaTime);
           
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
           this.transform.Rotate(new Vector3(0,0,1) * -rotateSpeed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(transform.up * -speed * Time.deltaTime);
        }


        if (Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
          
        
        }


    }
}
