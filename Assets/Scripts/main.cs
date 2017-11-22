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

    public class Ensamblador
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Aun no es la hora de Educacion Fisica, ¿que haces en la cancha?";
            a.text = "Dar una vuelta, la clase me aburria, ni changeles.";
            b.text = "Te podria preguntar lo mismo, ni changeles.";
            c.text = "Sali al baño y me perdi, ni changeles.";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bueno, ya que estas aqui, ¿Por que no jugamos un rato?";
            a.text = "Por que no.";
            b.text = "¿Estas seguro? Pertenezco a la generacion de los milagros.";
            c.text = "Yo soy mas de estar en mi casa jugando a otomes.";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "No tienes muchas ganas de jugar";
            a.text = "No estoy muy animado.";
            b.text = "Es que no me apetece jugar contigo.";
            c.text = "No se jugar.";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya chuleria llevas encima, vamos a ver si lo demuestras";
            a.text = "Despues no digas que no te lo adverti.";
            b.text = "Primero debemos calentarnos.";
            c.text = "Here we go!";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Que aburrido eres, ¿nunca haces deporte?";
            a.text = "Nop.";
            b.text = "Aveces, cuando me dicen mis amigos de jugar.";
            c.text = "Voy al gimnsaio para mantenerme.";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Y eso por que? ¿No te encuentras bien?";
            a.text = "No mucho, me duele la cabeza.";
            b.text = "Ultimamente no estoy animado con nada.";
            c.text = "Simplemente no me apetece.";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Eres un borde, no me apetece hablar mas contigo";
            a.text = "...";
            b.text = "...";
            c.text = "...";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "No te preocupes, yo te puedo enseñar";
            a.text = "Mejor no, ahora mismo me siento mal";
            b.text = "Venga va";
            c.text = "Se amable conmigo sempai!";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya, menudo partido. No me lo has puesto nada facil. Pero todo el mundo sabe que soy dificil de dominar";
            a.text = "Un placer jugar contigo.";
            b.text = "Tu dame tiempo y te acabaras arrodillando antes mi";
            c.text = "Por eso mismo nadie te quiere, eres un duro.";
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Es eso una proposicion indicente?";
            a.text = "Sera lo que tu quieras que sea <3";
            b.text = "¿Como va a ser nada? No quiero lesionarme";
            c.text = "Puede...";
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Y por que no?";
            a.text = "No me gusta sudar.";
            b.text = "Por que me gusta mas ejercitar el cerebro.";
            c.text = "Pues por pereza sin mas";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Pues propon tu el ir a jugar";
            a.text = "Deberia hacer eso";
            b.text = "Vivo lejos y no tengo medio de transporte";
            c.text = "Todos estamos muy ocupados";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Como debe ser";
            a.text = "Todos deberian hacer lo mismo";
            b.text = "Estoy mal de la espalda y debo mantenerme";
            c.text = "Por cada vez que un codigo no compila hago 5 dominadas"; //Cambiarlo, no me convence
        }

    }

    public class Python
    {

    }
    
    public GameObject Fondo;
    Image myimagecomponent;
    public Sprite habitacion;
    public Sprite clase;
    public Sprite intro;
    public Sprite gimnasio;
    public Sprite ensamblador;
    public Sprite python;
    public Sprite entrada;
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
    int loli = 0; //Que loli es escogida para este dia
    int momento = 1; //En qe momento del dia nos encontramos, hay 5 momentos por dia
    int Booton = 0; //Que boton se ha pulsado
    int OldBooton = 0;
    int daycounter = 0; //CONTADOR DEL DIA QUE ES
    Ensamblador waifu6 = new Ensamblador();
    C waifu1 = new C();


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
        ocultaropciones();
        textbox.active = false;
        Daybox.active = true;
        chica.active = false;
    }

    public void Boton1()
    {
        OldBooton = Booton;
        Booton = 1;
        switch (loli)
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
                cancha();
                break;
        }
        momento++;
    }
    public void Boton2()
    {
        OldBooton = Booton;
        Booton = 2;
        switch (loli)
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
                cancha();
                break;
        }
        momento++;
    }

    public void Boton3()
    {
        OldBooton = Booton;
        Booton = 3;

        switch (loli)
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
                cancha();
                break;
        }
        momento++;
    }

    public void cpp() {
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = clase;
        textbox.active = true;
        chica.active = true;
        switch (daycounter) {
            case 1:
                waifu1.actualizar_dia1(textb,op1,op2,op3);
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
        loli = 6;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = gimnasio;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = ensamblador;
        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if(Booton == 1)
                                    waifu6.actualizar_dia1111(textb, op1, op2, op3);
                                else if(Booton == 2)
                                    waifu6.actualizar_dia1112(textb, op1, op2, op3);
                                else if(Booton == 3)
                                    waifu6.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
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
        if(momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
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

    public void Azotea()
    {
        loli = 5;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = entrada;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = python;
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
