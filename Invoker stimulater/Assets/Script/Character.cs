using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour


{
    public float speed;
    public float rotateSpeed;
    public float ReturnForce;
    public GameObject gamePlay;
    public Transform fireBall;
    public Transform flash;
    public Transform wave;
    public GameObject shotSpawn;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        animator = this.GetComponent<Animator>();

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, 1) * rotateSpeed * Time.deltaTime);
            animator.SetBool("Iswalk", true);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, 1) * -rotateSpeed * Time.deltaTime);
            animator.SetBool("Iswalk", true);


        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
            animator.SetBool("Iswalk", true);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector2(0, 1) * -speed * Time.deltaTime);
            animator.SetBool("Iswalk", true);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
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
    }
    void Attack()
    {
        switch (GameObject.Find("GamePlay").GetComponent<ChangeColor>().skillNumber)
        {
            case 1:
                Instantiate(fireBall, shotSpawn.transform.position, shotSpawn.transform.rotation);
                break;
            case 2:
                Instantiate(wave, shotSpawn.transform.position, shotSpawn.transform.rotation);
                break;
            case 9:
                Instantiate(flash, shotSpawn.transform.position, shotSpawn.transform.rotation);
                break;
        }
        animator.SetBool("Isattack", true);

    }
    // Update is called once per frame
    void Update()
    {

        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Attack();


        }
       if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Isattack", false);
        }

        if (Input.GetKeyDown(KeyCode.Z)) {
            this.GetComponent<Hp>().TakeDamage();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")// May add a specific "ARM" collider to test
        {
            this.GetComponent<Hp>().TakeDamage();
            //Debug.Log("touch");
        }

        this.transform.Translate(new Vector2(0, 1) * -ReturnForce * Time.deltaTime);
        
    }
}
