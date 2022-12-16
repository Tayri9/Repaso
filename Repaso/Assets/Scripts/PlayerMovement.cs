using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float mSpeed = 10f;

    [SerializeField]
    KeyCode buttonUp, buttonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(buttonUp))
        {
            transform.position += Vector3.up * Time.deltaTime * mSpeed;
        }

        if (Input.GetKey(buttonDown))
        {
            transform.position += Vector3.down * Time.deltaTime * mSpeed;
        }
    }
}
