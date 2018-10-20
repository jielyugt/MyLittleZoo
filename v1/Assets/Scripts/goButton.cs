using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goButton : MonoBehaviour {


    public GameObject Slider;
    public timer tt;
    float value;
    public GameObject button1;

    public void hitGo()
    {
        Slider.SetActive(false);
        button1.SetActive(false);
        //tt = GetComponent<timer>();
        tt.setTime(value); // ???



    }
    public void setvalue(float f) {
        value = f;
    }


}
