using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObject_Forest : StaticObject
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FireBall")
        {
            if (frozen)
            {
                frozen = false;
                dry = false;
            }
            else if (!dry)
            {
                dry = true;
            }
            else if (flammable && !burning)
            {
                burning = true;
            }
            Destroy(other);
        }

        if (other.gameObject.tag == "Wave")
        {
            if (dry)
            {
                dry = false;
                //other.GetComponent<Wave>().waterMass -= 1;
            }
            if (burning)
            {
                burning = false;
                burned = true;
                //other.GetComponent<Wave>().waterMass = 0;
                Destroy(other);
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        typeOfThisGrid = PublicData.TypeOfGrid.Forest;
        flammable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
