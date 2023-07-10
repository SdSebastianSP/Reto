using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class AniMove : MonoBehaviour
{
    Rigidbody2D rb2D;
    Animator ani;
    SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * 1.5f, 0);
        if (Input.GetAxis("Horizontal") != 0)
        {
            ani.SetBool("Run", true);
            if (Input.GetAxis("Horizontal") < 0)
            {
                sR.flipX = true;
            }
            else
            {
                sR.flipX = false;
            }
        }    
        else
        {
            ani.SetBool("Run", false);
        }
    }   
}
