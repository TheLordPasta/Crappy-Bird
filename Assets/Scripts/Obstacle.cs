using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-0.2f, 0, 0);
        if (transform.position.x < -15)
        {
            FreeObstacle();
        }

        rb.velocity = new Vector2(-speed, 0);
    }

    void FreeObstacle()
    {
        Destroy(this.gameObject);
    }
}
