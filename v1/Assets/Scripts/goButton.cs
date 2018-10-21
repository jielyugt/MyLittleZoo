using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goButton : MonoBehaviour {

    public timer tt;
    float value;
    public GameObject canvas2;


    public void hitGo()
    {
        canvas2.SetActive(false);
        tt.setTime(value);



    }
    public void setvalue(float f) {
        value = f;
    }


}
