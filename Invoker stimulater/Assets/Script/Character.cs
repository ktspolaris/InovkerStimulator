using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour

   
{
    public float speed;
    public float rotateSpeed;
    public Transform bullet;
    public GameObject shotSpawn;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          this.transform.Rotate(new Vector3(0,0,1) * rotateSpeed * Time.deltaTime);
            animator.SetBool("Iswalk", true);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
           this.transform.Rotate(new Vector3(0,0,1) * -rotateSpeed * Time.deltaTime);
            animator.SetBool("Iswalk", true);


        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector2(0,1) * speed * Time.deltaTime);
            animator.SetBool("Iswalk", true);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector2(0, 1) * -speed * Time.deltaTime);
            animator.SetBool("Iswalk", true);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            animator.SetBool("Iswalk", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Iswalk", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Iswalk", false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Iswalk", false);
        }
       


        if (Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
            animator.SetBool("Isattack", true);
        
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Isattack", false);
        }


    }
}
