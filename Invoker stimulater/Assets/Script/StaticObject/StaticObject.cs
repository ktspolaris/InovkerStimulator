using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StaticObject : MonoBehaviour
{
    public int heightOfThisGrid = -2;
    public int mass = 1;
    public PublicData.TypeOfGrid typeOfThisGrid = PublicData.TypeOfGrid.Base;
    public bool solid = true;
    public bool flammable = false;
    public bool burning = false;
    public bool burned = false;
    public bool frozen = false;
    public bool dry = true;
    public bool conductible = false;
    public bool galvanic = false;
    public int quantityOfEletricity = 0;
    public bool destroyable = false;
    public bool magnetic = false;
    public bool magnetise = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
