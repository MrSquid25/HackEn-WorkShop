using System;


// Enteros
int a = -10;
uint b = 20;
byte c = 233;

//System.Console.WriteLine("Valor de a es {0}", a);
//System.Console.WriteLine("Valor de b es {0}", b);
//System.Console.WriteLine("Valor de c es {0}", c);
//System.Console.WriteLine();

//Bytes

float efloat = 2.718281828459F;
double edouble = 2.718281828459D;

//System.Console.WriteLine("Valor de e como float es {0}", efloat);
//System.Console.WriteLine("Valor de e como double es {0}", edouble);


//Bool

bool verdad = true;
bool mentira = false;

//System.Console.WriteLine("Valor de verdad es {0}", verdad);
//System.Console.WriteLine("Valor de mentira es {0}", mentira);

//Letras

char letra = 'A';

//System.Console.WriteLine("Valor de letra como char es {0}", letra);


//Array

int[] arrayenteros = { 1, 2, 3, 4 };
int[] arrayenteros2 = { 1, 2, 3, 4 };

System.Console.WriteLine("Valor de arrayenteros es {0}, {1}, {2} y {3}", arrayenteros[0], arrayenteros[1], arrayenteros[2], arrayenteros[3]);


//Comparativa de Arrays
bool comparacion = (arrayenteros == arrayenteros2);
bool comparacion2 = (arrayenteros[0] == arrayenteros2[0]);

System.Console.WriteLine("Valor de comparacion es {0}", comparacion);
System.Console.WriteLine("Valor de comparacion2 es {0}", comparacion2);

//Tuple 

(int, uint) tupla = ( -1, 2);

System.Console.WriteLine("Valor de tupla es {0} {1}", tupla.Item1, tupla.Item2);

//String 

string ejemplo = "Hacken!";

System.Console.WriteLine("Valor de ejemplo es {0}", ejemplo);

string ejemplo2 = "HackenRocks!";

//Comparativa de Strings

bool comparativastrings = (ejemplo == ejemplo2);

System.Console.WriteLine("Valor de comparativastrings es {0}", comparativastrings);
