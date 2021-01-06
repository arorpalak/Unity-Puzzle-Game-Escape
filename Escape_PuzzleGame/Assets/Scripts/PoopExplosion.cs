using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopExplosion : MonoBehaviour
{
    public GameObject poopExlosionPrefab;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject poopExplosionGo = GameObject.Instantiate(poopExlosionPrefab, transform.position, transform.rotation);

        //SoundManagement.instance.PlayPoopExplosion();

        Destroy(poopExplosionGo, 0.5f);

        Destroy(this.gameObject);

    }
}
