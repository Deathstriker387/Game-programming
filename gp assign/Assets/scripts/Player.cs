using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health, maxhealth;
    // Start is called before the first frame update
    [SerializeField]
    private Health Healthbar;
    void Start()
    {
        Healthbar.SetMaxHealth(maxhealth);
    }
    public void SetHealth(float healthChange) {
        health += healthChange;
        health = Mathf.Clamp(health,0,maxhealth);
        Healthbar.SetHealth(health); 
    }
    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown("d")){
            SetHealth(-10f);
        }
        if (Input.GetKeyDown("a")) {
            SetHealth(10f);
                }
    }
}
