// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Console.WriteLine("Prueba");
Calculadora x = new Calculadora();
Console.WriteLine("Ingrese que operacion desea realizar:");
    Console.WriteLine("1)Suma\n2)Resta\n3)Multiplicar\n4)Dividir");
    string a = Console.ReadLine();
    int numero;
    int.TryParse(a, out numero);
do {
    
    if(numero<=4 && numero >=1 )
        {
            Console.WriteLine("Ingrese el primer numero:");
            a = Console.ReadLine();
            int h;
            int.TryParse(a, out h);
            Console.WriteLine("Ingrese el segundo numero:");
            a = Console.ReadLine();
            int c;
            int.TryParse(a, out c);
            switch (numero)
            {
                case 1: 
                        x.Sumar(h,c);
                        Console.WriteLine("La suma de los numero "+h+" y "+c+" es : "+x.Resultado());
                        break;
                case 2: 
                        x.Restar(h,c);
                        Console.WriteLine("La resta de los numero "+h+" y "+c+" es : "+x.Resultado());
                        break;
                case 3: 
                        x.Multiplicar(h,c);
                        Console.WriteLine("La multiplicacion de los numero "+h+" y "+c+" es : "+x.Resultado());
                        break;
                case 4: 
                        x.Dividir(h,c);
                        Console.WriteLine("La division de los numero "+h+" y "+c+" es : "+x.Resultado());
                        break;                
                default:
                        Console.WriteLine("\n\nEl valor ingresado es incorrecto \n\n");
                        break;
            }
        }
    Console.WriteLine("\n\nDesea realizar otra operacion? 0/1:    ");
    a = Console.ReadLine();
    int.TryParse(a, out numero);
    Console.WriteLine("Ingrese que operacion desea realizar:");
    Console.WriteLine("1)Suma\n2)Resta\n3)Multiplicar\n4)Dividir");
    a = Console.ReadLine();
    int.TryParse(a, out numero);
} while (numero>0);
