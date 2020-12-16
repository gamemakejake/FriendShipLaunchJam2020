using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endbuttonlaunch : MonoBehaviour
{

    public GameObject launchButton;
    private void OnTriggerEnter(Collider other)
    {
        launchButton.SetActive(true);
    }
}
