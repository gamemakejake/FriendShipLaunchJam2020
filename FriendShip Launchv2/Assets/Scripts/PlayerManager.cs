using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed = 1;
    public Vector3 offset; // for interactable objects
    public bool givesItem = false;
    Vector3 movement;

    //public Animator animator;
    GameObject interactableObject;
    bool interact = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player flew off the screen with transform.position.y in the line below.  Made it 0 again.
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(movement * speed * Time.deltaTime);

        if (interact && Input.GetKey(KeyCode.Space))
        {
            interactableObject.transform.position = new Vector3(transform.position.x + offset.x, transform.position.y + offset.y, transform.position.z + offset.z);
            interactableObject.transform.SetParent(transform);
            if (givesItem)
            {
                interactableObject.SetActive(false);
            }
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            Debug.Log("Pickup");
            interact = true;
            interactableObject = collision.gameObject;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            interact = false;
        }
    }
}
