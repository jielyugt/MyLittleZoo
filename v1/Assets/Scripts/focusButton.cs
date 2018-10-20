using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class focusButton : MonoBehaviour {

    public GameObject canvas1;
    public GameObject canvas2;



    public void hitFocus () {
        canvas1.SetActive(false);
        canvas2.SetActive(true);


    }
}
