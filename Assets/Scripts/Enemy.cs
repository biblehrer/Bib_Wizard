using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard.player.transform.position;
        Vector3 distanceVector = playerPosition -transform.position;
        distanceVector = distanceVector.normalized;
        transform.position += distanceVector * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Player")
        {
            Wizard.player.hp -= 10;
            Destroy(gameObject);
            return;
        }   
        if (collision2D.gameObject.tag == "Fireball")
        {
            Destroy(collision2D.gameObject);
            Destroy(gameObject);
            return;
        }   
    }
}
