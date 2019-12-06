using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public GameObject character;
    protected  Transform b_transform;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        b_transform = this.transform;
        Destroy(this.gameObject, 1f);

    }

    // Update is called once per frame
    void Update()
    {

        b_transform.Translate(new Vector2(0, speed * Time.deltaTime));
    }
}
