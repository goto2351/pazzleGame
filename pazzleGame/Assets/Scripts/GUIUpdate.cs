using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class GUIUpdate : Config
{
    public float DistanceScale = 1.0f;
    public GameObject DistanceObj;
    public GameObject LifeObj;
    Text distanceText;
    Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        distanceText = DistanceObj.GetComponent<Text>();
        lifeText =LifeObj.GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        distanceText.text = "���s���� " + (Currentdistance * DistanceScale).ToString("f2") + "km�I";
        lifeText.text = "�c��̗́F" + CurrentLife;
    }

}
