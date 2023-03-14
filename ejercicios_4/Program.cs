// 1 --------------------------------------------
// 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
//La resta si el primero es mayor que el segundo.
//La suma si son iguales.
//El producto si el primero es menor.
//Se deberá emitir un cartel por pantalla con el resultado correspondiente.

// float a, b, resultado;

// Console.WriteLine("Ingrese un número: ");
// a = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = float.Parse(Console.ReadLine());

// if (a > b)
//     resultado = a - b;
// else if (a < b)
//     resultado = a * b;
// else
//     resultado = a + b;

// Console.WriteLine("El resultado es: " + resultado);


// 2 ----------------------------------------
// 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
    // Si vende menos de 100 litros, no hay descuento.
    // Si vende entre 101 y 300 litros, el descuento es del 10%.
    // Si vende entre 301 y 500 litros, el descuento es del 15%.
    // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y 
// la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado.

// float importe, litros;

// Console.WriteLine("Ingrese el importe: ");
// importe = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese los litros: ");
// litros = float.Parse(Console.ReadLine());


// if (litros > 500)
//     importe *= 0.75F;
// else if (litros > 300)
//     importe *= 0.85F;
// else if (litros > 100)
//     importe *= 0.90F;

// Console.WriteLine("El importe total con descuento es: $" + importe + " para " + litros + " lts.");



// 3 -----------------------------------------------
// 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
    //                i5 (1)  i7 (2)   i9 (3)
    // 8 RAM (1)	USD 800	 USD 900  USD 1200
    // 16 RAM (2)	USD 900	 USD 1000 USD 1400
    // 32 RAM (3)	USD 1000 USD 1400 USD 2000
// Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, 
// lo cual tiene un costo  adicional de USD 300. 
// Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, 
// y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) 
// y calcule y emita por pantalla el monto de la máquina seleccionada.

// int procesador, memoriaRam, disco, precio = 0;

// Console.WriteLine("Ingrese la opción de procesador: ");
// procesador = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la opción de Memoria RAM: ");
// memoriaRam = int.Parse(Console.ReadLine());
// Console.WriteLine("Quiere extender el disco?: ");
// disco = int.Parse(Console.ReadLine());

// if (procesador == 1){

//     switch(memoriaRam){
//         case 1:
//             precio = 800;
//             break;
//         case 2:
//             precio = 900;
//             break;
//         case 3:
//             precio = 1000;
//             break;
//         default:
//             break;
//     }   
// }

// if (procesador == 2){
//     switch (memoriaRam)
//     {
//         case 1:
//             precio = 900;
//             break;
//         case 2:
//             precio = 1000;
//             break;
//         case 3:
//             precio = 1400;
//             break;
//         default:
//             break;
//     }
// }

// if (procesador == 3){
//     switch (memoriaRam)
//     {
//         case 1:
//             precio = 1200;
//             break;
//         case 2:
//             precio = 1400;
//             break;
//         case 3:
//             precio = 2000;
//             break;
//         default:
//             break;
//     }
// }

// if (disco == 1)
//     precio = precio + 300;

// Console.WriteLine("El precio es: " + precio);



// 4 ---------------------------------------------
// 4. Hacer un programa para ingresar tres números y emitir un cartel 
// aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

// int a, b, c, suma, producto;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// c = int.Parse(Console.ReadLine());

// suma = a + b;
// producto = b * c;

// if (suma > producto)
//     Console.WriteLine("La suma de los dos primero es mayor.");
// else if (producto > suma)
//     Console.WriteLine("El producto de los dos últimos es mayor");
// else
//     Console.WriteLine("Fin del Programa.");



// 5 -------------------------------------
// 5. Hacer un programa para ingresar 4 números. Luego analizar e 
// informar por pantalla si los mismos se encuentran ordenados de forma decreciente .

// int a, b, c, d;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// d = int.Parse(Console.ReadLine());

// if (a > b && b > c && c > d)
//     Console.WriteLine("Están ordenados en forma decreciente.");
// else
//     Console.WriteLine("No están ordenados");



// EJERCICIOS EXTRA DE LA GUÍA ---------------------
// A -----------------------------------------------
//1. Hacer un programa que solicite el ingreso de un número y que luego emita un
// cartel por pantalla aclarando si el mismo es múltiplo de 5.

// int a;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());

// if (a % 5 == 0 || a % 5 ==5 )
//     Console.WriteLine(a + " Es múltiplo de 5.");
// Console.WriteLine("Fin del programa");




// B --------------------------------------------------
// 3. Hacer un programa para ingresar dos números. Si el segundo es distinto de
// cero, calcular la división del primero por el segundo y mostrar el resultado por
// pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por cero.

// int a, b, division;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());

// if (b != 0){
//     division = a / b;
//     Console.WriteLine("El resultado es: " + division);
// }else
//     Console.WriteLine("No se puede dividir por cero.");




// C ------------------------------------------------------
// 5. Hacer un programa que solicite el ingreso de las notas del primer parcial y del
// segundo parcial de una alumna de programación. El programa deberá analizar
// las notas y emitir la situación de la alumna según la siguiente escala:
    // a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
    // b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
    // aprueba con 6 o más), emitir “rinde examen final”.
    // c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe recuperar”.
// El programa debe emitir solo un cartel, el que corresponda.


// int nota1, nota2;

// Console.WriteLine("Ingrese la primer nota: ");
// nota1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la segunda nota: ");
// nota2 = int.Parse(Console.ReadLine());

// if (nota1 >= 8 && nota2 >= 8)
//     Console.WriteLine("Aprobación directa");
// else if (nota1 >= 6 && nota2 >= 6)
//     Console.WriteLine("Rinde examen final.");
// else 
//     Console.WriteLine("Debe recuperar.");




// D ------------------------------------------------------
// 6. Hacer un programa para ingresar por teclado la longitud de los tres lados de un
// triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo de triángulo corresponde:
    // a. Equilátero: cuando los tres lados sean iguales.
    // b. Isósceles: cuando dos de los tres lados sean iguales.
    // c. Escaleno: cuando todos los lados sean distintos.


// int lado1, lado2, lado3;

// Console.WriteLine("Longitud del primer lado: ");
// lado1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Longitud del segundo lado: ");
// lado2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Longitud del tercer lado: ");
// lado3 = int.Parse(Console.ReadLine());

// if (lado1 == lado2 && lado1 == lado3)
//     Console.WriteLine("Equilátero");
// else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
//     Console.WriteLine("Isósceles");
// else
//     Console.WriteLine("Escaleno");
// Console.WriteLine("Fin del programa.");


// E -------------------------------------------------------
// 8. El negocio de desinfectante antes mencionado vende además detergente
// suelto, y los precios se aplican según la siguiente escala:
    // a. 25 ARS por litro los primeros 50 litros.
    // b. 20 ARS por litro si la venta es de 51 a 200 litros.
    // c. 15 ARS por litro si la venta es de 201 a 500 litros.
    // d. 10 ARS por litro si la venta es de más de 500 litros.
// Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
// Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
// (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
// y emita por pantalla el monto final a abonar por el cliente.

// float litros_vendidos, pago;

// Console.WriteLine("Ingrese los litros vendidos: ");
// litros_vendidos = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la forma de pago (1=Efectivo, 0=Otro): ");
// pago = float.Parse(Console.ReadLine());

// if (litros_vendidos > 500)
//     litros_vendidos *= 10;
// else if (litros_vendidos > 200)
//     litros_vendidos *= 15;
// else if (litros_vendidos > 50)
//     litros_vendidos *=20;
// else
//     litros_vendidos *= 25;

// if (pago ==1)
//     litros_vendidos *= 0.90F;

// Console.WriteLine("El monto final es de: $" + litros_vendidos);


// F -------------------------------------------------
// 10. Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
//son todos iguales entre sí, caso contrario, no emitir nada

// int a, b, c, d;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// c = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese el último: ");
// d = int.Parse(Console.ReadLine());

// if (a == b && a == c && a == d)
//     Console.WriteLine("Son todos iguales.");
// Console.WriteLine("Fin del programa.");

