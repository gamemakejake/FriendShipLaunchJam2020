using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed = 1;
    Vector2 movement;

    //public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player flew off the screen with transform.position.y in the line below.  Made it 0 again.
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(movement * speed * Time.deltaTime);
        //Jake did this, but we should change it to L/R Triggers instead
        //animator.SetFloat("SpeedHor", Mathf.Abs(movement.x));
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            Debug.Log("Interacting something");
        }
    }
}
