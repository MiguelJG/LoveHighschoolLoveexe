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
			texto.text = "Hey , que , que haces aquí. No deberías estar por los pasillos,¿Acaso eres el nuevo?\n";
			a.text = "Si no se de que te extrañas.";
			b.text = "A ti que te importa";
			c.text = "Si, ando un poco perdido";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Siendo así no me extraña. Pues… “Bienvenido al instituto” Espero que programemos mucho juntos";
			a.text = "No se yo, a mi me van mas los lenguajes de scripting";
			b.text = "Por supuesto. Los retos moderados son mis favoritos";
			c.text = "No estoy seguro, yo necesito un poco de clase";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "A bueno, eso es otra cosa. A mi el scripting no me va mucho, pero si me lo pides te podría llevar a muchas bibliotecas públicas muy guays ^^";
			a.text = "Bueno. Si tantas ganas tienes creo que podría intentarlo";
			b.text = "Qué pesada. No quiero algo tan complejo";
			c.text = "¿Es que no sabes decir otra cosa?";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Retos moderados. Se que parezco fácil pero espera un poco y verás… jeje";
			a.text = "Tan difícil eres?";
			b.text = "Seguro que no. Un par de clases de informática básica y fijo que aprendo a buscar el mínimo.";
			c.text = "Eso es por lo vieja que eres. Mejor algo más joven";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Jo. Entonces te puedo presentar a algunos de mis familiares";
			a.text = "Me han dicho que c++ también está por aquí?\n";
			b.text = "Tal vez c#?\n";
			c.text = "Por aquí hay mucha gente interesante";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "BIEEEEEEN!!! Creo que para empezar con algo facil deberias practicar con la entrada y la salida, que siempre da problemas";
			a.text = "Claro! Seguire tus consejos al pie de la letra";
			b.text = "Prefiero empezar por los bucles que son más entretenidos";
			c.text = "Tal vez mañana nos vemos. Hasta entonces return 0;";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No pensaba que fueras a ser tan estúpido. Seguro que eres de los que programan solo con scratch";
			a.text = "Y a mucha honra";
			b.text = "Vete ya a solucionar alguna excepción y déjame en paz";
			c.text = "Que ya te lo dije. Prefiero los de scripting";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Nunca pensé que me encontrara a alguien tan desagradecido. No mereces ser programador";
			a.text = "Todo era mejor con solo circuitos no programables";
			b.text = "Pues vete a Stack Overflow que eso está lleno";
			c.text = "¯\\_(ツ)_/¯";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Al principio no, pero tengo una curva de dificultad peor que la del dark souls";
			a.text = " Acepto el reto";
			b.text = "pfff a lo mejor me lo tengo que pensar";
			c.text = "Venga va. Que no se diga que no se intenta";
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Jajajajajajajaj o tal vez ni eso";
			a.text = "Que si, ya verás";
			b.text = "Te apuesto lo que quieras a que te hago un juego";
			c.text = "Si me ayudas claro que lo conseguiré";
        }
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c)
		{
			texto.text = "Hey!! Que solo tengo 45 años";
			a.text = "Lo dicho. Vieja";
			b.text = "Tus descendientes más jóvenes van mejor que tu";
			c.text = "Comparado con migo, un millenial, eres vieja";
		}

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Si. Probablemente la encuentres en los pasillos. Siempre con objetos en la cabeza";
			a.text = "Pues tal vez me pase mañana";
			b.text = "Seguro que eres mejor.";
			c.text = "Mañana será otro día";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Que va. Es una hikikomori del .NET. Y su padre Microsoft se enfada mucho siempre";
			a.text = "Entonces me alegro de que no esté en este instituto";
			b.text = "Pues me quedo contigo";
			c.text = "Que gente mas rara hay en el mundo";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Por supuesto. Aquí estamos las mejores (Menos PHP. Esa no le gusta a nadie)";
			a.text = "Pues habrá que saludar";
			b.text = "Ya me las iré encontrando";
			c.text = "Pues bueno. Hasta mañana";
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Hey ayuda por favor;";
			a.text = "Qué te pasa?";
			b.text = "Pasando";
			c.text = "Aviso a alguien??";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Creo que voy a tener un error. No se que puede ser";
			a.text = "Seguro que es cosa de algún “;” que falta";
			b.text = "Has añadido todas las librerías?";
			c.text = "Seguro que es un fallo lógico";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Si, seguramente. Me ayudas a buscarlo?";
			a.text = "Por supuesto. Entre los 2 y un poco de extreme programming lo encontramos enseguida";
			b.text = "Mejor que te ayude un debugger";
			c.text = "Por esto python mola. No tiene “;”";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Si estoy segura de haberlas añadido";
			a.text = "Y las dependencias están instaladas??";
			b.text = "Tal vez es un problema del SSOO";
			c.text = "Este fallo demuestra lo mal lenguaje que eres";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Si si, es un segmentation. Noooooooo...";
			a.text = "Pero no te desmayes";
			b.text = "Que algoritmo mas mal programado";
			c.text = "Que exagerada";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Muchas gracias. Sin ti no lo habría encontrado <3";
			a.text = "De nada :)";
			b.text = "Nunca está de más ayudar a un amigo";
			c.text = "Siempre que quieras te ayudo";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Siempre respondes con ese tono de estúpido";
			a.text = "Será porque lo soy";
			b.text = "Ni que no pudieras encontrarlo tú sola";
			c.text = "No, lo siento. No quería enfadarte";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ya, pero ye tengo algo que python no tiene...";
			a.text = "Carisma";
			b.text = "Python te puede usar cuando quiera";
			c.text = "Me jor te incluyo en una librería y me voy con c++";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Por supuesto. Que me tomas por una novata ??";
			a.text = "Que humos tan subidos.";
			b.text = "HTML no falla así...";
			c.text = "jajajaja con esa actitud claro que tienes errores";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No creo. Voy en linux que apenas falla";
			a.text = "Yo soy más de Windows";
			b.text = "Teniendo en cuenta que se te puede usar en cualquier sitio...";
			c.text = "apel al poderrrr ";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
			texto.text = "no es verdad :’(";
			a.text = "Claro que si";
			b.text = "Paso de ti";
			c.text = "Otros lenguajes son  capaces de omitir esos fallos";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Te puedo hacer una pregunta";
			a.text = "Claro";
			b.text = "Diga lo que diga me la vas a hacer ";
			c.text = "No";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues ahí va :Tu que prefieres ++dummy o dummy++?";
			a.text = "Todo el mundo sabe que hacen cosas diferentes";
			b.text = "Prefiero ++dummy";
			c.text = "Prefiero dummy++";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Eso ya lo se. Eres un poco antipático";
			a.text = "Es que si haces preguntas de primero de carrera pues claro...";
			b.text = "No era mi intención";
			c.text = "Estoy seguro que como ser supremo de la luz, tengo razón";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Se ve que sabes lo que es bueno de verdad";
			a.text = "Ya, yo no quiero para nada una copia del objeto";
			b.text = "Aunque en verdad, las pequeñas diferencias no me molestan";
			c.text = "Nunca pensé que me pondría de acuerdo contigo";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ese no me llega a convencer";
			a.text = "Es el que usa la mayoría de gente";
			b.text = "Pues eso";
			c.text = "Para gustos colores";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues para que te pongas así me voy";
			a.text = "pues vale";
			b.text = "...";
			c.text = "Me da igual";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Vale vale, pues entonces cuál es tu favorita?";
			a.text = "dummy++";
            b.text = "++dummy";
			c.text = "soy un ser del caos y uso dummy +=1";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues te quedas solo, ser supremo de la luz";
			a.text = "Esa era mi intención";
            b.text = "Bien";
			c.text = "Vete a compilar a otra parte";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Sabes la diferencia!!! Eres el mejor";
			a.text = "<3";
			b.text = "Ya lo sabia jeje";
			c.text = "No hace falta que lo digas";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues a mi un poco :/";
			a.text = " No me importa tu opinión";
			b.text = "Este juego esta como mal programado ¿No?";
			c.text = "Hasta otro dia, pues";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Tengo un +10 en carisma siempre";
			a.text = "Hey que esto no es d&d";
			b.text = "Que chula";
			c.text = "jajajaj claro. Hasta otro dia";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ya, y eso no me gusta";
			a.text = "Pues habrá que explicarles las diferencias";
			b.text = "jajajajaja, me da igual";
			c.text = "otro dia me cuentas el porqué";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Si has llegado aquí te has encontrado con mi falta de inspiración";
			a.text = "No se que poner aqui";
			b.text = "Hacer diálogos es más difícil que programar";
			c.text = "-Ninguna de estas opciones es la valida";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
			texto.text = "O mejor dicho, estilos de programación";
			a.text = "Jajajaja";
			b.text = "No tiene tanta gracia";
			c.text = "Que humor más simple";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ya has hecho mi hello world?";
			a.text = "Todo el mundo sabe que el hello world se copia y pega;";
			b.text = " jajajaja claro;\n";
			c.text = "Si, y hasta me resulto dificil";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues creo que va siendo hora de pasar a cosas más complejas";
			a.text = "Mientras no programemos lenguajes operativos";
			b.text = "Por supuesto";
			c.text = "No quiero hacer cosas tan difíciles contigo";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Jo, pues esa era mi intención";
			a.text = "Ves, si es que te leo la mente";
			b.text = "eres demasiado compleja";
			c.text = "pssss";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues te voy a recomendar la librería Darknet de redes neuronales";
			a.text = "Wow, frena el carro, que no soy de computación";
			b.text = "Mola mola, ahora mismo me pongo a aprenderla";
			c.text = "Ya si eso otro dia";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Wow para el carro. Que no nos podemos pasar de pegi 7 que nos echan la bronca";
			a.text = "pfff creo que todos somos adultos aquí";
			b.text = "ni que nos escandalizamos por hablar de ciertos temas";
			c.text = "Hablar de eso vende mas fijo";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "jajajajaja coincidencia";
			a.text = "Lo dicho, no hay ganas";
			b.text = "Mejor otro dia";
			c.text = "Adios";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ya lo se, pero hago lo que puedo";
			a.text = "Se te quiere igual";
			b.text = "Hasta otro dia";
			c.text = "Adios";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "pssss a ti";
			a.text = "pasando";
            b.text = "...";
            c.text = "ja";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No necesitas ser de computación para entenderlo";
			a.text = "Bueno bueno, aunque lo digas así, no";
			b.text = "Pasando";
			c.text = "Déjame en paz anda";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Genial, ya me irás contando que tal :)";
			a.text = "Por supuesto";
			b.text = "Mañana mismo te lo digo";
			c.text = "claro";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Jo, vale";
			a.text = "Si es que no sabes recomendar nada bueno";
			b.text = "Hasta nunca";
			c.text = "Adios";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ya , pero no es cosa mía, es cosa de la organización";
			a.text = "Pues a ver si el año que viene hacemos un juego muy gore";
			b.text = "Cuando te dicen que no hagas algo siempre tienta";
			c.text = "pasando";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues aparentemente sí, y hay que mantener las formas";
			a.text = "Que ganitas de decir lo que apetezca";
			b.text = "De momento no hemos hecho nada que nos pueda descalificar";
			c.text = "XD";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Claro que vende más";
			a.text = "Que pena que esto no se venda";
			b.text = "Ya lo dice el refrán...";
			c.text = "Este juego es Family friendly";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Eres capaz de decir algun programa que yo he hecho";
			a.text = "Sip";
            b.text = "Nop";
            c.text = "Claro";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Venga, te voy a dar una oportunidad. Elige sabiamente GIT, Unity, Twitter ";
			a.text = "GIT";
			b.text = "Unity";
			c.text = "Twitter";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Exacto. Has acertado. Se nota que sabes sobre mi";
			a.text = "“Son muchos años estudiando ya";
			b.text = "Como no iba  a saber eso sobre el mejor lenguaje del mundo";
			c.text = "Obviamente";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues no. unity lo hace c++ (aunque seguro que me usa para ello)";
			a.text = "si es que c++ es mejor";
			b.text = "No se ni porque estoy hablando contigo";
			c.text = "Es que se nota donde hay clase";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Ni de cerca";
			a.text = "He fallado adrede";
			b.text = "Como que no";
			c.text = "Que pena";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Jajajajajaja me alegro";
			a.text = ":)";
			b.text = "yo también";
			c.text = "psss";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
			texto.text = "vas a hacer que me sonroje";
			a.text = "<3";
			b.text = "Cualquier piropo se queda corto";
			c.text = "Si es que eres la mejor";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
			texto.text = " no es tan obvio. Hay mucha gente que falla";
			a.text = "Me da igual";
			b.text = "Curioso que  fallen";
			c.text = "jajajajajaja";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Eso no es cierto :’(";
			a.text = "si que lo es";
			b.text = "jajajajaja me da igual que llores";
			c.text = "adios";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "ara que te pongas borde me voy";
			a.text = "pues adiós";
            b.text = "...";
			c.text = "era solo una broma";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No tener clases no es malo. Solo soy de otro paradigma de programación";
			a.text = "sin clases no hay gloria";
			b.text = "meh";
			c.text = "Molaria que instanciaras un objeto. A no, que no puedes";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No te creo. Has fallado de verdad";
			a.text = "si :S";
			b.text = "lo que tu digas";
            c.text = "Adios";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
			texto.text = "pues que no está hecho en c. ¡¡Si es que es de navegador!!";
			a.text = "tal vez estas confundida...\n";
			b.text = "Ni me acerque a la respuesta correcta";
			c.text = "Adios";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues si. Te quedas sin el regalo";
			a.text = "¿Cómo, había un regalo?";
			b.text = "jo :(";
			c.text = "Pues me las tendré que apañar sin el";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Qué decir. Se acaba la semana y no nos volveremos a ver hasta la semana que viene";
			a.text = "Tambien me pone triste";
			b.text = "me da igual";
			c.text = "Diga lo que diga vamos a ir a la misma opción";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues eso. hagamos una cosa. Programemos un último programa";
			a.text = "No";
			b.text = "Si claro";
			c.text = "No creo que pueda";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
			texto.text = "¿Porque no?¿no te gusto?";
			a.text = "te he dicho muchas veces que no";
			b.text = "jajajajaja ¿tu?";
			c.text = "no estoy seguro";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues vamos a ello. Elige tu el reto:";
			a.text = "Bubble sort";
			b.text = "IA";
			c.text = "Sudoku";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
			texto.text = "pues si no estas seguro vete a un lenguaje más fácil. A no que no puedes";
			a.text = "A veces pienso que tu personaje está mal enfocado";
			b.text = "Originalidad o mala programación";
			c.text = "Que es que no te queda originalidad?";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No tiene que ser tan maleducado";
			a.text = "yo hago lo que quiero";
			b.text = "acaso no estoy jugando yo";
			c.text = "adios";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
			texto.text = ":’(";
			a.text = "Adios";
			b.text = "Eso vete a llorar a tu casa";
			c.text = "Me da igual que llores";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Pues si no estas seguro, mejor lo hablamos en otra run";
			a.text = "claro. Este juego es genial y lo voy a rejugar";
			b.text = "Claro, no hay juego mejor que este";
			c.text = "Claro, Este juego gana fijo";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Curiosa elección, vamos a ello";
			a.text = "vamos";
			b.text = "Lo hacemos el fin de semana";
			c.text = "Adios";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Un tema interesante, se ve que te van los retos";
			a.text = "No hay reto que se me resista";
			b.text = "Es que me va eso de crear IAs";
			c.text = "Es que mola";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
			texto.text = "La vieja confiable. Me gusta tu estilo";
			a.text = "jej :)";
			b.text = "claro, hasta la próxima";
			c.text = "Si es que molas tu y todo lo que hagas";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
			texto.text = "pues claro que no lo está. Me escribieron a la 1:30 de la noche";
			a.text = "jajajaja no dormir afecta al guionista";
			b.text = "pues hasta nunca";
			c.text = "Adios";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
			texto.text = "Definitivamente mala programación";
			a.text = "Si es que eso de hacer un juego en poco tiempo no sale bien";
			b.text = "No saber de unity previamente tiene esos inconvenientes";
			c.text = "XD";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
			texto.text = "No es a mi, sino al tío que me escribió";
			a.text = "Se nota que no se le ocurre nada gracioso";
			b.text = "Si es que es un cacas";
			c.text = "Decir caca vulnera el Pegi7?";
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
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c)
		{
			texto.text = "Hey!! Que solo tengo 45 años";
			a.text = "Lo dicho. Vieja";
			b.text = "Tus descendientes más jóvenes van mejor que tu";
			c.text = "Comparado con migo, un millenial, eres vieja";
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
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c)//añadir
		{
			texto.text = "...";
			a.text = "...";
			b.text = "...";
			c.text = "...";
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
            texto.text = "Buenos días ¿Que le puedo servir?";
            a.text = "(Quedarse callado)";
            b.text = "Buenos días";
            c.text = "Observar la mesa de al lado";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Un momento ¿Usted no estuvo ayer aquí?";
            a.text = "Vengo por el famoso café";
            b.text = "¿Me toma nota? Por favor";
            c.text = "Realmente no sé que hago aquí ";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c)
        {
            texto.text = "No me sorprende, Java es una maravilla para el paladar y lo servimos de una manera muy especial";
            a.text = "Lo es, realmente me llama mucho la atención. ¿Me podrías decir el secreto?";
            b.text = "A ver, está bien, pero tampoco es una maravilla";
            c.text = "Cuanta modestia";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vale vale, ¿Que te apetece tomar?";
            a.text = "Ponme un barraquito ";
            b.text = "Un sanwich mixto";
            c.text = "No me convence la carta";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c)
        {
            texto.text = "En el fondo sé que estás aquí por nuestro increíble café de Java";
            a.text = "Ponme uno de esos entonces";
            b.text = "No sé, no me terminas de convencer";
            c.text = "En realidad es porque me queda al lado de las clases";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Ni de broma. Es un secreto que solo mi familia conoce y no lo voy a revelar así por las buenas ";
            a.text = "Como quieras";
            b.text = "Ni que fuese la receta de la cocacola";
            c.text = "Pues me voy";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Cómo dices?";
            a.text = "Lo que oyes";
            b.text = "He probado elixires mejores";
            c.text = "No te ofendas";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Siempre digo lo mismo pero Java es el café favorito de mi padre. Lo solía tomar con sus amigos en el trabajo";
            a.text = "Interesante";
            b.text = "¿En serio? ¡Que guay!";
            c.text = "Tampoco me cuentes tu vida";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Un barraquito? ¿Que es eso? Yo te recomendaría un café de Java, es más rápido";
            a.text = "Me fio de tus gustos, sírveme uno";
            b.text = "Me gusta mas el barraquito";
            c.text = "No me vendas la moto";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Y… ¿No lo quieres acompañar con un café de Java?";
            a.text = "Eso estaría genial";
            b.text = "No, gracias";
            c.text = "Parece que Java y tu son uno";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Te dejo más tiempo para decidir";
            a.text = "Perfecto";
            b.text = "(Seguir ojeando la carta)";
            c.text = "Tu verás lo que haces";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¡Marchando! No te arrepentirás, vas a probar el mejor café del mundo";
            a.text = "Pones las expectativas muy altas";
            b.text = "Como para que no me guste";
            c.text = "Que ganas de probarlo";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Entonces deberías probarlo. Juro que no te arrepentirás";
            a.text = "Como no me guste lo pagas tu";
            b.text = "Es difícil que no me guste con ese nombre";
            c.text = "Paso";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Jo, eres peor que un segmentation fault";
            a.text = "Me lo suelen decir";
            b.text = "Es lo que hay";
            c.text = "(Sonreir)";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Hoy es nuestro visitante Nº100, le vamos a dejar elegir cualquier cosa de la carta de forma totalmente gratuita";
            a.text = "¿Que me estas comentando?";
            b.text = "Esto es mejor que compilar a la primera";
            c.text = "¿De qué me sonará esto?...";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Si si, lo que escuchas. Además es la primera vez que hacemos algo así, espero que la carta sea de tu agrado ";
            a.text = "Ponme de todo";
            b.text = "Ponme un Cafe de Java";
            c.text = "Esto me huele mal, no quiero nada, me voy";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Eso son pequeños placeres de la vida reservados a unos pocos afortunados. Entonces ¿Que te sirvo?";
            a.text = "Ponme un cafe de Java";
            b.text = "Ponme de todo";
            c.text = "Ponme un barraquito";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Es algo similar a los anuncios de internet, pero con la diferencia de que aquí no te ponemos keylogers ni programas basura y somos más confiables";
            a.text = "Se ve que entiendes mucho del tema";
            b.text = "Bueno, de algo hay que morir, ponme toda la carta";
            c.text = "Ambas cosas me dan poca confianza";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo.";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿En serio? puedes elegir cualquier cosa. El café de Java es una maravilla, pero tienes la posibilidad de pedir cualquier otra cosa";
            a.text = "Que no, ahora me pones toda la carta";
            b.text = "Venga vale, por ser tu te dejo que me sirvas lo que quieras";
            c.text = "Tengo hambre";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya, se ve que la estrategia no ha funcionado muy bien...";
            a.text = "Pues no, la verdad";
            b.text = "No te preocupes, sigue intentándolo";
            c.text = "Quien la sigue la consigue";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Se lo suelo decir a todo el mundo que lo pide, pero es mi café favorito. A mi padre le encantaba tomarlo en el trabajo con sus compañeros.";
            a.text = "Conque de ahí viene el nombre,...";
            b.text = "¿Ah si?";
            c.text = "No me interesa";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Un barraquito? Que es eso? Yo te recomendaría un café de Java, es más rápido";
            a.text = "Me fio de tus gustos, sírveme uno";
            b.text = "Me gusta mas el barraquito";
            c.text = "No me vendas la moto"; ;
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Gajes del oficio";
            a.text = "Se te nota curtida en el asunto";
            b.text = "Te veo dolida";
            c.text = "Te entiendo, dame un abrazo";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vaya, se ve que la estrategia no ha funcionado muy bien...";
            a.text = "Pues no, la verdad";
            b.text = "No te preocupes, sigue intentándolo";
            c.text = "Quien la sigue la consigue";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Hola";
            b.text = "Curioso el nombre";
            c.text = "Gracias ";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Ya sabes lo que quieres hoy?";
            a.text = "Aun no";
            b.text = "Estoy ocupado con una práctica, ponme un café";
            c.text = "Ponme lo de siempre";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Entonces te dejo más tiempo para decidir, avísame si quieres algo";
            a.text = "Bueno, ahora que lo pienso, ponme un vaso de agua";
            b.text = "¿Que me recomiendas para picar?";
            c.text = "(Quedarse callado)";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bueno, ya sabes lo que dicen: “Si no lo logras a la primera, llámalo versión 1.0”. ¿Quieres azúcar?";
            a.text = "Espero no tener muchas versiones";
            b.text = "Ponme mucha azúcar, por favor";
            c.text = "Quiero que compile";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¡Un café de Java marchando!";
            a.text = "Ponme mucha azúcar, por favor";
            b.text = "(Teclear furiosamente)";
            c.text = "Menos mal que la cafetería está cerca";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Entrar a una cafetería a por un vaso de agua? Bueno, cosas peores se han visto";
            a.text = "Un codigo sin comentarios";
            b.text = "El live action de Death Note en Netflix";
            c.text = "Entregar una práctica un viernes a ultima hora";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Pues un editor de texto plano y mucha imaginación";
            a.text = "Vaaaale, mejor me voy";
            b.text = "Me refería de la carta";
            c.text = "Me ha gustado, no me lo esperaba";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bueno, eso significa que no quieres que te moleste";
            a.text = "Veo que pillas las indirectas";
            b.text = "Realmente no sé que pedir";
            c.text = "(Continuar callado)";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "El café seguro que te ayuda, enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Te veo estresado, tómate un descanso de vez en cuando";
            a.text = "Eso es lo que recomiendan todos";
            b.text = "Gracias por ser tan amable";
            c.text = "No hasta que no la termine";
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Eso es que se te escapó algún punto y coma, dale tiempo y revisa";
            a.text = "Veo que entiendes del tema";
            b.text = "Imposible";
            c.text = "Tendré que revisar mi código";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Te veo estresado, tómate un descanso de vez en cuando";
            a.text = "Eso es lo que recomiendan todos";
            b.text = "Gracias por ser tan amable";
            c.text = "No hasta que no la termine";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Tranquilo, no vaya a ser que pierdas el CTRL";
            a.text = "10/10 ";
            b.text = "Sin Ctrl +z pierdo la cabeza";
            c.text = "¿Has intentado ir al club de la comedia?";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Es una gran ventaja para estudiantes. Además el precio está adaptado";
            a.text = "Todo bien mientras no suban el precio 0,2€";
            b.text = "Ya te digo, es una pasada";
            c.text = "No es para tanto";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Veo que no te cansas de venir por aquí. Me alegra que te guste la cafetería";
            a.text = "Es lo que tiene el café";
            b.text = "La cafetería tiene algo que a todos los informáticos nos atrae";
            c.text = "Exactamente, ponme un café para llevar";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Cuanta razón tienes. El café es casi indispensable para rendir al 100%... Aunque traigo una mala noticia. Se nos ha terminado el café de Java";
            a.text = "Menuda ironía";
            b.text = "Normal, es tan bueno que todo el mundo lo quiere probar";
            c.text = "Entonces me voy";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Creo que eso es más común de lo que nos pensamos";
            a.text = "Sírveme lo que quieras";
            b.text = "Somos como Homer y la cerveza";
            c.text = "Es nuestra kriptonita";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿Hace falta que pregunte el café que quieres?";
            a.text = "Creo que no";
            b.text = "Como quieras";
            c.text = "Tengo prisa";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Ya, pero bueno, si quieres te puedo servir otra cosa";
            a.text = "Nah, mejor me voy";
            b.text = "Vale, lo dejo en tus manos";
            c.text = "Que no vuelva a pasar";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Que agradable eres, veo que eres comprensible. No todo el mundo lo entiende.";
            a.text = "No te preocupes, es algo normal";
            b.text = "Esto no debería pasar nunca";
            c.text = "La gente siempre está enfadada por las mañanas";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Lo sentimos mucho, te podemos poner un cortado si quieres";
            a.text = "Mejor un barraquito";
            b.text = "No te preocupes por eso";
            c.text = "Que poca vergüenza";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c)
        {
            texto.text = " Me lo dejas en bandeja, ahora te traigo un cafe de Java";
            a.text = "¿Lo dices por ser camarera?";
            b.text = "Gracias, muy amable";
            c.text = "Cuanto antes mejor";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "O como Maggie y su chupete";
            a.text = "Vivan las referencias";
            b.text = "Ahi ya te pasaste";
            c.text = "No me sigas el juego";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Que agradable es tener conversaciones así de vez en cuando";
            a.text = "Tu trabajo puede ser estresante";
            b.text = "Nunca viene mal";
            c.text = "Bueno, suficiente";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Bastante obvio, ¿verdad?";
            a.text = "Nunca es demasiado obvio";
            b.text = "(Asentir con la cabeza)";
            c.text = "Pues si";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¡Marchando un café de Java para llevar!";
            a.text = "Cuanta felicidad con tan poco";
            b.text = "No vuelvas a hacer eso por favor";
            c.text = "Espero que no nos hayan escuchado";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Vale vale, enseguida te lo traigo";
            a.text = "Lo que hay que soportar";
            b.text = "Quizás me pasé";
            c.text = "Que paciencia hay que tener";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c)
        {
            texto.text = " Llegados a este punto, ¿No te está taladrando la mente la musica?";
            a.text = "Pues un poco si";
            b.text = "La verdad es que ni me habia dado cuenta";
            c.text = "Me gustaría que tomases nota";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c)
        {
            texto.text = "La verdad es que los que la pusieron tienen bastante mal gusto. Pero no podemos hacer nada por ahora";
            a.text = "Yo cerraría el juego";
            b.text = "Me está entrando cáncer";
            c.text = "Dame mi café";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c)
        {
            texto.text = "¿En serio? Deberías ir al médico,... Por si acaso";
            a.text = "Yo sabré lo que me hago";
            b.text = "No creo, me está gustando";
            c.text = "Da igual, ponme un café";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Cierto, disculpa mis modales. ¿Que te sirvo?";
            a.text = "Ponme un cafe de Java";
            b.text = "Ponme un colacao";
            c.text = "Ponme un leche y leche";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Por favor, no hagas eso, te regalo un café Java";
            a.text = "Que facil ha sido eso";
            b.text = "Aun no es navidad";
            c.text = "¿Es mi cumpleaños?";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Ánimo, ya queda poco";
            a.text = "¡Muchas gracias!";
            b.text = "Quiero acabar este sufirmiento cuanto antes";
            c.text = "No quiero que acabe";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Dame un momentito y enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Que antipático";
            a.text = "Lo siento, no me compila el código";
            b.text = "Dame un café, lo necesito";
            c.text = "Quizás me pasé ";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Me sorprendes, eres el elegido";
            a.text = "Creo que ves demasiado cine";
            b.text = "¿El que traerá el equilibrio a la fuerza?";
            c.text = "¿Soy Neo?";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Dame un momentito y enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Te pondré una taza grande porque me caes bien";
            a.text = "Que facil ha sido eso";
            b.text = "Aun no es navidad";
            c.text = "¿Es mi cumpleaños?";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Solo tenemos Nesquik";
            a.text = "NO PUEDE SER";
            b.text = "Que desgraciado soy";
            c.text = "Eres de las mías #TeamNesquick";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c)
        {
            texto.text = "Qué mal gusto. Teniendo tanta variedad y pides eso";
            a.text = "Lo que hay";
            b.text = "Ya, soy una desgracia";
            c.text = "Pues a mi me gusta";
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
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c)
		{
			texto.text = "Hey!! Que solo tengo 45 años";
			a.text = "Lo dicho. Vieja";
			b.text = "Tus descendientes más jóvenes van mejor que tu";
			c.text = "Comparado con migo, un millenial, eres vieja";
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
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c)
		{
			texto.text = "Hey!! Que solo tengo 45 años";
			a.text = "Lo dicho. Vieja";
			b.text = "Tus descendientes más jóvenes van mejor que tu";
			c.text = "Comparado con migo, un millenial, eres vieja";
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
	public Sprite InLove;
	public Text Final;
	public GameObject Final_;
	public GameObject botonfinal;
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
		Final_.active = false;
		botonfinal.active = false;
        textbox.active = false;
        Daybox.active = false;
        chica.active = false;
    }
    void Update () {}
	public void buttonfinal(){
		SceneManager.LoadScene ("Créditos");
	}

    public void inicio () {
        daycounter++;
		if (daycounter > 6) {
			chica.active = false;
			ocultaropciones ();
			textbox.active = false;
			myimagecomponent.sprite = InLove;
			botonfinal.active = true;
			string dummy = "";
			if (cor1 > 4) {
				dummy += " C++, ";
			}
			if (cor2 > 4) {
				dummy += " PHP, ";
			}
			if (cor3 > 4) {
				dummy += " C, ";
			}
			if (cor4 > 4) {
				dummy += " Java, ";
			}
			if (cor5 > 4) {
				dummy += " Python, ";
			}
			if (cor6 > 4) {
				dummy += " Ensamblador ";
			}
			if (dummy == "") {
				dummy = "Nadie ";
			}
			Final.text = dummy + " se han enamorado de ti.";
			Final_.active = true;

		} else {
			contadordiastext.text = daycounter.ToString ();
			myimagecomponent.sprite = habitacion;
			mainbutton.active = false;
			mostrarbotonesmenu ();
			ocultaropciones ();
			textbox.active = false;
			Daybox.active = true;
			chica.active = false;
		}
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
        image.rectTransform.sizeDelta = new Vector2(490,685);


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
                                    waifu1.actualizar_dia1123(textb, op1, op2, op3);
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
                                    waifu1.actualizar_dia2123(textb, op1, op2, op3);
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
                                    waifu1.actualizar_dia3123(textb, op1, op2, op3);
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
                                    waifu1.actualizar_dia4123(textb, op1, op2, op3);
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
                                    waifu1.actualizar_dia5123(textb, op1, op2, op3);
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
                                    waifu1.actualizar_dia6123(textb, op1, op2, op3);
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
        image.rectTransform.sizeDelta = new Vector2(300, 600);

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
                                    waifu2.actualizar_dia1123(textb, op1, op2, op3);
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
                                    waifu2.actualizar_dia2123(textb, op1, op2, op3);
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
                                    waifu2.actualizar_dia3123(textb, op1, op2, op3);
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
                                    waifu2.actualizar_dia4123(textb, op1, op2, op3);
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
                                    waifu2.actualizar_dia5123(textb, op1, op2, op3);
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
                                    waifu2.actualizar_dia6123(textb, op1, op2, op3);
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
        image.rectTransform.sizeDelta = new Vector2(300, 685);

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
                                    waifu3.actualizar_dia1123(textb, op1, op2, op3);
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
                                    waifu3.actualizar_dia2123(textb, op1, op2, op3);
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
                                    waifu3.actualizar_dia3123(textb, op1, op2, op3);
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
                                    waifu3.actualizar_dia4123(textb, op1, op2, op3);
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
                                    waifu3.actualizar_dia5123(textb, op1, op2, op3);
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
                                    waifu3.actualizar_dia6123(textb, op1, op2, op3);
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
        image.rectTransform.sizeDelta = new Vector2(300, 685);

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
                                    waifu4.actualizar_dia1123(textb, op1, op2, op3);
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
                                    waifu4.actualizar_dia2123(textb, op1, op2, op3);
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
                                    waifu4.actualizar_dia3123(textb, op1, op2, op3);
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
                                    waifu4.actualizar_dia4123(textb, op1, op2, op3);
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
                                    waifu4.actualizar_dia5123(textb, op1, op2, op3);
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
                                    waifu4.actualizar_dia6123(textb, op1, op2, op3);
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
		image.rectTransform.sizeDelta = new Vector2(350, 685);

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
                                    waifu5.actualizar_dia1123(textb, op1, op2, op3);
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
                                    waifu5.actualizar_dia2123(textb, op1, op2, op3);
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
                                    waifu5.actualizar_dia3123(textb, op1, op2, op3);
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
                                    waifu5.actualizar_dia4123(textb, op1, op2, op3);
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
                                    waifu5.actualizar_dia5123(textb, op1, op2, op3);
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
                                    waifu5.actualizar_dia6123(textb, op1, op2, op3);
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
        image.rectTransform.sizeDelta = new Vector2(1100, 1000);

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
