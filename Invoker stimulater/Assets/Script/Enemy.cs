using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Collider2D collsion;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "FireBall" ){
            animator.SetBool("IsBurned", true);
            Destroy(this.gameObject, 2);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Flash")
        {
            animator.SetBool("IsZapped", true);
        Destroy(collision.gameObject);
            Destroy(this.gameObject, 2);
        }

        if (collision.gameObject.tag == "Wave")
        {
            animator.SetBool("IsWetted", true);
        Destroy(collision.gameObject);
            Destroy(this.gameObject, 2);
        }
      
    }



}
