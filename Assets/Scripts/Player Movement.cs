using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    Rigidbody2D Rigid;
    public float Speed= 3;
    // Start is called before the first frame update
    void Start()
    {
        Rigid=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xmovement = Input.GetAxis("Horizontal");
        Rigid.velocity= new Vector2 (xmovement * Speed, Rigid.velocity.y);
        if (xmovement < 0) { spriteRenderer.flipX = false; } else { spriteRenderer.flipX = true; }
        float ymovement = Input.GetAxis("Vertical");
        Rigid.velocity = new Vector3(Rigid.velocity.x, ymovement);
    }
}
