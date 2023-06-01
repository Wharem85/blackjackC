// variables tipo var y double

//*
// var ladoA = 0d;
// double ladoB;
// var resultado = 0d;

// Console.WriteLine("Calcula el area de un rectangulo!!");
// Console.WriteLine("Ingrese el valor del lado A: ");
// ladoA = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingrese el valor del lado B: ");
// ladoB = Convert.ToDouble(Console.ReadLine());

// resultado = (ladoA % ladoB);
// Console.WriteLine("El resultado es: " + resultado);
//*

//Uso de constantes
//*
// var resultado = 0d;

// const double Pi = 3.14;

// Console.WriteLine("Bienvenido, calculemos circulos!");

// Console.WriteLine("Ingrese el valor del radio: ");
// double radio = Convert.ToDouble(Console.ReadLine());

// resultado = Math.PI * radio * radio;

// Console.WriteLine("El area del circulo es de: " + resultado);
//*

//*
// // bool valor1 = true;
// // bool valor2 = false;
// // bool valor3 = true;

// var (valor1, valor2, valor3) = (true, true, false);

// bool result = valor1 && valor2 && valor3;
// Console.WriteLine(result);

// bool resultOr = valor1 || valor2 || valor3;
// Console.WriteLine(resultOr);

// bool resultAndOr = (valor1 && valor2) || valor3;
// Console.WriteLine(resultAndOr);

// bool resultNot = !valor1;
// Console.WriteLine(resultNot);

// //Este signp "^" significa diferencia
// bool resultXor = valor1 ^ valor2 ^ valor3;
// Console.WriteLine(resultXor);
//*
//Operadores Relacionales

// var (valor1, valor2, valor3) = (10, 10, 2);

// Console.WriteLine("Los valores son: " + valor1 + valor2 + valor3);

// bool resultado1 = valor1 == valor2;
// Console.WriteLine("El resultado de la comparacion valor1 == valor2: " + resultado1);

// bool resultado2 = valor1 != valor2;
// Console.WriteLine("El resultado de la comparacion valor1 != valor2: " + resultado2);

// bool resultado3 = valor1 > valor2;
// Console.WriteLine("El resultado de la comparacion valor1 > valor2:" + resultado3);

// bool resultado4 = valor1 < valor2;
// Console.WriteLine("El resultado de la comparacion valor1 < valor2: " + resultado4);

// bool resultado5 = valor1 >= valor2;
// Console.WriteLine("El resultado de la comparacion valor1 >= valor2: " + resultado5);

// bool resultado6 = valor1 <= valor2;
// Console.WriteLine("El resultado de la comparacion valor1 <= valor2: " + resultado6);

//*

//*
//Strings

// Console.WriteLine("Wilmer Monterrozo ID!");
// int altura = 145;
// int edad = 23;
// string nombre = "Wilmer Monterrozo";
// string informacion = "Nacio en Guatemala, es Programador";
// var hobby = "Jugador";

// string tarjetaDeIdentificacion = $"La informacion de {nombre} es la siguiente: \n" +
// 	$"edad: {edad} \n altura: {altura} \n informacion: {informacion} \n hobby: {hobby}";

// Console.WriteLine(tarjetaDeIdentificacion);

//*

//*

// Condicional if

// Random random = new Random();
// int totalJugador = random.Next(0, 25);
// int totalDealer = random.Next(0, 21);
// string message = "";

// if (totalJugador > totalDealer && totalJugador < 22) {
// 	message = "Venciste al dealer, felicidades";
// } else if (totalJugador <= totalDealer) {
// 	message = "Perdiste vs el dealer, lo siento";
// } else if (totalJugador >= 22) {
//  	message = "Perdiste vs el dealer, te pasaste de 21";
// } else {
// 	message = "Condicion no valida";
// }

// Console.WriteLine(message);
//*

//*
// Condicional Switch

// Random random = new Random();
// int totalJugador = random.Next(0, 25);
// int totalDealer = random.Next(0, 21);
// string message = "";
// string switchControl = "menu";

// switch (switchControl)
// {
// 	case "menu":
// 		Console.WriteLine("Welcome al casino");
// 		Console.WriteLine("Escriba '21' para jugar al 21");
// 		switchControl = Console.ReadLine();
// 		break;
// 	case "21":
// 		if (totalJugador > totalDealer && totalJugador < 22) {
// 			message = "Venciste al dealer, felicidades";
// 		} else if (totalJugador <= totalDealer) {
// 			message = "Perdiste vs el dealer, lo siento";
// 		} else if (totalJugador >= 22) {
// 			message = "Perdiste vs el dealer, te pasaste de 21";
// 		} else {
// 			message = "Condicion no valida";
// 		}

// 		Console.WriteLine(message);
// 		break;
// 	default:
// 	 Console.WriteLine("Valor ingresado no es valido en el casino");
// 	 break;
// }


//*

//*
// Condicional switch

Random random = new Random();
int totalJugador = random.Next(1, 25);
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

while (true) {
	Console.WriteLine(platziCoins);
	Console.WriteLine("Welcome al Casino");
	Console.WriteLine("Cuantos Monedas deseas? \n" + "Ingresa un numero entero \n" + "Recuerda que necesitas una por juego");
	platziCoins = Convert.ToInt32(Console.ReadLine());

	for (int i = 0; i < platziCoins; i++) {
		totalJugador = 0;
		totalDealer = 0;
		switch (switchControl)
		{
			case "menu":
				Console.WriteLine("Escriba '21' para jugar al 21");
				switchControl = Console.ReadLine();
				i--;
				break;
			case "21":
				do
				{
					num = random.Next(1, 12);
					totalJugador = totalJugador + num;
					Console.WriteLine($"Toma tu carta, jugador \n Te salio el numero: {num}");
					Console.WriteLine("Deseas otra carta?");
					controlOtraCarta = Console.ReadLine();
				} while (controlOtraCarta == "Si");

				totalDealer = random.Next(14, 23);

				Console.WriteLine($"El dealer tiene {totalDealer}");

				if (totalJugador > totalDealer && totalJugador < 22) {
					message = "Venciste al dealer, felicidades";
					platziCoins++;
					switchControl = "menu";
				} else if (totalJugador <= totalDealer) {
					message = "Perdiste vs el dealer, lo siento";
					switchControl = "menu";
				} else if (totalJugador >= 22) {
					message = "Perdiste vs el dealer, te pasaste de 21";
					switchControl = "menu";
				} else {
					message = "Condicion no valida";
				}

				Console.WriteLine(message);
				break;
			default:
			Console.WriteLine("Valor ingresado no es valido en el casino");
			break;
		}
	}
}


//*
