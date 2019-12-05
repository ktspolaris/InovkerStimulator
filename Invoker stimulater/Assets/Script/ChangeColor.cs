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
    public GameObject Skill;
    // Use this for initialization
    void Start()
    {
        slot1 = GameObject.Find("Cube");
        meshRender1 = slot1.GetComponent<MeshRenderer>();  //得到挂载在物体上的MeshRenderer组件
        meshRender2 = slot2.GetComponent<MeshRenderer>();
        meshRender3 = slot3.GetComponent<MeshRenderer>();
        meshRender4 = Skill.GetComponent<MeshRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            meshRender3.material = meshRender2.material;
            meshRender2.material = meshRender1.material;
            meshRender1.material = Fire;  //就把原来的材质替换成otherMeterial材质

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            meshRender3.material = meshRender2.material;
            meshRender2.material = meshRender1.material;
            meshRender1.material = Earth;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            meshRender3.material = meshRender2.material;
            meshRender2.material = meshRender1.material;
            meshRender1.material = Water;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            meshRender3.material = meshRender2.material;
            meshRender2.material = meshRender1.material;
            meshRender1.material = Wind;

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            meshRender3.material = meshRender2.material = meshRender1.material = Default;
        }
        if (Input.GetKeyDown(KeyCode.V)) { 
           
        
        }

    }

    int GenerateSkill() {
       
        return 0;
    }


}
