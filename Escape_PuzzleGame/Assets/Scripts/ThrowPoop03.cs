using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPoop03 : MonoBehaviour
{
    private Transform poopPosition;

    public GameObject poopPrefab;

    private float time = 0;

    private float timeInterval;

    private float poopSpeed;

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
            poopSpeed = Random.Range(6, 20);

            GameObject poop = GameObject.Instantiate(poopPrefab, poopPosition.position, poopPosition.rotation);

            time = 0;

            poop.GetComponent<Rigidbody2D>().velocity = poop.transform.right * poopSpeed;

            timeInterval = Random.Range(1, 4);

            print(1);
        }
        else
        {
            time += Time.deltaTime;

            print(2);
        }
    }
}
