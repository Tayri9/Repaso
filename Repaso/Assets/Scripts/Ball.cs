using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;

    [SerializeField]
    float mSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.right;
        direction.y = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * mSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            direction.x = direction.x * -1f;
            direction.y = Random.Range(-1f, 1f);
        }

        if (collision.gameObject.tag == "Wall")
        {
            direction.y = direction.y * -1f;
        }

        Debug.Log("Ha chocado " + collision.collider.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = Vector3.zero;
        direction.x = direction.x * -1f;
        direction.y = direction.y * -1f;

        if (collision.gameObject.tag == "Goal1")
        {
            Marker.instance.Player2Goal();
            Debug.Log("Gol jugador 2");
        }

        if (collision.gameObject.tag == "Goal2")
        {
            Marker.instance.Player1Goal();
            Debug.Log("Gol jugador 1");
        }        
        
    }
}
