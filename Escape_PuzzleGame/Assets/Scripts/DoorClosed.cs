using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosed : MonoBehaviour
{
    public GameObject pivotPoint;

    private bool doorClose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CloseDoorButton.instance.closeDoor && !doorClose)
        {
            this.transform.RotateAround(pivotPoint.transform.position, new Vector3(0, 0, 1), 90 * Time.deltaTime);

            //print(this.transform.rotation.eulerAngles.z);
            //print(this.transform.rotation);

            if (this.transform.rotation.eulerAngles.z >= 88)
            {
                doorClose = true;
            }
        }
    }
}
