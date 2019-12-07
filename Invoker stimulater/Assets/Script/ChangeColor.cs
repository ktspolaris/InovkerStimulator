using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material Fire; //声明一个需要替换的材质，在Unity页面进行赋值
    public Material Earth;
    public Material Water;
    public Material Wind;
    public Material Default;
    private MeshRenderer meshRender1;  //声明MeshRenderer组件
    private MeshRenderer meshRender2;
    private MeshRenderer meshRender3;
    private MeshRenderer meshRender4;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject skillSlot;
    public bool invoked = false;
    public int numofFire = 0;
    public int numofEarth = 0;
    public int numofWater = 0;
    public int numofWind = 0;

    enum skillPool { fireball, flash, wave };
    // Use this for initialization
    void Start()
    {
        slot1 = GameObject.Find("Cube");
        meshRender1 = slot1.GetComponent<MeshRenderer>();  //得到挂载在物体上的MeshRenderer组件
        meshRender2 = slot2.GetComponent<MeshRenderer>();
        meshRender3 = slot3.GetComponent<MeshRenderer>();
        meshRender4 = skillSlot.GetComponent<MeshRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        if (numofEarth + numofFire + numofWater + numofWind < 3)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                meshRender3.material = meshRender2.material;
                meshRender2.material = meshRender1.material;
                meshRender1.material = Fire;  //就把原来的材质替换成otherMeterial材质
                numofFire++;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                meshRender3.material = meshRender2.material;
                meshRender2.material = meshRender1.material;
                meshRender1.material = Earth;
                numofEarth++;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                meshRender3.material = meshRender2.material;
                meshRender2.material = meshRender1.material;
                meshRender1.material = Water;
                numofWater++;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                meshRender3.material = meshRender2.material;
                meshRender2.material = meshRender1.material;
                meshRender1.material = Wind;
                numofWind++;

            }
           
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            meshRender3.material = meshRender2.material = meshRender1.material = meshRender4.material = Default;
            numofEarth = numofFire = numofWater = numofWind = 0;
            invoked = false;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (numofFire == 3) { meshRender4.material = Fire; }
            if (numofWater == 3) { meshRender4.material = Water; }
            if (numofWind == 2 && numofFire == 1) { meshRender4.material = Wind; }
            invoked = true;

        }
    }
    //public int GenerateSkill()
    //{


    //    int nowSkill = 10 ;
    //    if (numofFire == 3)
    //    {
    //        nowSkill = 0;
    //    }

    //    if (numofFire + numofWind == 3)
    //    {
    //        nowSkill = (int)skillPool.flash;
    //    }
    //    if (numofWater == 3)
    //    {
    //        nowSkill = (int)skillPool.wave;
    //    }

    //    return nowSkill;
    //}



}
