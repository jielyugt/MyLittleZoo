using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class focusButton : MonoBehaviour {

    public GameObject canvas1;
    public GameObject canvas2;

    public GameObject text;
    public GameObject slider;
    public GameObject buttonGo;
    //public timer tt;



    public void hitFocus () {
        canvas1.SetActive(false);
        canvas2.SetActive(true);


    }

    public void cleanFocusCanvas () {

    }
}
