using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterMoving : MonoBehaviour
{
    public Sprite[] characterMovementImages;

    public float timePerImage = 0.5f;

    private Image characterImg;

    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        characterImg = GetComponent<Image>();

        currentTime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timePerImage)
        {
            characterImg.sprite = characterMovementImages[0];
            //print(0);
        }

        if (currentTime > timePerImage * 2)
        {
            characterImg.sprite = characterMovementImages[1];
            //print(1);
        }

        //if (currentTime > timePerImage * 3)
        //{
        //    characterImg.sprite = characterMovementImages[2];
        //    print(2);
        //}

        if (currentTime > timePerImage * 3)
        {
            currentTime = 0;

            //print(3);
        }
        
    }
}
