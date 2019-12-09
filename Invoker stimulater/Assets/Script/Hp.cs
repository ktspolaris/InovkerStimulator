using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    public float hp = 100f;
    public float damage = 20;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage() {
        hp = hp - damage;
        slider.value = (float)hp / 100;
        if (hp <= 0) {
            GameObject.Destroy(this.gameObject);
            // TODO : play animation
        }
    }
}
