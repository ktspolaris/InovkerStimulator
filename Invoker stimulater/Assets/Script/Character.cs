using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour


{
    public float speed;
    public float rotateSpeed;
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



        if (GameObject.Find("GamePlay").GetComponent<ChangeColor>().numofFire == 3 && GameObject.Find("GamePlay").GetComponent<ChangeColor>().invoked)
        {
            Instantiate(fireBall, shotSpawn.transform.position, shotSpawn.transform.rotation);
        }
        if (GameObject.Find("GamePlay").GetComponent<ChangeColor>().numofWater == 3 && GameObject.Find("GamePlay").GetComponent<ChangeColor>().invoked)
        {
            Instantiate(wave, shotSpawn.transform.position, shotSpawn.transform.rotation);
        }

        if (GameObject.Find("GamePlay").GetComponent<ChangeColor>().numofFire == 1 && GameObject.Find("GamePlay").GetComponent<ChangeColor>().invoked&&
            GameObject.Find("GamePlay").GetComponent<ChangeColor>().numofWind == 2)
        {
            Instantiate(flash, shotSpawn.transform.position, shotSpawn.transform.rotation);
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
    }
}
