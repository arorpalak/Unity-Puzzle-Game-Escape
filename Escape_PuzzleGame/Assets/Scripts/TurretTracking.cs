using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTracking : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

    }


    
    void Update()
    {
        Vector3 dirction = player.position - transform.position;
        float angle = Mathf.Atan2(dirction.y, dirction.x) * Mathf.Rad2Deg - 90.0f;
        rb.rotation = angle;
    }
    
}
