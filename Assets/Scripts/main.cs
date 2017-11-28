using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {
    public class C
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

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
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

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
        }
    }

    public class Python
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

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
        }
    }

    public class Java
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Buenas tardes. ¿Que le puedo servir?";
            a.text = "Que sitio mas raro";
            b.text = "Que rapido me atienden aqui";
            c.text = "...";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Espera, yo te conozco… Estamos en la misma clase, ¿Verdad?";
            a.text = "No me suenas";
            b.text = "No lo creo, no salgo mucho de mi habitación";
            c.text = "Puede ser";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Por tu uniforme diría que estamos en la misma escuela. Siempre alegra ver gente nueva, aunque ya te digo que me suenas mucho. Me habré confundido, juraría que te he visto en otra parte. En fin, perdona mis modales… !Bienvenido a la cafetería Oracle! ¿Qué te puedo servir?";
            a.text = "Ponme un café de Java";
            b.text = "Cualquiera me sirve";
            c.text = "¿Que me recomiendas?";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "No pasa nada, yo tambien me suelo quedar mucho tiempo frente a la pantalla. Sobretodo las noches en las que me quedo programando hasta tarde. Es horrible cuando estás atascado en alguna parte del codigo.";
            a.text = "¿Por casualidad frecuentas StackOverflow?";
            b.text = "A veces me pasa, aunque prefiero consultarlo con la almohada";
            c.text = "¿Puedes tomar nota ya? Tengo prisa. Ponme un café";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bueno, eso depende, puedes revisar la carta y te doy mas tiempo si quieres. Aunque algo rápido sería un cafe.";
            a.text = "Vale";
            b.text = "no te preocupes, ponme un cafe de Java";
            c.text = "No me di cuenta de la hora que es, lo siento, me tengo que ir";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya, ese es mi café favorito, lo llevo tomando casi desde que nací. Se ve que mi padre y sus amigos eran unos adictos a él en el trabajo.  Me has caido bien, este lo paga la casa :)";
            a.text = "Cuanta amabilidad";
            b.text = "Oh, no me lo esperaba";
            c.text = "No es mi cumpleaños, ¿verdad?";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "marchando, pero luego no te quejes si no es de tu agrado";
            a.text = "Ok";
            b.text = "Mmmm,.. Quizás fui demasiado borde";
            c.text = "No pienso volver a esta cafetería";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bueno, pues no vuelvas por aqui";
            a.text = "Eso haré";
            b.text = "Ya te vale";
            c.text = "Super amable la camarera";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Pues claro! a veces es muy útil, Aunque hay veces en las que no entiendo nada… ¡Pero lo importante es que funciona! Veo que me entiendes, acabo mi turno en 10 minutos, te invito a un cafe...";
            a.text = "Perfecto";
            b.text = "Mejor no, gracias";
            c.text = "Esto no me lo esperaba";
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Jajaja, me pasa lo mismo, pero otras veces el error está en un simple punto y coma que se te escapa";
            a.text = "No serás tu la mejor programadora del mundo, ¿no?";
            b.text = "Lo que hay que escuchar";
            c.text = "Si utilizaras un IDE eso no te pasaría";
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Avísame si necesitas algo, estaré por aqui";
            a.text = "Estupendo";
            b.text = "Vale pero no te vayas muy lejos";
            c.text = "No me convence la carta";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya, ese es mi café favorito, lo llevo tomando casi desde que nací. Se ve que mi padre y sus amigos eran unos adictos a él en el trabajo.  Me has caido bien, este lo paga la casa :)";
            a.text = "Cuanta amabilidad";
            b.text = "Oh, no me lo esperaba";
            c.text = "No es mi cumpleaños, ¿verdad?";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "no pasa nada, ¡vuelve pronto!";
            a.text = "Me lo pensaré";
            b.text = "Si si, volveré, no te preocupes";
            c.text = "Chacho, que pesada loco"; //Cambiarlo, no me convence
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
        }
    }

    public class Cpp
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

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
        }
    }

    public class Php
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

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2";
            a.text = "2.1";
            b.text = "2.1";
            c.text = "2.1";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.1";
            a.text = "2.11";
            b.text = "2.12";
            c.text = "2.13";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.11";
            a.text = "2.111";
            b.text = "2.112";
            c.text = "2.113";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.12";
            a.text = "2.121";
            b.text = "2.122";
            c.text = "2.123";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.13";
            a.text = "2.131";
            b.text = "2.132";
            c.text = "2.133";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.111";
            a.text = "2.1111";
            b.text = "2.1112";
            c.text = "2.1113";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.112";
            a.text = "2.1121";
            b.text = "2.1122";
            c.text = "2.1123";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.113";
            a.text = "2.1131";
            b.text = "2.1132";
            c.text = "2.1133";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.121";
            a.text = "2.1211";
            b.text = "2.1212";
            c.text = "2.1213";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.122";
            a.text = "2.1221";
            b.text = "2.1222";
            c.text = "2.1223";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.123";
            a.text = "2.1231";
            b.text = "2.1232";
            c.text = "2.1233";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.131";
            a.text = "2.1311";
            b.text = "2.1312";
            c.text = "2.1313";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.132";
            a.text = "2.1321";
            b.text = "2.1322";
            c.text = "2.1323";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "2.133";
            a.text = "2.1331";
            b.text = "2.1332";
            c.text = "2.1333";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3";
            a.text = "3.1";
            b.text = "3.1";
            c.text = "3.1";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.1";
            a.text = "3.11";
            b.text = "3.12";
            c.text = "3.13";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.11";
            a.text = "3.111";
            b.text = "3.112";
            c.text = "3.113";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.12";
            a.text = "3.121";
            b.text = "3.122";
            c.text = "3.123";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.13";
            a.text = "3.131";
            b.text = "3.132";
            c.text = "3.133";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.111";
            a.text = "3.1111";
            b.text = "3.1112";
            c.text = "3.1113";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.112";
            a.text = "3.1121";
            b.text = "3.1122";
            c.text = "3.1123";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.113";
            a.text = "3.1131";
            b.text = "3.1132";
            c.text = "3.1133";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.121";
            a.text = "3.1211";
            b.text = "3.1212";
            c.text = "3.1213";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.122";
            a.text = "3.1221";
            b.text = "3.1222";
            c.text = "3.1223";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.123";
            a.text = "3.1231";
            b.text = "3.1232";
            c.text = "3.1233";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.131";
            a.text = "3.1311";
            b.text = "3.1312";
            c.text = "3.1313";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.132";
            a.text = "3.1321";
            b.text = "3.1322";
            c.text = "3.1323";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "3.133";
            a.text = "3.1331";
            b.text = "3.1332";
            c.text = "3.1333";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4";
            a.text = "4.1";
            b.text = "4.1";
            c.text = "4.1";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.1";
            a.text = "4.11";
            b.text = "4.12";
            c.text = "4.13";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.11";
            a.text = "4.111";
            b.text = "4.112";
            c.text = "4.113";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.12";
            a.text = "4.121";
            b.text = "4.122";
            c.text = "4.123";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.13";
            a.text = "4.131";
            b.text = "4.132";
            c.text = "4.133";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.111";
            a.text = "4.1111";
            b.text = "4.1112";
            c.text = "4.1113";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.112";
            a.text = "4.1121";
            b.text = "4.1122";
            c.text = "4.1123";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.113";
            a.text = "4.1131";
            b.text = "4.1132";
            c.text = "4.1133";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.121";
            a.text = "4.1211";
            b.text = "4.1212";
            c.text = "4.1213";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.122";
            a.text = "4.1221";
            b.text = "4.1222";
            c.text = "4.1223";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.123";
            a.text = "4.1231";
            b.text = "4.1232";
            c.text = "4.1233";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.131";
            a.text = "4.1311";
            b.text = "4.1312";
            c.text = "4.1313";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.132";
            a.text = "4.1321";
            b.text = "4.1322";
            c.text = "4.1323";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "4.133";
            a.text = "4.1331";
            b.text = "4.1332";
            c.text = "4.1333";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5";
            a.text = "5.1";
            b.text = "5.1";
            c.text = "5.1";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.1";
            a.text = "5.11";
            b.text = "5.12";
            c.text = "5.13";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.11";
            a.text = "5.111";
            b.text = "5.112";
            c.text = "5.113";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.12";
            a.text = "5.121";
            b.text = "5.122";
            c.text = "5.123";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.13";
            a.text = "5.131";
            b.text = "5.132";
            c.text = "5.133";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.111";
            a.text = "5.1111";
            b.text = "5.1112";
            c.text = "5.1113";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.112";
            a.text = "5.1121";
            b.text = "5.1122";
            c.text = "5.1123";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.113";
            a.text = "5.1131";
            b.text = "5.1132";
            c.text = "5.1133";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.121";
            a.text = "5.1211";
            b.text = "5.1212";
            c.text = "5.1213";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.122";
            a.text = "5.1221";
            b.text = "5.1222";
            c.text = "5.1223";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.123";
            a.text = "5.1231";
            b.text = "5.1232";
            c.text = "5.1233";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.131";
            a.text = "5.1311";
            b.text = "5.1312";
            c.text = "5.1313";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.132";
            a.text = "5.1321";
            b.text = "5.1322";
            c.text = "5.1323";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "5.133";
            a.text = "5.1331";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6";
            a.text = "6.1";
            b.text = "6.1";
            c.text = "6.1";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.1";
            a.text = "6.11";
            b.text = "6.12";
            c.text = "6.13";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.11";
            a.text = "6.111";
            b.text = "6.112";
            c.text = "6.113";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.12";
            a.text = "6.121";
            b.text = "6.122";
            c.text = "6.123";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.13";
            a.text = "6.131";
            b.text = "6.132";
            c.text = "6.133";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.111";
            a.text = "6.1111";
            b.text = "6.1112";
            c.text = "6.1113";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.112";
            a.text = "6.1121";
            b.text = "6.1122";
            c.text = "6.1123";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.113";
            a.text = "6.1131";
            b.text = "6.1132";
            c.text = "6.1133";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.121";
            a.text = "6.1211";
            b.text = "6.1212";
            c.text = "6.1213";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.122";
            a.text = "6.1221";
            b.text = "6.1222";
            c.text = "6.1223";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.123";
            a.text = "6.1231";
            b.text = "6.1232";
            c.text = "6.1233";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.131";
            a.text = "6.1311";
            b.text = "6.1312";
            c.text = "6.1313";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.132";
            a.text = "6.1321";
            b.text = "6.1322";
            c.text = "6.1323";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "6.133";
            a.text = "6.1331";
            b.text = "6.1332";
            c.text = "6.1333";
        }
    }



    public GameObject Fondo;
    Image myimagecomponent;
    public Sprite habitacion;
    public Sprite clase;
    public Sprite intro;
    //Ensamblador
    public Sprite gimnasio;
    public Sprite ensamblador;
    //Python
    public Sprite python;
    public Sprite entrada;
    //Java
    public Sprite java;
    public Sprite cafeteria;
    //Php
    public Sprite php;
    public Sprite cocin;
    //C
    public Sprite ce;
    public Sprite clasee;
    //Cpp
    public Sprite cepp;
    public Sprite pasilo;
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
    public GameObject Corazones;
    public Text corazon1;
    public Text corazon2;
    public Text corazon3;
    public Text corazon4;
    public Text corazon5;
    public Text corazon6;
    int cor1 = 0;int cor2= 0;int cor3= 0;int cor4= 0;int cor5= 0;int cor6 = 0;
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

    C waifu1 = new C();
    Php waifu2 = new Php();
    Cpp waifu3 = new Cpp();
    Java waifu4 = new Java();
    Python waifu5 = new Python();
    Ensamblador waifu6 = new Ensamblador();
	private void actualizarcorazones() {//para marcar la opcion correcta que te aumenta hacer cor1++; para la instawin cor1 + 6
        corazon1.text = cor1.ToString();
        corazon2.text = cor2.ToString();
        corazon3.text = cor3.ToString();
        corazon4.text = cor4.ToString();
        corazon5.text = cor5.ToString();
        corazon6.text = cor6.ToString();
    }
    private void mostrarbotonesmenu() {
        foreach (GameObject a in habitaciones)
        {
            a.active = true;
        }
        actualizarcorazones();
        Corazones.active = true;

    }
    private void ocultarbotonesmenu()
    {
        foreach (GameObject a in habitaciones)
        {
            a.active = false;
        }
        Corazones.active = false;
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
		if (daycounter > 6) {
			SceneManager.LoadScene("Créditos");
		}
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
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
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
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
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
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
                break;
            case 6:
                cancha();
                break;
        }
        momento++;
    }

    public void cpp()
    {

        loli = 1;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = clasee;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = ce;
        image.rectTransform.sizeDelta = new Vector2(100,100);


        switch (daycounter) {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu1.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu1.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu1.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void cocina()
    {
        loli = 2;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = cocin;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = php;
        image.rectTransform.sizeDelta = new Vector2(100, 100);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu2.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu2.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu2.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void pasillos()
    {
        loli = 3;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = pasilo;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = cepp;
        image.rectTransform.sizeDelta = new Vector2(100, 100);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu3.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
    
    public void cafe()
    {
        loli = 4;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = cafeteria;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = java;
        image.rectTransform.sizeDelta = new Vector2(100, 100);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu4.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu4.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu4.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
   
    public void azotea()
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
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia1(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia11(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia111(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia112(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia113(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu5.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu5.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu5.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void cancha()
    {
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
        image.rectTransform.sizeDelta = new Vector2(100, 100);

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
                                if (Booton == 1)
                                    waifu6.actualizar_dia1111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1112(textb, op1, op2, op3);
                                else if (Booton == 3)
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
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia2(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia21(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia211(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia212(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia213(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia3(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia31(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia311(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia312(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia313(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia4(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia41(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia411(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia412(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia413(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia5(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia51(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia511(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia512(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia513(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia6(textb, op1, op2, op3);
                        break;
                    case 2:
                        waifu6.actualizar_dia61(textb, op1, op2, op3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia611(textb, op1, op2, op3);
                        else if (Booton == 2)
                            waifu6.actualizar_dia612(textb, op1, op2, op3);
                        else if (Booton == 3)
                            waifu6.actualizar_dia613(textb, op1, op2, op3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6111(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6112(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6113(textb, op1, op2, op3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6121(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6122(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6121(textb, op1, op2, op3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6131(textb, op1, op2, op3);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6132(textb, op1, op2, op3);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6133(textb, op1, op2, op3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
}
