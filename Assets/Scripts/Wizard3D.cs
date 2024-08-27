using UnityEngine;

public class Wizard3D : MonoBehaviour
{
    private Vector3 lastDirection;
    public GameObject fireballPrefab;
    public static GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 

        if (Input.GetMouseButtonUp(0) )
        {
            GameObject obj = Instantiate(fireballPrefab, transform.position + lastDirection + Vector3.up, Quaternion.identity);
            obj.GetComponent<Feuerball3D>().direction = lastDirection;
        }
    }

    public void Move()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            movement += Vector3.up;
        }*/

        if (movement.magnitude > 0)
        {
            lastDirection = movement.normalized;
            transform.position += movement.normalized * Time.deltaTime * 3 ;  
            Rotate();
        }         
    }

    public void Rotate()
    {
        float angle = Vector3.Angle(lastDirection, Vector3.forward);        
        if (lastDirection.x < 0)
        {
            angle = angle * -1;
        }
        transform.rotation = Quaternion.Euler(0, angle,0);
    }

}
