using System;
using System.Threading;

namespace Bingo
{
    // Clase Menu
    public static class Menu
    {
        public static Boolean todasLasOpciones = false;
        public static Boolean EsValidaPrimeraOpcionMenu(
            String opcion,
            Boolean bandera
        )
        {
            if (!bandera)
            {
                if (
                    opcion != "1" &&
                    opcion != "2" &&
                    opcion != "3"
                )
                    return false;
                else
                    return true;
            }

            else
            {
                if (
                    opcion != "1" &&
                    opcion != "2" &&
                    opcion != "3" &&
                    opcion != "4"
                )
                    return false;
                else
                    return true;
            }
        }

        public static void MostrarMensajeComunBingo()
        {
            Colores.EstablecerColorTexto("verde");
            Console.Write("\t- ");

            Colores.EstablecerColorTexto("rojo");
            Console.Write("- ");

            Colores.EstablecerColorTexto("azul");
            Console.Write("- ");

            Colores.EstablecerColorTexto("magenta");
            Console.Write("B");

            Colores.EstablecerColorTexto("cian");
            Console.Write("i");

            Colores.EstablecerColorTexto("amarillo");
            Console.Write("n");

            Colores.EstablecerColorTexto("verde");
            Console.Write("g");

            Colores.EstablecerColorTexto("rojo");
            Console.Write("o");

            Colores.EstablecerColorTexto("azul");
            Console.Write(" - ");

            Colores.EstablecerColorTexto("magenta");
            Console.Write("- ");

            Colores.EstablecerColorTexto("cian");
            Console.WriteLine("-\n");

            Colores.EstablecerColorTexto("default");
        }

        public static void MostrarHora(String tiempo)
        {
            tiempo = "Son las ";

            Colores.EstablecerColorTexto("cian oscuro");

            tiempo += DateTime.Now.ToString(
                "h:mm tt"
            );

            Console.Write(tiempo);

            Colores.EstablecerColorTexto("default");
        }

        public static Boolean ControladorPrimerMenu(
            String opcion,
            String respuestaSalida,
            Boolean bandera
        )
        {
            if (!bandera)
            {
                if (
                    opcion == "1" ||
                    opcion == "2" ||
                    respuestaSalida == "n"
                )
                    return true;
                else
                    return false;
            }

            else
            {
                if (
                    opcion == "1" ||
                    opcion == "2" ||
                    opcion == "3" ||
                    respuestaSalida == "n"
                )
                    return true;
                else
                    return false;
            }
        }

        public static Boolean ControladorSegundoMenu(String segundaOpcionMenu)
        {
            if (
                segundaOpcionMenu == "1" ||
                segundaOpcionMenu == "2" ||
                segundaOpcionMenu == "3" ||
                segundaOpcionMenu == "4"
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static void MostrarOpcionesMenuPrincipal(String nickname)
        {
            Colores.EstablecerColorTexto("default");
            Console.Write("J1");

            Colores.EstablecerColorTexto("cian");
            Console.Write(" { ");

            Colores.EstablecerColorTexto("default");
            Console.Write(nickname);

            Colores.EstablecerColorTexto("cian");
            Console.Write(" } ");

            Colores.EstablecerColorTexto("default");

            Console.WriteLine(
                "Estas son las opciones\n"
                + "disponibles para la partida "
                + "de bingo:\n"
            );

            Colores.EstablecerColorTexto("cian");
            Console.WriteLine("1 - Jugar.");

            Colores.EstablecerColorTexto("magenta");
            Console.Write("2 - ");

            Colores.EstablecerColorTexto("default");
            Console.WriteLine(
                "Registrar números del primer cartón."
            );

            Colores.EstablecerColorTexto("verde oscuro");
            Console.Write("3 - ");

            Colores.EstablecerColorTexto("default");
            Console.WriteLine(
                "Registrar números del segundo cartón."
            );

            Colores.EstablecerColorTexto("amarillo");
            Console.Write("4 - ");

            Colores.EstablecerColorTexto("default");
            Console.WriteLine(
                "Mostrar los números de los cartones."
            );

            Colores.EstablecerColorTexto("rojo");
            Console.Write("5 - ");

            Console.WriteLine("Salir del modo de juego.\n");
        }


        public static String ControladorSalidaMenu(String respuesta)
        {
            do
            {
                Colores.EstablecerColorTexto("rojo");

                Console.Write(
                    "¿Realmente deseas salir del "
                    + "juego?\n\n"
                );

                Colores.EstablecerColorTexto("default");

                Console.Write("Ingresa una letra");

                Console.Write(" (");

                Colores.EstablecerColorTexto("rojo");
                Console.Write("s");

                Colores.EstablecerColorTexto("default");
                Console.Write(" / ");

                Colores.EstablecerColorTexto("verde oscuro");
                Console.Write("n");

                Colores.EstablecerColorTexto("default");
                Console.Write(")");

                Colores.EstablecerColorTexto("gris");
                Console.Write(": ");

                Colores.EstablecerColorTexto("default");

                // Lectura de la letra
                respuesta = Console.ReadLine();

                // Conversión de la cadena a miníscula
                respuesta = respuesta.ToLower();

                if (
                    respuesta != "s" &&
                    respuesta != "n"
                )
                {
                    Console.WriteLine(
                        "\n¡La letra es incorrecta! "
                        + "Intenta de nuevo.\n"
                    );

                    Console.Write(
                        "Presione una tecla para continuar... "
                    );

                    Console.ReadKey(true);
                    Console.Clear();
                }

            } while (
                    respuesta != "s" &&
                    respuesta != "n"
            );

            return respuesta;
        }

        public static Boolean EsValidaSegundaOpcionMenu(String opcion)
        {
            if (
                opcion != "1" &&
                opcion != "2" &&
                opcion != "3" &&
                opcion != "4" &&
                opcion != "5"
            )
                return false;
            else
                return true;
        }

        public static String MostrarModoDeJuego(String opcion)
        {
            if (opcion == "1")
            {
                return "solitario";
            }

            else if (opcion == "2")
            {
                return "con dos cartones";
            }

            else
            {
                return "";
            }
        }

        public static void MostrarMensajeModoDeJuego(
            String opcion,
            String modoJuego,
            Int32 totalJugadores
        )
        {
            MostrarMensajeComunBingo();

            String tiempo = "";

            // Mostrando la hora, minutos y el
            // estado de la hora actual (a. m. | p. m-)
            Menu.MostrarHora(tiempo);

            Colores.EstablecerColorTexto("default");
            Console.Write("\n\n- Modo de juego: ");

            Colores.EstablecerColorTexto("amarillo");
            Console.Write("{ ");

            Colores.EstablecerColorTexto("default");
            Console.Write(modoJuego);

            Colores.EstablecerColorTexto("amarillo");
            Console.WriteLine(" }");

            Colores.EstablecerColorTexto("default");
            Console.Write("- Jugadores: ");

            Colores.EstablecerColorTexto("magenta");
            Console.Write("{ ");

            Colores.EstablecerColorTexto("default");
            Console.Write(totalJugadores);

            Colores.EstablecerColorTexto("magenta");
            Console.WriteLine(" }\n");

            Colores.EstablecerColorTexto("default");
        }
    }

    // Clase Jugador
    public static class Jugador
    {
        public static Int32 partidasGanadas;
        public static String nickname = "";

        public static Boolean EsValidoNickname(String nicknameJugador)
        {
            if (nicknameJugador.Length < 2 || nicknameJugador.Length > 20)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }

    // Clase Cartón
    public static class Carton
    {
        public static Int32[,] cartonUno = new Int32[3, 3];
        public static Int32[,] cartonDos = new Int32[3, 3];

        private static Boolean EsValidoElNumero(Int32 numero)
        {
            if (numero > 0 && numero <= 45)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private static Boolean ElNumeroIngresadoSeRepite(
            Int32[,] carton,
            Int32 numero
        )
        {
            for (Int32 i = 0; i < 3; i++)
                for (Int32 j = 0; j < 3; j++)
                    if (numero == carton[i, j])
                        return true;

            return false;
        }

        private static void MensajeRegistrarCarton(
            String nickname,
            String opcion = "2"
        )
        {
            String respuesta = "primer";

            if (opcion == "3")
                respuesta = "segundo";

            Console.Write(
                nickname
                + ", vas a registrar el "
            );

            Colores.EstablecerColorTexto("cian");
            Console.Write(respuesta + " cartón");

            Colores.EstablecerColorTexto("default");
            Console.Write(
                ". El cartón,\n"
                + "cuenta con "
            );

            Colores.EstablecerColorTexto("gris");
            Console.Write("( ");

            Colores.EstablecerColorTexto("verde");
            Console.Write("3 ");

            Colores.EstablecerColorTexto("default");
            Console.Write("filas y ");

            Colores.EstablecerColorTexto("verde");
            Console.Write("3 ");

            Colores.EstablecerColorTexto("default");
            Console.Write(
                "columnas "
            );

            Colores.EstablecerColorTexto("gris");
            Console.Write(")");

            Colores.EstablecerColorTexto("default");
            Console.WriteLine(".\n");
        }

        // Se utiliza al momento de mostrar los números
        // del cartón cuando se procede a registrar manualmente
        private static String ObtenerNumeroCartonRegistroManual(
            Int32[,] carton,
            Int32 fila,
            Int32 columna
        )
        {
            if (carton[fila, columna] == 0)
            {
                return "";
            }

            else
            {
                return carton[fila, columna].ToString();
            }
        }

        private static String ObtenerSaltoDeLineaMostrarNumerosRegistrados(
            Int32[,] carton,
            String saltoDeLinea,
            Int32 totalNumerosRegistrados
        )
        {
            String[] numerosCarton = {
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0"
            };

            saltoDeLinea = "";

            // Comprobando el total de números registrados
            if (totalNumerosRegistrados > 0)
            {
                saltoDeLinea = "\n";

                // Estableciendo valores a los 3 números 3 de la fila 1
                numerosCarton[0] = ObtenerNumeroCartonRegistroManual(
                        carton,
                        0,
                        0
                    );

                numerosCarton[1] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    0,
                    1
                );

                numerosCarton[2] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    0,
                    2
                );

                // Estableciendo valores a los 3 números 3 de la fila 2

                numerosCarton[3] = ObtenerNumeroCartonRegistroManual(
                        carton,
                        1,
                        0
                    );

                numerosCarton[4] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    1,
                    1
                );

                numerosCarton[5] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    1,
                    2
                );

                // Estableciendo valores a los 3 números 3 de la fila 3

                numerosCarton[6] = ObtenerNumeroCartonRegistroManual(
                        carton,
                        2,
                        0
                    );

                numerosCarton[7] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    2,
                    1
                );

                numerosCarton[8] = ObtenerNumeroCartonRegistroManual(
                    carton,
                    2,
                    2
                );

                String[] colores =
                {
                    "azul",
                    "amarillo oscuro",
                    "cian",
                    "verde",
                    "rojo",
                    "amarillo",
                    "magenta"
                };

                Console.WriteLine("Números registrados:\n");

                Colores.EstablecerColorTexto("gris");

                if (totalNumerosRegistrados < 4)
                {
                    Console.Write(
                        numerosCarton[0] + "\t"
                        + numerosCarton[1] + "\t"
                        + numerosCarton[2]
                    );
                }

                if (totalNumerosRegistrados > 3 && totalNumerosRegistrados < 7)
                {
                    Console.Write(
                        numerosCarton[0] + "\t"
                        + numerosCarton[1] + "\t"
                        + numerosCarton[2]
                    );

                    Console.WriteLine("\n");

                    Console.Write(
                        numerosCarton[3] + "\t"
                        + numerosCarton[4] + "\t"
                        + numerosCarton[5]
                    );
                }

                if (totalNumerosRegistrados > 6 && totalNumerosRegistrados < 10)
                {
                    Console.Write(
                        numerosCarton[0] + "\t"
                        + numerosCarton[1] + "\t"
                        + numerosCarton[2]
                    );

                    Console.WriteLine("\n");

                    Console.Write(
                        numerosCarton[3] + "\t"
                        + numerosCarton[4] + "\t"
                        + numerosCarton[5]
                    );

                    Console.WriteLine("\n");

                    Console.Write(
                        numerosCarton[6] + "\t"
                        + numerosCarton[7] + "\t"
                        + numerosCarton[8]
                    );
                }

                Console.WriteLine("");
            }

            return saltoDeLinea;
        }

        public static Int32[,] RegistrarNumerosCartonIngresados(
            Int32[,] carton,
            Int32[,] cartonDos,
            String nickname,
            String opcionUno,
            String opcionDos,
            String modoJuego,
            Int32 totalJugadores,
            Boolean seRegistroCarton = false
        )
        {
            Int32 numero = 0, totalNumerosRegistrados = 0;
            Boolean bandera = false;

            if (!seRegistroCarton)
            {
                for (Int32 i = 0; i < 3; i++)
                {
                    for (Int32 j = 0; j < 4; j++)
                    {
                        do
                        {
                            Console.Clear();

                            Menu.MostrarMensajeModoDeJuego(
                                opcionUno,
                                modoJuego,
                                totalJugadores
                            );

                            MensajeRegistrarCarton(nickname, opcionDos);

                            String saltoDeLinea = "";

                            saltoDeLinea = ObtenerSaltoDeLineaMostrarNumerosRegistrados(
                                carton,
                                saltoDeLinea,
                                totalNumerosRegistrados
                            );

                            Colores.EstablecerColorTexto("gris");

                            if (j < 3)
                            {
                                Console.Write(
                                    saltoDeLinea
                                    + "Ingresa un número entre "
                                );

                                Colores.EstablecerColorTexto("verde");
                                Console.Write("(");

                                Colores.EstablecerColorTexto("default");
                                Console.Write("1 ");

                                Colores.EstablecerColorTexto("gris");
                                Console.Write("y ");

                                Colores.EstablecerColorTexto("default");
                                Console.Write("45");

                                Colores.EstablecerColorTexto("verde");
                                Console.Write(")");

                                Colores.EstablecerColorTexto("gris");
                                Console.Write(": ");

                                Colores.EstablecerColorTexto("default");

                                // Lectura del número
                                numero = Convert.ToInt32(Console.ReadLine());

                                bandera = ElNumeroIngresadoSeRepite(
                                    carton,
                                    numero
                                );

                                if (
                                    !EsValidoElNumero(numero) ||
                                    bandera
                                )
                                {
                                    Colores.EstablecerColorTexto("rojo");

                                    if (!EsValidoElNumero(numero))
                                    {
                                        Console.WriteLine("\n¡Error! Número fuera de rango.\n");
                                    }

                                    else
                                    {
                                        Console.WriteLine(
                                            "\n¡Error! El número ya está en el cartón.\n"
                                        );
                                    }

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write("Presione una tecla para reintentar... ");
                                    Console.ReadKey(true);

                                    Console.Clear();
                                }

                                else
                                {
                                    carton[i, j] = numero;
                                    totalNumerosRegistrados++;
                                }
                            }

                        } while (
                            !EsValidoElNumero(numero) ||
                            bandera
                        );
                    }
                }
            }

            else
            {
                Boolean sonIguales = false;

                do
                {
                    for (Int32 i = 0; i < 3; i++)
                    {
                        for (Int32 j = 0; j < 4; j++)
                        {
                            do
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    opcionUno,
                                    modoJuego,
                                    totalJugadores
                                );

                                MensajeRegistrarCarton(nickname, opcionDos);

                                String saltoDeLinea = "";

                                saltoDeLinea = ObtenerSaltoDeLineaMostrarNumerosRegistrados(
                                    carton,
                                    saltoDeLinea,
                                    totalNumerosRegistrados
                                );

                                Colores.EstablecerColorTexto("gris");

                                if (j < 3)
                                {
                                    Console.Write(
                                        saltoDeLinea
                                        + "Ingresa un número entre "
                                    );

                                    Colores.EstablecerColorTexto("verde");
                                    Console.Write("(");

                                    Colores.EstablecerColorTexto("default");
                                    Console.Write("1 ");

                                    Colores.EstablecerColorTexto("gris");
                                    Console.Write("y ");

                                    Colores.EstablecerColorTexto("default");
                                    Console.Write("45");

                                    Colores.EstablecerColorTexto("verde");
                                    Console.Write("): ");

                                    Colores.EstablecerColorTexto("default");

                                    // Lectura del número
                                    numero = Convert.ToInt32(Console.ReadLine());

                                    bandera = ElNumeroIngresadoSeRepite(
                                        carton,
                                        numero
                                    );

                                    if (
                                        !EsValidoElNumero(numero) ||
                                        bandera
                                    )
                                    {
                                        Colores.EstablecerColorTexto("rojo");

                                        if (!EsValidoElNumero(numero))
                                        {
                                            Console.WriteLine("\n¡Error! Número fuera de rango.\n");
                                        }

                                        else
                                        {
                                            Console.WriteLine(
                                                "\n¡Error! El número ya está en el cartón.\n"
                                            );
                                        }

                                        Colores.EstablecerColorTexto("default");

                                        Console.Write("Presione una tecla para reintentar... ");
                                        Console.ReadKey(true);

                                        Console.Clear();
                                    }

                                    else
                                    {
                                        carton[i, j] = numero;
                                        totalNumerosRegistrados++;
                                    }
                                }

                            } while (
                                !EsValidoElNumero(numero) ||
                                bandera
                            );
                        }
                    }

                    sonIguales = false;
                    Int32 contadorRepetidos = 0;

                    // Verificar si los dos cartones son iguales
                    for (Int32 i = 0; i < 3; i++)
                        for (Int32 j = 0; j < 3; j++)
                            if (carton[i, j] == cartonDos[i, j])
                                contadorRepetidos++;

                    if (contadorRepetidos == 9)
                    {
                        sonIguales = true;

                        // Establecer valores en cero
                        for (Int32 i = 0; i < 3; i++)
                            for (Int32 j = 0; j < 3; j++)
                                carton[i, j] = 0;

                        totalNumerosRegistrados = 0;
                    }

                    if (sonIguales)
                    {
                        Colores.EstablecerColorTexto("rojo");

                        Console.WriteLine(
                            "\n¡Error! Ambos cartones son "
                            + "iguales. Intenta de nuevo.\n"
                        );

                        Colores.EstablecerColorTexto("default");

                        Console.Write("Presione una tecla para reintentar... ");
                        Console.ReadKey(true);

                        Console.Clear();
                    }

                } while (sonIguales);

            } // Fin verificar si el segundo cartón es igual al primero

            return carton;
        }

        private static Int32 ObtenerNumeroAleatorio(Int32 minimo, Int32 maximo)
        {
            Random random = new Random();

            return random.Next(minimo, maximo + 1);
        }

        private static Boolean ElNumeroAleatorioSeRepite(
            Int32[,] carton,
            Int32 numeroAleatorio
        )
        {
            for (Int32 i = 0; i < 3; i++)
            {
                for (Int32 j = 0; j < 3; j++)
                {
                    if (numeroAleatorio == carton[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static Int32[,] RegistrarNumerosCartonAleatoriamente(
            Int32[,] carton,
            Int32[,] cartonDos,
            Boolean seRegistroCarton = false
        )
        {
            if (!seRegistroCarton)
            {
                for (Int32 i = 0; i < 3; i++)
                {
                    for (Int32 j = 0; j < 3; j++)
                    {
                        Int32 numeroAleatorio = ObtenerNumeroAleatorio(1, 45);

                        while (ElNumeroAleatorioSeRepite(
                                carton,
                                numeroAleatorio
                            )
                        )
                        {
                            numeroAleatorio = ObtenerNumeroAleatorio(1, 45);
                        }

                        carton[i, j] = numeroAleatorio;
                    }
                }
            }

            else
            {
                Boolean sonIguales = false;

                do
                {
                    for (Int32 i = 0; i < 3; i++)
                    {
                        for (Int32 j = 0; j < 3; j++)
                        {
                            Int32 numeroAleatorio = ObtenerNumeroAleatorio(1, 45);

                            while (ElNumeroAleatorioSeRepite(
                                    carton,
                                    numeroAleatorio
                                )
                            )
                            {
                                numeroAleatorio = ObtenerNumeroAleatorio(1, 45);
                            }

                            carton[i, j] = numeroAleatorio;
                        }
                    }

                    Int32 contadorRepetidos = 0;

                    // Verificar si los dos cartones son iguales
                    for (Int32 k = 0; k < 3; k++)
                    {
                        for (Int32 m = 0; m < 3; m++)
                        {
                            if (carton[k, m] == cartonDos[k, m])
                            {
                                contadorRepetidos++;
                            }
                        }
                    }

                    if (contadorRepetidos == 9)
                    {
                        sonIguales = true;
                    }

                    if (sonIguales)
                    {
                        for (Int32 i = 0; i < 3; i++)
                            for (Int32 j = 0; j < 3; j++)
                                carton[i, j] = 0;
                    }

                } while (sonIguales);
            }

            return carton;
        }

        public static void ImprimirLosCartones(
            Int32[,] cartonUno,
            Int32[,] cartonDos,
            Boolean seRegistroPrimerCarton = false,
            Boolean seRegistroSegundoCarton = false
        )
        {
            if (seRegistroPrimerCarton && seRegistroSegundoCarton)
            {
                Int32 i = 0, j = 0;

                String[] colores =
                {
                    "azul",
                    "cian",
                    "verde",
                    "rojo",
                    "amarillo",
                    "magenta",
                    "cian oscuro",
                    "verde oscuro"
                };

                Int32 colorAleatorio = ObtenerNumeroAleatorio(0, colores.Length - 1);

                Console.WriteLine("\n- Primer cartón:\n");

                Colores.EstablecerColorTexto(colores[colorAleatorio]);

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(cartonUno[i, j] + "\t");
                    }

                    Console.WriteLine("\n");
                }

                Colores.EstablecerColorTexto("default");

                Console.WriteLine("\n- Segundo cartón:\n");

                colorAleatorio = ObtenerNumeroAleatorio(0, colores.Length - 1);
                Colores.EstablecerColorTexto(colores[colorAleatorio]);

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(cartonDos[i, j] + "\t");
                    }

                    Console.WriteLine("\n");
                }
                
                Colores.EstablecerColorTexto("default");
                Console.WriteLine("");
            }

            else if (
                seRegistroPrimerCarton &&
                !seRegistroSegundoCarton
            )
            {
                Colores.EstablecerColorTexto("amarillo");

                Console.WriteLine(
                    "No has registrado el segundo "
                    + "cartón.\n"
                );
            }

            else if (
                !seRegistroPrimerCarton &&
                seRegistroSegundoCarton
            )
            {
                Colores.EstablecerColorTexto("amarillo");

                Console.WriteLine(
                    "No has registrado el primer "
                    + "cartón.\n"
                );
            }

            else
            {
                Colores.EstablecerColorTexto("amarillo");

                Console.WriteLine(
                    "No has registrado ninguno de los "
                    + "cartones.\n"
                );
            }

            Colores.EstablecerColorTexto("default");
        }

        private static Int32[,] EstablecerValoresPorDefecto(Int32[,] carton)
        {
            for (Int32 i = 0; i < 3; i++)
            {
                for (Int32 j = 0; j < 3; j++)
                {
                    carton[i, j] = 0;
                }
            }

            return carton;
        }
        
        public static void RestablecerValoresPorDefecto()
        {
            cartonUno = EstablecerValoresPorDefecto(cartonUno);
            cartonDos = EstablecerValoresPorDefecto(cartonDos);
        }
    }

    // Clase Juego
    public static class Juego
    {
        public static Int32[] numerosCantados;
        public static Int32 totalJugadores, partidasJugadas;

        private static Int32 ObtenerNumeroAleatorio(Int32 minimo, Int32 maximo)
        {
            Random random = new Random();

            return random.Next(minimo, maximo + 1);
        }

        public static void AsignarLimiteNumerosCantados(String modoJuego)
        {
            if (modoJuego == "1")
                numerosCantados = new Int32[15];
            else if (modoJuego == "2")
                numerosCantados = new Int32[20];
        }

        public static Int32[] RegistrarNumerosCantadosXD()
        {
            for (int i = 0; i < numerosCantados.Length; i++)
            {
                Console.Write($"\n{i + 1}. Número cantado: ");
                numerosCantados[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numerosCantados;
        }

        public static Int32[] RegistrarNumerosACantar()
        {
            Int32 i = 0;

            while (i < numerosCantados.Length)
            {
                Int32 numeroAleatorio = ObtenerNumeroAleatorio(1, 45);

                Boolean bandera = true;

                // Comprobando si está repetido
                for (Int32 j = 0; j < i; j++)
                {
                    if (numerosCantados[j] == numeroAleatorio)
                    {
                        bandera = false;
                    }
                }

                if (bandera)
                {
                    numerosCantados[i] = numeroAleatorio;

                    i++;
                }
            }

            return numerosCantados;
        }

        public static void Jugar(
            Int32[] numeros,
            String opcion
        )
        {
            Boolean ganoPrimerCarton = false;
            Boolean ganoSegundoCarton = false;
            Int32 i = 0;

            // Estableciendo valor y determina si ganó o no el cartón
            ganoPrimerCarton = Juego.HuboUnCartonGanador(
                Carton.cartonUno,
                numerosCantados
            );

            ganoSegundoCarton = Juego.HuboUnCartonGanador(
                Carton.cartonDos,
                numerosCantados
            );

            while (i < numerosCantados.Length)
            {
                // Mostrando alguna información del modo de juego
                Menu.MostrarMensajeModoDeJuego(
                    opcion,
                    Menu.MostrarModoDeJuego(opcion),
                    Juego.totalJugadores
                );

                Colores.EstablecerColorTexto("cian");
                Console.WriteLine(
                    Jugador.nickname
                    + ", ¡La partida ha comenzado!\n"
                );

                Colores.EstablecerColorTexto("default");
                Console.Write("Se cantó el número: ");

                Colores.EstablecerColorTexto("gris");
                Console.Write("{ ");

                Colores.EstablecerColorTexto("cian");
                Console.Write(numeros[i]);

                Colores.EstablecerColorTexto("gris");
                Console.WriteLine(" }");

                Colores.EstablecerColorTexto("default");
                Console.Write(
                    "Total de números cantados: "
                );

                Colores.EstablecerColorTexto("gris");
                Console.Write("{ ");

                Colores.EstablecerColorTexto("amarillo");
                Console.Write(i + 1);

                Colores.EstablecerColorTexto("gris");
                Console.WriteLine(" }");

                Colores.EstablecerColorTexto("amarillo");
                Console.WriteLine("\n\nNúmeros cantados:");

                // Imprimiendo los números cantados
                for (Int32 j = 0; j < i + 1; j++)
                {
                    if (j % 5 == 0)
                        Console.WriteLine("\n");

                    if (j % 2 == 0)
                        Colores.EstablecerColorTexto("gris");
                    else if (j % 2 == 1)
                        Colores.EstablecerColorTexto("blanco");

                    Console.Write(numeros[j] + "\t");
                }

                // Esperar un segundo para cantar un número
                Thread.Sleep(1000);

                i++;

                Console.Clear();
            }

            Colores.EstablecerColorTexto("gris");
            Console.WriteLine(
                "- - - - - - - - - - - - - - - "
                + " - - - - - - - - - - - - - - -\n\n"
            );

            Colores.EstablecerColorTexto("default");

            // Imprimiendo números de los cartones
            Carton.ImprimirLosCartones(
                Carton.cartonUno,
                Carton.cartonDos,
                true,
                true
            );

            // Cuando el modo de juego es en solitario
            if (opcion == "1")
            {
                Colores.EstablecerColorTexto("gris");
                Console.WriteLine(
                    "- - - - - - - - - - - - - - - "
                    + " - - - - - - - - - - - - - - -\n"
                );

                if (ganoPrimerCarton && !ganoSegundoCarton)
                {
                    Colores.EstablecerColorTexto("amarillo");

                    Console.Write(
                        "¡G A N A S T E! :D Comprueba tu cartón\n"
                    );

                    Jugador.partidasGanadas++;
                }

                else if (ganoSegundoCarton && !ganoPrimerCarton)
                {
                    Colores.EstablecerColorTexto("rojo");

                    Console.Write(
                        "¡Perdiste la partida! :( Por seguridad, "
                        + "comprueba ambos cartones\n"
                    );
                }

                else
                {
                    Colores.EstablecerColorTexto("rojo");

                    Console.Write(
                        "¡No hubo ningún ganador! :( Puedes jugar "
                        + "nuevamente\n"
                    );
                }
            }

            // Cuando el modo de juego es contra la CPU
            if (opcion == "2")
            {
                Colores.EstablecerColorTexto("gris");
                Console.WriteLine(
                    "- - - - - - - - - - - - - - - "
                    + " - - - - - - - - - - - - - - -\n"
                );

                if (ganoPrimerCarton && !ganoSegundoCarton)
                {
                    Colores.EstablecerColorTexto("amarillo");

                    Console.Write(
                        "¡G A N A S T E! :D Comprueba el primer "
                        + "cartón\n"
                    );

                    Jugador.partidasGanadas++;
                }

                else if (ganoSegundoCarton && !ganoPrimerCarton)
                {
                    Colores.EstablecerColorTexto("amarillo");

                    Console.Write(
                        "¡G A N A S T E! :D Comprueba el segundo "
                        + "cartón\n"
                    );

                    Jugador.partidasGanadas++;
                }

                else
                {
                    Colores.EstablecerColorTexto("rojo");

                    Console.Write(
                        "¡Perdiste la partida! :( Puedes jugar "
                        + "nuevamente\n"
                    );
                }
            }

            Colores.EstablecerColorTexto("blanco");

            Console.Write(
                "\nPresione una tecla para regresar"
                + " al menú principal... "
            );

            Console.ReadKey(true);
        }

        public static Boolean HuboUnCartonGanador(
            Int32[,] carton,
            Int32[] numerosCantados
        )
        {
            // Verificar si gano
            for (Int32 i = 0; i < 3; i++)
            {
                for (Int32 j = 0; j < 3; j++)
                {
                    for (Int32 k = 0; k < numerosCantados.Length; k++)
                    {
                        // - - Ganar con las columnas - -

                        // Ganando con la primera columna
                        if (i == 0 && j < 3 && k < numerosCantados.Length - 2)
                        {
                            if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[0, 1] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // Ganando con la segunda columna
                        else if (i == 1 && j < 3 && k < numerosCantados.Length - 2)
                        {
                            if (
                                carton[1, 0] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // Ganando con la tercera columna
                        else if (i == 2 && j < 3 && k < numerosCantados.Length - 2)
                        {
                            if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[2, 1] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // - - Ganando con las filas - -

                        // Ganando con la primera fila, col 1
                        if (
                            i < 3 &&
                            j == 0 &
                            k < numerosCantados.Length - 2
                        )
                        {
                            if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[1, 0] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // Ganando con la primera fila, col 2
                        else if (
                            i < 3 &&
                            j == 1 &&
                            k < numerosCantados.Length - 2
                        )
                        {
                            if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[2, 1] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // Ganando con la primera fila, col 3
                        else if (
                            i < 3 &&
                            j == 2 &&
                            k < numerosCantados.Length - 2
                        )
                        {
                            if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[1, 2] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // - - Ganando con la diagonales - -

                        // Ganando con la diagonal, izq
                        if (
                            i < 3 &&
                            j < 3 &&
                            k < numerosCantados.Length - 2
                        )
                        {
                            if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }

                            // Inversa
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // Ganando con la diagonal, dere
                        if (
                            i < 3 &&
                            j < 3 &&
                            k < numerosCantados.Length - 2
                        )
                        {
                            if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }

                            // Inversa
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[1, 1] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2]
                            )
                            {
                                return true;
                            }
                        }

                        // - - Ganando con las esquinas - -
                        if (
                            i < 3 &&
                            j < 3 &&
                            k < numerosCantados.Length - 3
                        )
                        {
                            // Cuando el primer número está en la fila 1, columna 1

                            //                  ( 1 )
                            // De arriba izquierda hacia la derecha arriba,
                            // de arriba derecha, hacia la izquierda abajo,
                            // de abajo izquierda, hacia la derecha abajo
                            if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 2 )
                            // De arriba izquierda hacia la derecha arriba,
                            // de arriba derecha, hacia la derecha abajo,
                            // de abajo derecha, hacia abajo izquierda
                            else if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 3 )
                            // De arriba izquierda hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba derecha,
                            // de arriba derecha, hacia la abajo derecha
                            else if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 4 )
                            // De arriba izquierda hacia abajo izquierda,
                            // de abajo izquierda, hacia abajo derecha,
                            // de abajo derecha, hacia arriba derecha
                            else if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[2, 0] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 5 )
                            // De arriba izquierda hacia abajo derecha,
                            // de abajo derecha, hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba derecha
                            else if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 6 )
                            // De arriba izquierda hacia abajo derecha,
                            // de abajo derecha, hacia arriba derecha,
                            // de arriba derecha, hacia abajo izquierda
                            else if (
                                carton[0, 0] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // Cuando el primer número está en la fila 1, columna 3

                            //                  ( 1 )
                            // De arriba derecha hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo izquierda,
                            // de abajo izquierda, hacia abajo derecha
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 2 )
                            // De arriba derecha hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo derecha,
                            // de abajo derecha, hacia abajo izquierda
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 3 )
                            // De arriba derecha hacia abajo derecha,
                            // de abajo derecha, hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo izquierda
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 4 )
                            // De arriba derecha hacia abajo derecha,
                            // de abajo derecha, hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba izquierda
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[0, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 5 )
                            // De arriba derecha hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo derecha
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[2, 0] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 6 )
                            // De arriba derecha hacia abajo izquierda,
                            // de abajo izquierda, hacia abajo derecha,
                            // de abajo derecha, hacia arriba izquierda
                            else if (
                                carton[0, 2] == numerosCantados[k] &&
                                carton[2, 0] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // Cuando el primer número está en la fila 3, columna 1

                            //                  ( 1 )
                            // De abajo izquierda hacia arriba izquierda,
                            // de arriba izquierda, hacia arriba derecha,
                            // de arriba derecha, hacia abajo derecha
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 2 )
                            // De abajo izquierda hacia abajo derecha,
                            // de abajo derecha, hacia arriba izquierda,
                            // de arriba izquierda, hacia arriba derecha
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 3 )
                            // De abajo izquierda hacia arriba derecha,
                            // de arriba derecha, hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo derecha
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[2, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 4 )
                            // De abajo izquierda hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo derecha,
                            // de abajo derecha, hacia arriba derecha
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 5 )
                            // De abajo izquierda hacia abajo derecha,
                            // de abajo derecha, hacia arriba derecha,
                            // de arriba derecha, hacia arriba izquierda
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[2, 2] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2] &&
                                carton[0, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 6 )
                            // De abajo izquierda hacia arriba derecha,
                            // de arriba derecha, hacia abajo derecha,
                            // de abajo derecha, hacia arriba izquierda
                            else if (
                                carton[2, 0] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[2, 2] == numerosCantados[k + 2] &&
                                carton[0, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // Cuando el primer número está en la fila 3, columna 3

                            //                  ( 1 )
                            // De abajo derecha hacia la izquierda abajo,
                            // de abajo izquierda, hacia arriba derecha,
                            // de arriba derecha, hacia arriba izquierda
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[2, 0] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2] &&
                                carton[0, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 2 )
                            // De abajo derecha hacia la izquierda abajo,
                            // de abajo izquierda, hacia arriba izquierda,
                            // de arriba izquierda, hacia arriba derecha
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[2, 0] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 3 )
                            // De abajo derecha hacia arriba derecha,
                            // de arriba derecha, hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo izquierda
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[0, 0] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 4 )
                            // De abajo derecha hacia arriba derecha,
                            // de arriba derecha, hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba izquierda
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[0, 2] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[0, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 5 )
                            // De abajo derecha hacia arriba izquierda,
                            // de arriba izquierda, hacia arriba derecha,
                            // de arriba derecha, hacia abajo izquierda
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[0, 2] == numerosCantados[k + 2] &&
                                carton[2, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //                  ( 6 )
                            // De abajo derecha hacia arriba izquierda,
                            // de arriba izquierda, hacia abajo izquierda,
                            // de abajo izquierda, hacia arriba derecha
                            else if (
                                carton[2, 2] == numerosCantados[k] &&
                                carton[0, 0] == numerosCantados[k + 1] &&
                                carton[2, 0] == numerosCantados[k + 2] &&
                                carton[0, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }
                        }

                        //  - - Ganando en forma de diamante - -
                        if (
                            i < 3 &&
                            j < 3 &&
                            k < numerosCantados.Length - 3
                        )
                        {
                            // - - Común, de izquierda a derecha - -

                            // (1) [ Fila 1 - Columna 2 ]
                            if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[1, 0] == numerosCantados[k + 1] &&
                                carton[2, 1] == numerosCantados[k + 2] &&
                                carton[1, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (2) [ Fila 2 - Columna 1 ]
                            if (
                                carton[1, 0] == numerosCantados[k] &&
                                carton[2, 1] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2] &&
                                carton[0, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (3) [ Fila 3 - Columna 2 ]
                            else if (
                                carton[2, 1] == numerosCantados[k] &&
                                carton[1, 2] == numerosCantados[k + 1] &&
                                carton[0, 1] == numerosCantados[k + 2] &&
                                carton[1, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (4) [ Fila 2 - Columna 3 ]
                            else if (
                                carton[1, 2] == numerosCantados[k] &&
                                carton[0, 1] == numerosCantados[k + 1] &&
                                carton[1, 0] == numerosCantados[k + 2] &&
                                carton[2, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //  - - Inversa, de derecha a izquierda - -

                            // (1) [ Fila 1 - Columna 2 ]
                            else if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[1, 2] == numerosCantados[k + 1] &&
                                carton[2, 1] == numerosCantados[k + 2] &&
                                carton[1, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (2) [ Fila 2 - Columna 3 ]
                            else if (
                                carton[1, 2] == numerosCantados[k] &&
                                carton[2, 1] == numerosCantados[k + 1] &&
                                carton[1, 0] == numerosCantados[k + 2] &&
                                carton[0, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (3) [ Fila 3 - Columna 2 ]
                            else if (
                                carton[2, 1] == numerosCantados[k] &&
                                carton[1, 0] == numerosCantados[k + 1] &&
                                carton[0, 1] == numerosCantados[k + 2] &&
                                carton[1, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            // (4) [ Fila 2 - Columna 1 ]
                            else if (
                                carton[1, 0] == numerosCantados[k] &&
                                carton[0, 1] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2] &&
                                carton[2, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //  - - Común, de arriba hacia abajo, de izquierda a derecha - -

                            // (1) [ Fila 1 - Columna 1 ]
                            else if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[2, 1] == numerosCantados[k + 1] &&
                                carton[1, 0] == numerosCantados[k + 2] &&
                                carton[1, 2] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //  - - Común, de arriba hacia abajo, de derecha a izquierda - -

                            // (1) [ Fila 1 - Columna 1 ]
                            else if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[2, 1] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2] &&
                                carton[1, 0] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //  - - Común, de arriba hacia la izquierda, de izquierda a hacia la derecha, de derecha hacia abajo - -

                            // (1) [ Fila 1 - Columna 1 ]
                            else if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[1, 0] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2] &&
                                carton[2, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //  - - Común, de arriba hacia la derecha, de derecha a hacia la izquierda, de izquierda hacia abajo - -

                            // (1) [ Fila 1 - Columna 1 ]
                            else if (
                                carton[0, 1] == numerosCantados[k] &&
                                carton[1, 2] == numerosCantados[k + 1] &&
                                carton[1, 0] == numerosCantados[k + 2] &&
                                carton[2, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //   - - (C) De abajo hacia la izquierda,
                            //       de izquierda a hacia la derecha,
                            //        de derecha hacia arriba - -

                            // (1) [ Fila 3 - Columna 2 ]
                            else if (
                                carton[2, 1] == numerosCantados[k] &&
                                carton[1, 0] == numerosCantados[k + 1] &&
                                carton[1, 2] == numerosCantados[k + 2] &&
                                carton[0, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }

                            //   - - (C) De abajo hacia la derecha,
                            //       de derecha a hacia la izquierda,
                            //        de izquierda hacia arriba - -

                            // (1) [ Fila 3 - Columna 2 ]
                            else if (
                                carton[2, 1] == numerosCantados[k] &&
                                carton[1, 2] == numerosCantados[k + 1] &&
                                carton[1, 0] == numerosCantados[k + 2] &&
                                carton[0, 1] == numerosCantados[k + 3]
                            )
                            {
                                return true;
                            }
                        }

                    } // Fin del tercer bucle
                } // Fin del segundo bucle
            } // Fin del primer bucle

            return false;
        } // Fin del método

        public static void RestablecerValoresNumerosCantados()
        {
            for (Int32 i = 0; i < numerosCantados.Length; i++)
                numerosCantados[i] = 0;
        }
    }

    // Clase para establecer colores en los mensajes
    public static class Colores
    {
        public static void EstablecerColorTexto(
            String color = ""
        )
        {
            if (color != "")
            {
                color = color.Trim();
                color = color.ToLower();

                if (color == "azul")
                    Console.ForegroundColor = ConsoleColor.Blue;

                else if (color == "amarillo")
                    Console.ForegroundColor = ConsoleColor.Yellow;

                else if (color == "amarillo oscuro")
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                else if (color == "default" || color == "blanco")
                    Console.ForegroundColor = ConsoleColor.White;

                else if (color == "verde")
                    Console.ForegroundColor = ConsoleColor.Green;

                else if (color == "gris")
                    Console.ForegroundColor = ConsoleColor.Gray;

                else if (color == "magenta")
                    Console.ForegroundColor = ConsoleColor.Magenta;

                else if (color == "rojo")
                    Console.ForegroundColor = ConsoleColor.Red;

                else if (color == "rojo oscuro")
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                else if (color == "verde oscuro")
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                else if (color == "cian")
                    Console.ForegroundColor = ConsoleColor.Cyan;

                else if (color == "cian oscuro")
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            return;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            String formatoTiempo = "";
            String primeraOpcionMenu = "";
            String segundaOpcionMenu = "";
            String respuestaRegistroCartonUno = "";
            String respuestaRegistroCartonDos = "";
            String respuestaConfirmarSalida = "";
            Boolean seRegistroPrimerCarton = false;
            Boolean seRegistroSegundoCarton = false;
            // String opcionModoJuego = "";

            Console.Clear();

            // Validando el ingreso del nickname
            do
            {
                Menu.MostrarMensajeComunBingo();

                Console.Write("Bienvenido al juego de ");

                Colores.EstablecerColorTexto("gris");
                Console.Write("{ ");

                Colores.EstablecerColorTexto("magenta");
                Console.Write("B");

                Colores.EstablecerColorTexto("cian");
                Console.Write("i");

                Colores.EstablecerColorTexto("amarillo");
                Console.Write("n");

                Colores.EstablecerColorTexto("verde");
                Console.Write("g");

                Colores.EstablecerColorTexto("rojo");
                Console.Write("o");

                Colores.EstablecerColorTexto("gris");
                Console.WriteLine(" }\n");

                formatoTiempo = "";

                // Mostrando la hora, minutos y el
                // estado de la hora actual (a. m. | p. m.)
                Menu.MostrarHora(formatoTiempo);

                Colores.EstablecerColorTexto("gris");
                Console.Write("\n\nIngresa tu Nickname: ");

                Colores.EstablecerColorTexto("default");

                // Lectura del nickname
                Jugador.nickname = Console.ReadLine();

                if (!Jugador.EsValidoNickname(Jugador.nickname))
                {
                    Colores.EstablecerColorTexto("rojo");

                    Console.WriteLine(
                        "\n¡El nickname es incorrecto! Intente de nuevo.\n"
                    );

                    Colores.EstablecerColorTexto("default");

                    Console.Write(
                        "Presione una tecla para continuar... "
                    );

                    Console.ReadKey(true);
                    Console.Clear();
                }

                Console.Clear();

            } while (!Jugador.EsValidoNickname(Jugador.nickname));

            // Menu principal
            do
            {
                do
                {
                    Menu.MostrarMensajeComunBingo();

                    formatoTiempo = "";

                    // Mostrando la hora, minutos y el
                    // estado de la hora actual (a. m. | p. m.)
                    Menu.MostrarHora(formatoTiempo);

                    Console.WriteLine("\n\nMenú principal\n");

                    Colores.EstablecerColorTexto("cian");
                    Console.Write("1 - ");

                    Colores.EstablecerColorTexto("default");
                    Console.WriteLine("Jugar en solitario.");

                    Colores.EstablecerColorTexto("amarillo");
                    Console.Write("2 - ");

                    Colores.EstablecerColorTexto("default");
                    Console.WriteLine("Jugar con dos cartones.");

                    if (!Menu.todasLasOpciones)
                    {
                        Colores.EstablecerColorTexto("rojo");
                        Console.WriteLine("3 - Salir del juego.\n");
                    }

                    else
                    {
                        Colores.EstablecerColorTexto("magenta");
                        Console.WriteLine("3 - Partidas ganadas.");

                        Colores.EstablecerColorTexto("rojo");
                        Console.WriteLine("4 - Salir del juego.\n");
                    }

                    Colores.EstablecerColorTexto("gris");
                    Console.Write("Ingrese un número como opción: ");

                    Colores.EstablecerColorTexto("default");

                    // Lectura de la opción
                    primeraOpcionMenu = Console.ReadLine();

                    if (
                        !Menu.EsValidaPrimeraOpcionMenu(
                            primeraOpcionMenu,
                            Menu.todasLasOpciones
                        )
                    )
                    {
                        Colores.EstablecerColorTexto("rojo");

                        Console.WriteLine(
                            "\n¡La opción no es correcta! Intente de nuevo.\n"
                        );

                        Colores.EstablecerColorTexto("default");

                        Console.Write(
                            "Presione una tecla para continuar... "
                        );

                        Console.ReadKey(true);
                        Console.Clear();
                    }

                } while (
                    !Menu.EsValidaPrimeraOpcionMenu(
                        primeraOpcionMenu,
                        Menu.todasLasOpciones
                    )
                );

                Console.Clear();

                // Jugar en modo solitario
                if (primeraOpcionMenu == "1")
                {
                    Menu.todasLasOpciones = true;
                    Juego.totalJugadores = 1;
                    Juego.AsignarLimiteNumerosCantados("1");

                    //      - - Menu de opciones - -
                    do
                    {
                        // Validación de la opción a elegir
                        do
                        {
                            // Mostrando alguna información del modo de juego
                            Menu.MostrarMensajeModoDeJuego(
                                primeraOpcionMenu,
                                Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                Juego.totalJugadores
                            );

                            // Mostrando las opciones disponibles
                            Menu.MostrarOpcionesMenuPrincipal(Jugador.nickname);

                            Colores.EstablecerColorTexto("gris");

                            Console.Write("Ingrese un número como opción: ");

                            Colores.EstablecerColorTexto("default");

                            // Lectura de la opción
                            segundaOpcionMenu = Console.ReadLine();

                            if (
                                !Menu.EsValidaSegundaOpcionMenu(
                                    segundaOpcionMenu
                                )
                            )
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("rojo");

                                Console.WriteLine(
                                    "¡La opción no es correcta! "
                                    + "Intenta de nuevo.\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }

                        } while (
                            !Menu.EsValidaSegundaOpcionMenu(
                                segundaOpcionMenu
                            )
                        );

                        Console.Clear();

                        // Empezando el juego
                        if (segundaOpcionMenu == "1")
                        {
                            if (
                                seRegistroPrimerCarton &&
                                seRegistroSegundoCarton
                            )
                            {
                                //Juego.numerosCantados = Juego.RegistrarNumerosACantar();
                                Juego.numerosCantados = Juego.RegistrarNumerosCantadosXD();

                                // Iniciando partida
                                Juego.Jugar(
                                    Juego.numerosCantados,
                                    primeraOpcionMenu
                                );

                                // Indicando que los dos cartones no se han registrado
                                //seRegistroPrimerCarton = false;
                                //seRegistroSegundoCarton = false;

                                // Restablecer los valores por defecto a los cartones
                                Carton.RestablecerValoresPorDefecto();
                                Juego.RestablecerValoresNumerosCantados();

                                segundaOpcionMenu = "5";
                            }

                            else
                            {
                                Console.Clear();

                                // Mostrando alguna información del modo de juego
                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("cian");

                                Console.WriteLine(
                                    "No puedes jugar sin tener los dos\n"
                                    + "    cartones registrados.\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar"
                                    + " al menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "2")
                        {
                            if (!seRegistroPrimerCarton)
                            {
                                do
                                {
                                    // Mostrando alguna información del modo de juego
                                    Menu.MostrarMensajeModoDeJuego(
                                        primeraOpcionMenu,
                                        Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                        Juego.totalJugadores
                                    );

                                    Console.Write(
                                        "Opciones para registrar los números del "
                                        + "primer cartón:\n\n"
                                    );

                                    Colores.EstablecerColorTexto("verde oscuro");
                                    Console.WriteLine("1 - Manual.");

                                    Colores.EstablecerColorTexto("cian oscuro");
                                    Console.WriteLine("2 - Aleatoriamente.");

                                    Colores.EstablecerColorTexto("rojo");
                                    Console.WriteLine("3 - Mejor en otro momento.\n");

                                    Colores.EstablecerColorTexto("gris");

                                    Console.Write("Ingresa una opción: ");

                                    Colores.EstablecerColorTexto("default");

                                    // Lectura de la respuesta
                                    respuestaRegistroCartonUno = Console.ReadLine();

                                    if (
                                        respuestaRegistroCartonUno != "1" &&
                                        respuestaRegistroCartonUno != "2" &&
                                        respuestaRegistroCartonUno != "3"
                                    )
                                    {
                                        Console.Clear();

                                        Menu.MostrarMensajeModoDeJuego(
                                            primeraOpcionMenu,
                                            Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                            Juego.totalJugadores
                                        );

                                        Colores.EstablecerColorTexto("rojo");

                                        Console.WriteLine(
                                            "¡La opción no es correcta! "
                                            + "Intenta de nuevo.\n"
                                        );

                                        Colores.EstablecerColorTexto("default");

                                        Console.Write(
                                            "Presione una tecla para regresar"
                                            + " al menú principal... "
                                        );

                                        Console.ReadKey(true);
                                        Console.Clear();
                                    }

                                } while (
                                    respuestaRegistroCartonUno != "1" &&
                                    respuestaRegistroCartonUno != "2" &&
                                    respuestaRegistroCartonUno != "3"
                                );

                                if (respuestaRegistroCartonUno == "1")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroSegundoCarton)
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores
                                        );
                                    }

                                    // Ya se ha registrado el segundo cartón
                                    else
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores,
                                            true
                                        );
                                    }

                                    seRegistroPrimerCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el primer cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }

                                else if (respuestaRegistroCartonUno == "2")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroSegundoCarton)
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonUno,
                                            Carton.cartonDos
                                        );
                                    }

                                    // Ya se ha registrado el segundo cartón
                                    else
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            true
                                        );
                                    }

                                    seRegistroPrimerCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el primer cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            }

                            else
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("amarillo");

                                Console.WriteLine(
                                    "¡Ya registraste el primer cartón!\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "3")
                        {
                            if (!seRegistroSegundoCarton)
                            {
                                do
                                {
                                    // Mostrando alguna información del modo de juego
                                    Menu.MostrarMensajeModoDeJuego(
                                        primeraOpcionMenu,
                                        Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                        Juego.totalJugadores
                                    );

                                    Console.Write(
                                        "Opciones para registrar los números del "
                                        + "segundo cartón:\n\n"
                                    );

                                    Colores.EstablecerColorTexto("verde oscuro");
                                    Console.WriteLine("1 - Manual.");

                                    Colores.EstablecerColorTexto("cian oscuro");
                                    Console.WriteLine("2 - Aleatoriamente.");

                                    Colores.EstablecerColorTexto("rojo");
                                    Console.WriteLine("3 - Mejor en otro momento.\n");

                                    Colores.EstablecerColorTexto("gris");

                                    Console.Write("Ingresa una opción: ");

                                    Colores.EstablecerColorTexto("default");

                                    // Lectura de la respuesta
                                    respuestaRegistroCartonDos = Console.ReadLine();

                                    if (
                                        respuestaRegistroCartonDos != "1" &&
                                        respuestaRegistroCartonDos != "2" &&
                                        respuestaRegistroCartonDos != "3"
                                    )
                                    {
                                        Console.Clear();

                                        Menu.MostrarMensajeModoDeJuego(
                                            primeraOpcionMenu,
                                            Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                            Juego.totalJugadores
                                        );

                                        Colores.EstablecerColorTexto("rojo");

                                        Console.WriteLine(
                                            "\n¡La opción no es correcta! "
                                            + " Intenta de nuevo."
                                        );

                                        Colores.EstablecerColorTexto("default");

                                        Console.Write(
                                            "Presione una tecla para regresar al "
                                            + "menú principal... "
                                        );

                                        Console.ReadKey(true);
                                        Console.Clear();
                                    }

                                } while (
                                    respuestaRegistroCartonDos != "1" &&
                                    respuestaRegistroCartonDos != "2" &&
                                    respuestaRegistroCartonDos != "3"
                                );

                                if (respuestaRegistroCartonDos == "1")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroPrimerCarton)
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores
                                        );
                                    }

                                    // Ya se ha registrado el primer cartón
                                    else
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores,
                                            true
                                        );
                                    }

                                    seRegistroSegundoCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el segundo cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }

                                else if (respuestaRegistroCartonDos == "2")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroPrimerCarton)
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonDos,
                                            Carton.cartonUno
                                        );
                                    }

                                    // Ya se ha registrado el primer cartón
                                    else
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            true
                                        );
                                    }

                                    seRegistroSegundoCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el segundo cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            }

                            else
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("amarillo");

                                Console.WriteLine(
                                    "¡Ya registraste el segundo cartón!\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "4")
                        {
                            Console.Clear();

                            Menu.MostrarMensajeModoDeJuego(
                                primeraOpcionMenu,
                                Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                Juego.totalJugadores
                            );

                            // Si ambos cartones se ha registrado, se muestra el mensaje
                            if (seRegistroPrimerCarton && seRegistroSegundoCarton)
                            {
                                Colores.EstablecerColorTexto("cian");

                                Console.WriteLine(
                                    "\nEstos son los cartones que registraste:\n"
                                );

                                Colores.EstablecerColorTexto("default");
                            }

                            Carton.ImprimirLosCartones(
                                Carton.cartonUno,
                                Carton.cartonDos,
                                seRegistroPrimerCarton,
                                seRegistroSegundoCarton
                            );

                            Console.Write(
                                "Presione una tecla para regresar al "
                                + "menú principal... "
                            );

                            Console.ReadKey(true);
                            Console.Clear();
                        }

                        if (segundaOpcionMenu == "5")
                        {
                            // Indicando que los dos cartones no se han registrado
                            seRegistroPrimerCarton = false;
                            seRegistroSegundoCarton = false;

                            // Restablecer los valores por defecto a los cartones
                            Carton.RestablecerValoresPorDefecto();
                        }

                        Console.Clear();

                    } while (
                        Menu.ControladorSegundoMenu(
                            segundaOpcionMenu
                        )
                    );
                }

                if (primeraOpcionMenu == "2")
                {
                    Menu.todasLasOpciones = true;
                    Juego.totalJugadores = 1;
                    Juego.AsignarLimiteNumerosCantados("2");

                    //      - - Menu de opciones - -
                    do
                    {
                        // Validación de la opción a elegir
                        do
                        {
                            // Mostrando alguna información del modo de juego
                            Menu.MostrarMensajeModoDeJuego(
                                primeraOpcionMenu,
                                Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                Juego.totalJugadores
                            );

                            // Mostrando las opciones disponibles
                            Menu.MostrarOpcionesMenuPrincipal(Jugador.nickname);

                            Colores.EstablecerColorTexto("gris");

                            Console.Write("Ingrese un número como opción: ");

                            Colores.EstablecerColorTexto("default");

                            // Lectura de la opción
                            segundaOpcionMenu = Console.ReadLine();

                            if (
                                !Menu.EsValidaSegundaOpcionMenu(
                                    segundaOpcionMenu
                                )
                            )
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("rojo");

                                Console.WriteLine(
                                    "¡La opción no es correcta! "
                                    + "Intenta de nuevo.\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }

                        } while (
                            !Menu.EsValidaSegundaOpcionMenu(
                                segundaOpcionMenu
                            )
                        );

                        Console.Clear();

                        // Empezando el juego
                        if (segundaOpcionMenu == "1")
                        {
                            if (
                                seRegistroPrimerCarton &&
                                seRegistroSegundoCarton
                            )
                            {
                                //Juego.numerosCantados = Juego.RegistrarNumerosACantar();
                                Juego.numerosCantados = Juego.RegistrarNumerosCantadosXD();

                                // Iniciando partida
                                Juego.Jugar(
                                    Juego.numerosCantados,
                                    primeraOpcionMenu
                                );

                                // Indicando que los dos cartones no se han registrado
                                //seRegistroPrimerCarton = false;
                                //seRegistroSegundoCarton = false;

                                // Restablecer los valores por defecto a los cartones
                                Carton.RestablecerValoresPorDefecto();
                                Juego.RestablecerValoresNumerosCantados();

                                segundaOpcionMenu = "5";
                            }

                            else
                            {
                                Console.Clear();

                                // Mostrando alguna información del modo de juego
                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("cian");

                                Console.WriteLine(
                                    "No puedes jugar sin tener los dos\n"
                                    + "    cartones registrados.\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar"
                                    + " al menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "2")
                        {
                            if (!seRegistroPrimerCarton)
                            {
                                do
                                {
                                    // Mostrando alguna información del modo de juego
                                    Menu.MostrarMensajeModoDeJuego(
                                        primeraOpcionMenu,
                                        Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                        Juego.totalJugadores
                                    );

                                    Console.Write(
                                        "Opciones para registrar los números del "
                                        + "primer cartón:\n\n"
                                    );

                                    Colores.EstablecerColorTexto("verde oscuro");
                                    Console.WriteLine("1 - Manual.");

                                    Colores.EstablecerColorTexto("cian oscuro");
                                    Console.WriteLine("2 - Aleatoriamente.");

                                    Colores.EstablecerColorTexto("rojo");
                                    Console.WriteLine("3 - Mejor en otro momento.\n");

                                    Colores.EstablecerColorTexto("gris");

                                    Console.Write("Ingresa una opción: ");

                                    Colores.EstablecerColorTexto("default");

                                    // Lectura de la respuesta
                                    respuestaRegistroCartonUno = Console.ReadLine();

                                    if (
                                        respuestaRegistroCartonUno != "1" &&
                                        respuestaRegistroCartonUno != "2" &&
                                        respuestaRegistroCartonUno != "3"
                                    )
                                    {
                                        Console.Clear();

                                        Menu.MostrarMensajeModoDeJuego(
                                            primeraOpcionMenu,
                                            Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                            Juego.totalJugadores
                                        );

                                        Colores.EstablecerColorTexto("rojo");

                                        Console.WriteLine(
                                            "¡La opción no es correcta! "
                                            + "Intenta de nuevo.\n"
                                        );

                                        Colores.EstablecerColorTexto("default");

                                        Console.Write(
                                            "Presione una tecla para regresar"
                                            + " al menú principal... "
                                        );

                                        Console.ReadKey(true);
                                        Console.Clear();
                                    }

                                } while (
                                    respuestaRegistroCartonUno != "1" &&
                                    respuestaRegistroCartonUno != "2" &&
                                    respuestaRegistroCartonUno != "3"
                                );

                                if (respuestaRegistroCartonUno == "1")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroSegundoCarton)
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores
                                        );
                                    }

                                    // Ya se ha registrado el segundo cartón
                                    else
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores,
                                            true
                                        );
                                    }

                                    seRegistroPrimerCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el primer cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }

                                else if (respuestaRegistroCartonUno == "2")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroSegundoCarton)
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonUno,
                                            Carton.cartonDos
                                        );
                                    }

                                    // Ya se ha registrado el segundo cartón
                                    else
                                    {
                                        Carton.cartonUno = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonUno,
                                            Carton.cartonDos,
                                            true
                                        );
                                    }

                                    seRegistroPrimerCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el primer cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            }

                            else
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("amarillo");

                                Console.WriteLine(
                                    "¡Ya registraste el primer cartón!\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "3")
                        {
                            if (!seRegistroSegundoCarton)
                            {
                                do
                                {
                                    // Mostrando alguna información del modo de juego
                                    Menu.MostrarMensajeModoDeJuego(
                                        primeraOpcionMenu,
                                        Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                        Juego.totalJugadores
                                    );

                                    Console.Write(
                                        "Opciones para registrar los números del "
                                        + "segundo cartón:\n\n"
                                    );

                                    Colores.EstablecerColorTexto("verde oscuro");
                                    Console.WriteLine("1 - Manual.");

                                    Colores.EstablecerColorTexto("cian oscuro");
                                    Console.WriteLine("2 - Aleatoriamente.");

                                    Colores.EstablecerColorTexto("rojo");
                                    Console.WriteLine("3 - Mejor en otro momento.\n");

                                    Colores.EstablecerColorTexto("gris");

                                    Console.Write("Ingresa una opción: ");

                                    Colores.EstablecerColorTexto("default");

                                    // Lectura de la respuesta
                                    respuestaRegistroCartonDos = Console.ReadLine();

                                    if (
                                        respuestaRegistroCartonDos != "1" &&
                                        respuestaRegistroCartonDos != "2" &&
                                        respuestaRegistroCartonDos != "3"
                                    )
                                    {
                                        Console.Clear();

                                        Menu.MostrarMensajeModoDeJuego(
                                            primeraOpcionMenu,
                                            Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                            Juego.totalJugadores
                                        );

                                        Colores.EstablecerColorTexto("rojo");

                                        Console.WriteLine(
                                            "\n¡La opción no es correcta! "
                                            + " Intenta de nuevo."
                                        );

                                        Colores.EstablecerColorTexto("default");

                                        Console.Write(
                                            "Presione una tecla para regresar al "
                                            + "menú principal... "
                                        );

                                        Console.ReadKey(true);
                                        Console.Clear();
                                    }

                                } while (
                                    respuestaRegistroCartonDos != "1" &&
                                    respuestaRegistroCartonDos != "2" &&
                                    respuestaRegistroCartonDos != "3"
                                );

                                if (respuestaRegistroCartonDos == "1")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroPrimerCarton)
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores
                                        );
                                    }

                                    // Ya se ha registrado el primer cartón
                                    else
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonIngresados(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            Jugador.nickname,
                                            primeraOpcionMenu,
                                            segundaOpcionMenu,
                                            Menu.MostrarModoDeJuego(
                                                primeraOpcionMenu
                                            ),
                                            Juego.totalJugadores,
                                            true
                                        );
                                    }

                                    seRegistroSegundoCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el segundo cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }

                                else if (respuestaRegistroCartonDos == "2")
                                {
                                    // Comprobando si el cartón
                                    // se ha registrado. Ya si que si
                                    // es así, se procede a evaluar ambos
                                    // cartones para evitar que no se repitan
                                    if (!seRegistroPrimerCarton)
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonDos,
                                            Carton.cartonUno
                                        );
                                    }

                                    // Ya se ha registrado el primer cartón
                                    else
                                    {
                                        Carton.cartonDos = Carton.RegistrarNumerosCartonAleatoriamente(
                                            Carton.cartonDos,
                                            Carton.cartonUno,
                                            true
                                        );
                                    }

                                    seRegistroSegundoCarton = true;

                                    Colores.EstablecerColorTexto("verde");

                                    Console.WriteLine(
                                        "\n¡Has registrado el segundo cartón!\n"
                                    );

                                    Colores.EstablecerColorTexto("default");

                                    Console.Write(
                                        "Presione una tecla para regresar al "
                                        + "menú principal... "
                                    );

                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            }

                            else
                            {
                                Console.Clear();

                                Menu.MostrarMensajeModoDeJuego(
                                    primeraOpcionMenu,
                                    Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                    Juego.totalJugadores
                                );

                                Colores.EstablecerColorTexto("amarillo");

                                Console.WriteLine(
                                    "¡Ya registraste el segundo cartón!\n"
                                );

                                Colores.EstablecerColorTexto("default");

                                Console.Write(
                                    "Presione una tecla para regresar al "
                                    + "menú principal... "
                                );

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }

                        if (segundaOpcionMenu == "4")
                        {
                            Console.Clear();

                            Menu.MostrarMensajeModoDeJuego(
                                primeraOpcionMenu,
                                Menu.MostrarModoDeJuego(primeraOpcionMenu),
                                Juego.totalJugadores
                            );

                            // Si ambos cartones se ha registrado, se muestra el mensaje
                            if (seRegistroPrimerCarton && seRegistroSegundoCarton)
                            {
                                Colores.EstablecerColorTexto("cian");

                                Console.WriteLine(
                                    "\nEstos son los cartones que registraste:\n"
                                );

                                Colores.EstablecerColorTexto("default");
                            }

                            Carton.ImprimirLosCartones(
                                Carton.cartonUno,
                                Carton.cartonDos,
                                seRegistroPrimerCarton,
                                seRegistroSegundoCarton
                            );

                            Console.Write(
                                "Presione una tecla para regresar al "
                                + "menú principal... "
                            );

                            Console.ReadKey(true);
                            Console.Clear();
                        }

                        if (segundaOpcionMenu == "5")
                        {
                            // Indicando que los dos cartones no se han registrado
                            seRegistroPrimerCarton = false;
                            seRegistroSegundoCarton = false;

                            // Restablecer los valores por defecto a los cartones
                            Carton.RestablecerValoresPorDefecto();
                        }

                        Console.Clear();

                    } while (
                        Menu.ControladorSegundoMenu(
                            segundaOpcionMenu
                        )
                    );
                }

                // Salir del juego
                if (!Menu.todasLasOpciones)
                {
                    Console.Clear();

                    if (primeraOpcionMenu == "3")
                    {
                        respuestaConfirmarSalida = Menu.ControladorSalidaMenu(
                            respuestaConfirmarSalida
                        );

                        Console.Clear();

                        if (respuestaConfirmarSalida == "s")
                        {
                            break;
                        }
                    }
                }

                else
                {
                    // Mostras partidas ganadas
                    if (primeraOpcionMenu == "3")
                    {
                        Menu.MostrarMensajeComunBingo();

                        formatoTiempo = "";

                        // Mostrando la hora, minutos y el
                        // estado de la hora actual (a. m. | p. m.)
                        Menu.MostrarHora(formatoTiempo);

                        if (Jugador.partidasGanadas == 0)
                        {
                            Colores.EstablecerColorTexto("cian");

                            Console.Write("\n\n" + Jugador.nickname);

                            Console.WriteLine(", no has ganado ninguna partida.");

                            Colores.EstablecerColorTexto("default");
                        }

                        else if (Jugador.partidasGanadas == 1)
                        {
                            Colores.EstablecerColorTexto("cian");

                            Console.Write("\n\n" + Jugador.nickname);

                            Colores.EstablecerColorTexto("default");

                            Console.Write(", tienes ");

                            Colores.EstablecerColorTexto("amarillo");

                            Console.Write(Jugador.partidasGanadas);

                            Colores.EstablecerColorTexto("default");

                            Console.WriteLine(" partida ganada.");
                        }

                        else
                        {
                            Colores.EstablecerColorTexto("cian");

                            Console.Write("\n\n" + Jugador.nickname);

                            Colores.EstablecerColorTexto("default");

                            Console.Write(", tienes ");

                            Colores.EstablecerColorTexto("amarillo");

                            Console.Write(Jugador.partidasGanadas);

                            Colores.EstablecerColorTexto("default");

                            Console.WriteLine(" partidas ganadas.");
                        }

                        Console.Write(
                            "\nPresione una tecla para volver al menú principal... "
                        );

                        Console.ReadKey(true);
                        Console.Clear();
                    }

                    // Salir del juego
                    if (primeraOpcionMenu == "4")
                    {
                        respuestaConfirmarSalida = Menu.ControladorSalidaMenu(
                            respuestaConfirmarSalida
                        );

                        Console.Clear();

                        if (respuestaConfirmarSalida == "s")
                        {
                            break;
                        }
                    }
                }

            } while (
                Menu.ControladorPrimerMenu(
                    primeraOpcionMenu,
                    respuestaConfirmarSalida,
                    Menu.todasLasOpciones
                )
            );

            Console.Write("Presione una tecla para salir... ");
            Console.ReadKey(true);

            Console.Clear();
        }
    }
}
