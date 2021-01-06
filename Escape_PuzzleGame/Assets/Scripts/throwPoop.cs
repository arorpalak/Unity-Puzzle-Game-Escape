using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwPoop : MonoBehaviour
{
    private Transform poopPosition;

    public GameObject poopPrefab;

    private float time = 0;

    public float timeInterval;

    public float poopSpeed;

    // Start is called before the first frame update
    void Start()
    {
        poopPosition = transform.Find("poopPosition");

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerManagement.instance.gameOver || PlayerManagement.instance.win)
        {
            return;
        }

        if (time >= timeInterval)
        {
            GameObject poop = GameObject.Instantiate(poopPrefab, poopPosition.position, poopPosition.rotation);

            time = 0;

            poop.GetComponent<Rigidbody2D>().velocity = poop.transform.right * poopSpeed;

            print(1);
        }
        else
        {
            time += Time.deltaTime;

            print(2);
        }
    }
}
