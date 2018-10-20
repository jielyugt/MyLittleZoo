using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class focusButton : MonoBehaviour {
    public GameObject button1;
    public GameObject button2;

    public void hitFocus () {
        button1.SetActive(false);
        button2.SetActive(false);

    }



    // Update is called once per frame

}
