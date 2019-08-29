using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoControle : MonoBehaviour {
    Vector2 startPosition;
    public Transform endPosition;
    public float speed;
    bool goingBack;
    public float timer;
    public GameObject inimigo;
    private bool left;
    public float move ;
    Animator anim;
    SpriteRenderer sprite;


    void Start()
    {
        anim = GetComponent<Animator>();
        left = true;
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (transform.position.x >= 6.9f)
            left = true;
        if (left)       
            transform.Translate(-1f * Time.deltaTime, 0f, 0f);

        if (transform.position.x <= -6.9f)
            left = false;
        if (!left)    
            transform.Translate(1f * Time.deltaTime, 0f, 0f);
        if (left )
        {
            anim.SetBool("Andando", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("Andando",true);
            sprite.flipX = false;
        }
      
    }
}
