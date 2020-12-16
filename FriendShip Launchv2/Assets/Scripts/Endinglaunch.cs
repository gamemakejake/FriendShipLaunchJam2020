using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endinglaunch : MonoBehaviour
{
    public GameObject trig;
    private void OnTriggerEnter(Collider other)
    {
        trig.SetActive(true);
    }
}
