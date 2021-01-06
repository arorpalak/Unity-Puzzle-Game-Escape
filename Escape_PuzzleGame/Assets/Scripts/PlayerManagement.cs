using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerManagement : MonoBehaviour
{
    public Image gameOverImage, winImage;

    public bool gameOver;

    public static PlayerManagement instance;

    public AudioSource bgMusic, bgSoundManagement, gameOverSound, winSound;

    public AudioClip gameOverClip, winClip;

    private float time = 0;
    
    public bool win;

    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameOver = true;

        }
       

        if(collision.gameObject.tag == "Boundary")
        {
            win = true;
        }
    }

    private void Update()
    {
        //Lose;
        if (gameOver && gameOverSound.isPlaying == false) 
        {
            gameOverImage.gameObject.SetActive(true);

            bgMusic.Stop();

            bgSoundManagement.Stop();

            gameOverSound.PlayOneShot(gameOverClip);

            //print(gameOverClip.length);

            //print("hhhhhhhhhhhhhhhh --->" + time);

        }

        if (gameOver)
        {
            if (time>gameOverClip.length && Input.anyKeyDown)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                time += Time.deltaTime;
            }
        }

        //Win;
        if (win && winSound.isPlaying == false)
        {
            winImage.gameObject.SetActive(true);

            bgMusic.Stop();

            bgSoundManagement.Stop();

            winSound.PlayOneShot(winClip);

            //print(gameOverClip.length);

            //print("hhhhhhhhhhhhhhhh --->" + time);

        }

        if (win)
        {
            if (time > winClip.length && Input.anyKeyDown)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                time += Time.deltaTime;
            }
        }
    }
}
