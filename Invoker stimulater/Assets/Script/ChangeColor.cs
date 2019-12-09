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

    public int elementNumber = 0;
    private MeshRenderer []meshRender = new MeshRenderer[4];  //声明MeshRenderer组件
    public GameObject []slot = new GameObject[4];
    public int[] element = new int[3];
    public int skillNumber = 0;

    enum skillPool { fireball,flash, wave };

    private void updateSkillGrid(MeshRenderer[] meshRenderArray, int[] elementArray)
    {
        meshRenderArray[0].material = meshRenderArray[1].material;
        meshRenderArray[1].material = meshRenderArray[2].material;
        elementArray[0] = elementArray[1];
        elementArray[1] = elementArray[2];    
    }

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            meshRender[i] = slot[i].GetComponent<MeshRenderer>();
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (elementNumber >= 2 && element[elementNumber]!=0 )
            {
                updateSkillGrid(meshRender, element);
            }
            meshRender[elementNumber].material = Fire;
            element[elementNumber] = 1;
            if (elementNumber < 2)
            {
                elementNumber++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (elementNumber >= 2 && element[elementNumber] != 0)
            {
                updateSkillGrid(meshRender, element);
            }
            meshRender[elementNumber].material = Earth;
            element[elementNumber] = 2;
            if (elementNumber < 2)
            {
                elementNumber++;
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (elementNumber >= 2 && element[elementNumber] != 0)
            {
                updateSkillGrid(meshRender, element);
            }
            meshRender[elementNumber].material = Water;
            element[elementNumber] = 4;
            if (elementNumber < 2)
            {
                elementNumber++;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (elementNumber >= 2 && element[elementNumber] != 0)
            {
                updateSkillGrid(meshRender, element);
            }
            meshRender[elementNumber].material = Wind;
            element[elementNumber] = 8;
            if (elementNumber < 2)
            {
                elementNumber++;
            }

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            skillNumber = 0;
            for(int i = 0; i < 4; i++)
            {
                meshRender[i].material = Default;
                if (i < 3)
                {
                    skillNumber |= element[i];
                    element[i] = 0;
                }          
            }
            
            switch (skillNumber)
            {
                case 1:
                    meshRender[3].material = Fire;
                    break;
                case 2:
                    meshRender[3].material = Earth;
                    break;
                case 4:
                    meshRender[3].material = Water;
                    break;
                case 8:
                    meshRender[3].material = Wind;
                    break;

            }
            elementNumber = 0;
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
