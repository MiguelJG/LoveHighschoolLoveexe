using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {
    public GameObject Fondo;
    Image myimagecomponent;
    public Sprite habitacion;
    public Text input;

    private void Start()    {
        myimagecomponent = Fondo.GetComponent<Image>();
    }
    void Update () {}

    public void inicio () {
        myimagecomponent.sprite = habitacion;
        input.text = "hola";
    }
}
