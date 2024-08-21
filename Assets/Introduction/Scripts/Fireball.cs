using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fireball : MonoBehaviour
{
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        float angle = Vector3.Angle(direction, Vector3.right);

        if (direction.y <0)
        {
            angle = angle * -1;
        }
        
        transform.Rotate(new Vector3(0,0,angle));

        Destroy(gameObject, 3);

        transform.position = transform.position + direction * 1.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.state == "Break")
        {
            return;
        }
        transform.position = transform.position + direction *4 * Time.deltaTime;        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;
        if (tag == "Player" || tag == "Fireball")
        {
            return;
        }    
        Destroy(gameObject);
        
    }
    
}
