using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    public GameObject character;
    public Transform nearbyPlayer;
    private float distance;
    public float SightRange;
    public float SightAngle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(character.transform.position, this.transform.position);

    }

    void CheckinSight() {

        if (distance < SightRange)
        {

            Vector3 direction = character.transform.position - this.transform.position;
            float degree = Vector3.Angle(direction, this.transform.up);
            if (degree < SightAngle / 2 && degree > -SightAngle / 2)
            {
                Ray ray = new Ray();
                ray.origin = this.transform.position;
                ray.direction = direction;
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo, SightRange))
                {
                    if (hitInfo.transform == character.transform)
                    {
                        //如果僵尸能够看到玩家就缓存这个玩家
                        nearbyPlayer = character.transform;
                    }
                    else {
                        nearbyPlayer = null;
                    }
                }
            }

        }
    }


        
}
