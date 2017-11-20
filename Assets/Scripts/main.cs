using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {
    public class C
    {
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Hey , que , que haces aqui. No deberías estar por los pasillos";
            texto.text = "¿Acaso eres el nuevo?";
            a.text = "Si no se de que te extrañas.";
            b.text = "A ti que te importa";
            c.text = "Si, ando un poco perdido";
        }
    }
    public GameObject Fondo;
    Image myimagecomponent;
    public Sprite habitacion;
    public Sprite clase;
    public Sprite intro;
    public GameObject habitacion1;
    public GameObject habitacion2;
    public GameObject habitacion3;
    public GameObject habitacion4;
    public GameObject habitacion5;
    public GameObject habitacion6;
    public GameObject mainbutton;
    public GameObject opcion1;
    public Text op1;
    public GameObject opcion2;
    public Text op2;
    public GameObject opcion3;
    public Text op3;
    public GameObject textbox;
    public Text textb;
    public GameObject Daybox;
    public GameObject chica;
    public Text contadordiastext;
    public int seleccion = 4;//variable para marcar la seleccion hecha
    GameObject[] habitaciones;
    GameObject[] opciones;
    int daycounter = 0; //CONTADOR DEL DIA QUE ES
    
    private void mostrarbotonesmenu() {
        foreach (GameObject a in habitaciones)
        {
            a.active = true;
        }
    }
    private void ocultarbotonesmenu()
    {
        foreach (GameObject a in habitaciones)
        {
            a.active = false;
        }
    }
    private void ocultaropciones()
    {
        foreach (GameObject a in opciones)
        {
            a.active = false;
        }
    }
    private void mostraropciones()
    {
        foreach (GameObject a in opciones)
        {
            a.active = true;
        }
    }


    private void Start()    {
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = intro;
        GameObject[] dummy = { habitacion1, habitacion2, habitacion3, habitacion4, habitacion5, habitacion6 };
        GameObject[] dummy2 = { opcion1, opcion2, opcion3};
        habitaciones = dummy;
        opciones = dummy2;
        ocultarbotonesmenu();
        ocultaropciones();
        textbox.active = false;
        Daybox.active = false;
        chica.active = false;
}
    void Update () {}

    public void inicio () {
        daycounter++;
        contadordiastext.text = daycounter.ToString();
        myimagecomponent.sprite = habitacion;
        mainbutton.active = false;
        mostrarbotonesmenu();
        textbox.active = false;
        Daybox.active = true;
    }

    public void cpp() {
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = clase;
        textbox.active = true;
        chica.active = true;
        C waifu = new C();
        switch (daycounter) {
            case 1:
                waifu.actualizar_dia1(textb,op1,op2,op3);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }
    public void cancha() {
        switch (daycounter)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

    public void pasillos()
    {
        switch (daycounter)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }
    public void cafe()
    {
        switch (daycounter)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

    public void Entrada()
    {
        switch (daycounter)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

    public void cocina()
    {
        switch (daycounter)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }

}
