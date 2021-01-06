using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDestroyingE : MonoBehaviour
{
    public static InteractionWithPlayer instance;
    private void Awake()
    {
        
    }

    public GameObject buttonPressedPrefab;

    //public GameObject greenButtonBounce;

    public Sprite greenButton;

    public bool isGreen;
    public GameObject barrier;




    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log(1);

        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space) && !isGreen)
        {
            Debug.Log(2);
            GetComponent<SpriteRenderer>().sprite = null;

            GameObject buttonPressed = Instantiate(buttonPressedPrefab, transform.position, transform.rotation);

            Destroy(buttonPressed, 0.3f);

            isGreen = true;

            Invoke("OnButtenPressed", 0.3f);
            Destroy(barrier);
        }
    }

    private void OnButtenPressed()
    {
        GetComponent<SpriteRenderer>().sprite = greenButton;
        print(1);
    }
}
