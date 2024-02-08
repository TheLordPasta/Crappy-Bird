using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    bool v_jumped = true;
    public float jumpPower;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Sprite playerSpriteWingDown;
    [SerializeField] private Sprite playerSpriteWingUp;
    public float animDuration = 10f;
    private SpriteRenderer spriteControler;
    // Start is called before the first frame update
    void Start()
    {
        spriteControler = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CreateRotation();
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (Input.GetButtonUp("Jump"))
        {
            spriteControler.sprite = playerSpriteWingUp;
        }
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        spriteControler.sprite = playerSpriteWingDown;
    }
    public void CreateRotation()
    {
        if (rb.velocity.y > -jumpPower / 2)
            transform.eulerAngles = new Vector3(0, 0, 90 * Mathf.Sin(90 / jumpPower * rb.velocity.y));
        //else
        //    transform.eulerAngles = new Vector3(0, 0,-45);
    }
}
