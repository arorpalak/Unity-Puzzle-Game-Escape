using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    private float timeBtwShoit;
    public float startTimeBTwShots;
    public GameObject projectile;
    public Transform target; 
    public float attackRadius;


    public Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShoit = startTimeBTwShots;
    }

    // Update is called once per frame
    void Update()
    {/*
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }else if (Vector2.Distance(transform.position, player.position) <  stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        } else if((Vector2.Distance(transform.position, player.position) < retreatDistance))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }*/
        if (Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            if (timeBtwShoit <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBtwShoit = startTimeBTwShots;
            }
            else
            {
                timeBtwShoit -= Time.deltaTime;
            }
        }
    }
        
}
