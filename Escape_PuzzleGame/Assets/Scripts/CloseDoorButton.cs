using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorButton : MonoBehaviour
{
    public static CloseDoorButton instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject buttonPressedPrefab;

    //public GameObject greenButtonBounce;

    public Sprite greenButton;

    public bool closeDoor;

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log(1);

        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space) && !closeDoor)
        {
            Debug.Log(2);
            GetComponent<SpriteRenderer>().sprite = null;

            GameObject buttonPressed = Instantiate(buttonPressedPrefab, transform.position, transform.rotation);

            Destroy(buttonPressed, 0.3f);

            closeDoor = true;

            Invoke("OnButtenPressed", 0.3f);
        }
    }

    private void OnButtenPressed()
    {
        GetComponent<SpriteRenderer>().sprite = greenButton;
        //print(1);
    }
}
