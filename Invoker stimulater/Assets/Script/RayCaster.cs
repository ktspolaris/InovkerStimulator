using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public Transform light;
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray2D ray = new Ray2D(transform.position, transform.up);
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, transform.up);
        if (hit.collider != null)
        {
            //Debug.Log("clicked object name is ---->" + hit.collider.gameObject);
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        
            //Instantiate(light, transform.position, transform.rotation);
            return;
        }

    }
   

}

