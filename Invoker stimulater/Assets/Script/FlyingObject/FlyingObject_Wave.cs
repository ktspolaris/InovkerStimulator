using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObject_Wave : FlyingObject
{
    public float movingDistance = 0;
    public int waterMass = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            waterMass += 1;
        }
        if (other.gameObject.tag == "NormalSoil")
        {
            waterMass -= 1;
        }
        if (other.gameObject.tag == "Forest")
        {
            waterMass -= 1;
        }
        if (other.gameObject.tag == "Earth")
        {
            Destroy(this);
        }
        //遇到特殊地形销毁
        //出范围移除？
    }
    
    // Start is called before the first frame update
    void Start()
    {
        movingDistance = 0;
        waterMass = 5;
        speed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        movingDistance += speed * Time.deltaTime;
        if (movingDistance >= 1)
        {
            waterMass -= 1;
            if (waterMass <= 0)
            {
                Destroy(this);
            }
            movingDistance = 0;
        } 
    }
}
