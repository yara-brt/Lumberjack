using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move2D : MonoBehaviour
{
    public Rigidbody2D rBody;
    public SpriteRenderer renderer;
    public Animator animation;
    public float xMin;
    public float xMax;
    private float direction;

    public Text textScore;
    public int score = 0;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
    }

    void Update()
    {
        Flip();
        float x = 0;
        float yBranch = 0;
        float xLeft = -2.42f;
        float xRight = 2.42f;
        
        if(Input.GetMouseButtonDown(0))
        {
            x = xLeft;
            score++;
        }
        if(Input.GetMouseButtonDown(1))
        {
            x = xRight;
            score++;
        }
        transform.Translate(new Vector2(x,0));
        this.textScore.text = score.ToString();
    }

    void Flip()
    {
        //animation.SetBool("leftButton", true);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), transform.position.y);
        if(Input.GetMouseButtonDown(0))
        {
            animation.SetBool("leftButton", true);
            animation.SetBool("rightButton", false);
            if(renderer.flipX != false)
            {
                renderer.flipX = false;
            }
        }
        else if(Input.GetMouseButtonDown(1))
        {
            animation.SetBool("leftButton", false);
            animation.SetBool("rightButton", true);
            if(renderer.flipX != true)
            {
                renderer.flipX = true;
            }
        }
    }
}
