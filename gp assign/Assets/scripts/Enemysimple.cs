using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemysimple : MonoBehaviour

{
    public Playhp play;
    public float dmg;
    public float speed = 1.0f;
    public Transform[] loc;
    private int randomspots;
    // Start is called before the first frame update
    void Start()
    {
        randomspots = Random.Range(0,loc.Length);
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = Vector2.MoveTowards(transform.position,loc[randomspots].transform.position,speed*Time.deltaTime);

        
        if (Vector2.Distance(transform.position, loc[randomspots].transform.position) <0.5f) { 
            randomspots= Random.Range(0, loc.Length);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    
    
    if (collision.gameObject.CompareTag("Player"))
    {
    play.SetHealth(-dmg);
        }
   }
}
