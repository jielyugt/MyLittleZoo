using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectButton : MonoBehaviour {

    public GameObject button1;
    public GameObject button2;

    public void hitConnect()
    {
        button1.SetActive(false);
        button2.SetActive(false);

    }
}
