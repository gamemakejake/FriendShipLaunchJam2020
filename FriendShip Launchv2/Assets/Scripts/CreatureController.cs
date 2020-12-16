using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    public GameObject followCreature;
    public GameObject goneCreature;
    public bool friended = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (friended == true)
        {
            CreatureFriended();
        }
    }

    public void CreatureFriended()
    {
        goneCreature.SetActive(false);
        followCreature.SetActive(true);
    }
}
