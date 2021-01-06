using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SurvalanceTurret : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;
    public Gradient redColor;
    public Gradient greenColor;

    public LineRenderer lineOfSight;
    
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1, hitInfo.point);
            lineOfSight.colorGradient = redColor;
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.up * distance, Color.green);
            lineOfSight.SetPosition(1, transform.position + transform.up * distance);
            lineOfSight.colorGradient = greenColor;
        }

        lineOfSight.SetPosition(0, transform.position);

    }
}
