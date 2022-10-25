using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float speed = 80f;
    public float forwardSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0));
        transform.Rotate(new Vector3(0, 0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime));

        
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += transform.right * Time.deltaTime * forwardSpeed;
        }
        //transform.RotateAround(player.transform.position, Vector3.up, 20 * Time.deltaTime);
    }


}
