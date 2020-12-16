using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueBox;
    public bool talkOver = false;
    //public GameObject goneCreature;
    //public GameObject followCreature;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && talkOver == false)
        {
            //Time.timeScale = 0f;
            
            dialogueBox.SetActive(true);
            StartCoroutine(Wait());
            
            

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Time.timeScale = 1f;
            //    dialogueBox.SetActive(false);
            //    goneCreature.SetActive(false);
            //    followCreature.SetActive(true);

            //}

            //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        }
    }

    IEnumerator Wait()
    {
        Debug.Log("Trig");
        Time.timeScale = 0.25f;
        yield return new WaitForSeconds(2);
        Time.timeScale = 1f;
        dialogueBox.SetActive(false);
        talkOver = true;

    }
}
