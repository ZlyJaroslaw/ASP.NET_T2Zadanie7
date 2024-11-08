// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Ostrzeżenie: Ten program może użyć wobec ciebie inwektyw.");
Console.WriteLine("Jeśli nie chcesz być znieważony na podstawie podanego wzrostu, opuść ten program naciskając CTRL+C");
Console.WriteLine("Wciskając cokolwiek innego (np. ENTER) wchodzisz na własną odpowiedzialność.");

Console.ReadLine();

Console.WriteLine("Osobom wrażliwym na przypominanie czegokolwiek z drugiej wojny światowej też radzę nacisnąć CTRL+C i opuścić program");
Console.WriteLine();
Console.WriteLine("Jeśli nie masz przycisku CTRL, złóż reklamację u producenta sprzętu, lub skorzystaj z pomocy technicznej.");
Console.ReadLine();

//Zadanie 1

Console.WriteLine("Zadanie 1:");
Console.WriteLine();

int a;
int b;

Console.Write("Podaj pierwszą zmienną: ");
string aFromConsole = Console.ReadLine();
Console.Write("Podaj drugą zmienną: ");
string bFromConsole = Console.ReadLine();

Int32.TryParse(aFromConsole, out a);
Int32.TryParse(bFromConsole, out b);

if (a == b)
{
    Console.WriteLine($"{a} i {b} są równe");
}
else
{
    Console.WriteLine($"{a} i {b} nie są równe!!!!");
}

// Zadanie 2
Console.WriteLine();
Console.WriteLine("Zadanie 2:");
Console.WriteLine();

int c;

Console.Write("Podaj liczbę: ");
string cFromConsole = Console.ReadLine();

Int32.TryParse(cFromConsole, out c);

if  (c % 2 == 0)
{
    Console.WriteLine($"{c} jest liczbą parzystą");
}
else
{
    Console.WriteLine($"{c} jest liczbą nieparzystą");
}

//Zadanie 3
Console.WriteLine();
Console.WriteLine("Zadanie 3:");
Console.WriteLine();

int d;

Console.Write("Podaj liczbę: ");
string dFromConsole = Console.ReadLine();

Int32.TryParse(dFromConsole, out d);

if (d > 0)
{
    Console.WriteLine($"{d} jest liczbą dodatnią");
}
else if (d < 0)
{
    Console.WriteLine($"{d} jest liczbą ujemną");
}
else
{
    Console.WriteLine($"{d} nie jest liczbą dodatnią ani ujemną");
}

//Zadanie 4
Console.WriteLine();
Console.WriteLine("Zadanie 4:");
Console.WriteLine();

int year;
string noString = "";

Console.Write("Podaj rok: ");
string yearFromConsole = Console.ReadLine();

Int32.TryParse((string)yearFromConsole, out year);

if (year < -45)
{
    Console.WriteLine("Przed rokiem 45 p.n.e. nie było lat przestępnych");
}
else
{
    if (year <= -9)
    {
        if (year % 3 != 0)
        {
            noString = "nie ";
        }
        
    }
    else if (year < 1)
    {
        if ((year != -5) || (year != -1))
        {
            noString = "nie ";
        }
        
    }
    else if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
    {
        
    }
    else
    {
        noString = "nie ";
    }

    Console.WriteLine($"Rok {year} {noString}jest przestępny");
}



//Zadanie 5
Console.WriteLine();
Console.WriteLine("Zadanie 5:");
Console.WriteLine();

int age;

Console.Write("Podaj swój wiek: ");
string ageFromConsole = Console.ReadLine();

Int32.TryParse(ageFromConsole, out age);

if (age >= 35)
{
    Console.WriteLine("Możesz zostać prezydentem");
}
else if (age >= 30)
{
     Console.WriteLine("Możesz zostać senatorem");
}
else if (age >= 25)
{
    Console.WriteLine("Możesz zostać posłem, wójtem, burmistrzem, albo prezydentem miasta");
}
else if (age >= 21)
{
    Console.WriteLine("Możesz zostać posłem, a jak ci dobrze pójdzie, to i premierem.");
}
else if (age >= 18)
{
    Console.WriteLine("Możesz dostać się do rady gminy, rady powiatu, albo do sejmiku województwa");
}
else if (age >= 0)
{
    Console.WriteLine("Jesteś za młody by umierać");
}
else
{
    Console.WriteLine("Możesz się ubiegać o 500+");
}

//Zadanie 6
Console.WriteLine();
Console.WriteLine("Zadanie 6:");
Console.WriteLine();

int growth;

Console.Write("Podaj wzrost: ");
string growthFromConsole = Console.ReadLine();

Int32.TryParse (growthFromConsole, out growth);

string antiString = "";

if (growth < 0)
{
    growth = -growth;
    antiString = "anty";
}

if (growth >= 600)
{
    Console.WriteLine($"Jesteś {antiString}kolosem");
}
else if (growth >= 450)
{
    Console.WriteLine($"Jesteś {antiString}żyrafą");
}
else if (growth >= 430)
{
    Console.WriteLine($"Jesteś {antiString}olbrzymem");
}
else if (growth >= 260)
{
    Console.WriteLine($"Jesteś {antiString}słoniem");
}
else if (growth >=220)
{
    Console.WriteLine($"Jesteś {antiString}hulkiem");
}
else if (growth >=200)
{
    Console.WriteLine($"Jesteś {antiString}siatkarzem");
}
else if(growth >=180)
{
    Console.WriteLine($"Jesteś {antiString}dryblasem");
}
else if (growth >=170)
{
    Console.WriteLine($"Jesteś {antiString}hitlerkiem");
}
else if (growth >=160)
{
    Console.WriteLine($"Jesteś {antiString}kurduplem");
}
else if (growth >=150)
{
    Console.WriteLine($"Jesteś {antiString}karakanem");
}
else if (growth >=140)
{
    Console.WriteLine($"Jesteś {antiString}krasnoludem");
}
else if ((growth >=80))
{
    Console.WriteLine($"Jesteś {antiString}karzełkiem");
}
else if ((growth >30))
{
    Console.WriteLine($"Jesteś {antiString}brzdącem");
}
else if ((growth >=25))
{
    Console.WriteLine($"Jesteś {antiString}ratlerkiem");
}
else if (growth >=3)
{
    Console.WriteLine($"Jesteś {antiString}smerfem");
}
else
{
    Console.WriteLine($"Jesteś {antiString}robaczkiem");
}

//Zadanie 7

Console.WriteLine();
Console.WriteLine("Zadanie 7:");
Console.WriteLine();

int number1;
int number2;
int number3;

int numberMax;

Console.Write("Podaj liczbę 1: ");
string number1FromConsole = Console.ReadLine();
Console.Write("Podaj liczbę 2: ");
string number2FromConsole = Console.ReadLine();
Console.Write("Podaj liczbę 3: ");
string number3FromConsole = Console.ReadLine();

Int32.TryParse(number1FromConsole, out number1);
Int32.TryParse(number2FromConsole, out number2);
Int32.TryParse(number3FromConsole, out number3);

if  (number1 >= number2)
{
    numberMax = number1;
}
else
{ 
    numberMax = number2; 
}
if (number3 > numberMax)
{
    numberMax = number3;
}

Console.WriteLine($"{numberMax} jest największa z podanych");

//Zadanie 8

Console.WriteLine();
Console.WriteLine("Zadanie 8:");
Console.WriteLine();

int mathResult;
int physicsResult;
int chemistryResult;

Console.Write("Podaj wynik z matematyki: ");
string mathResultFromConsole = Console.ReadLine();
Console.Write("Podaj wynik z fizyki: ");
string physicsResultFromConsole = Console.ReadLine();
Console.Write("Podaj wynik z chemii: ");
string chemistryResultFromConsole = Console.ReadLine();

Int32.TryParse(mathResultFromConsole, out mathResult);
Int32.TryParse(physicsResultFromConsole, out physicsResult);
Int32.TryParse(chemistryResultFromConsole, out chemistryResult);

bool condition1 = (((mathResult > 70) && (physicsResult > 55) && (chemistryResult > 45)) && (mathResult + physicsResult + chemistryResult > 180));
bool condition2 = ((mathResult + physicsResult > 150) || (mathResult + chemistryResult > 150));

//Console.WriteLine(condition1);
//Console.WriteLine(condition2);

if (condition1 || condition2)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}

//Zadanie 9

Console.WriteLine();
Console.WriteLine("Zadanie 9:");
Console.WriteLine();

int temperature;

Console.Write("Podaj temperaturę: ");
string temperatureFromConsole = Console.ReadLine();

Int32.TryParse(temperatureFromConsole, out temperature);

if  (temperature > 40)
{
    Console.WriteLine("Cieplutko jak w krematorium");
}
else if (temperature >= 30)
{
    Console.WriteLine("Tak gorąco, że wolno tylko popijać piwko na leżaczku");
}
else if (temperature >= 20)
{
    Console.WriteLine("W sam raz, można pracować w biurze");
}
else if (temperature >=10)
{
    Console.WriteLine("Chłodno, można tylko ciężko zasuwać łopatą");
}
else if (temperature >=0)
{
    Console.WriteLine("Na taki wygwizdówek bym nawet szczura nie wyrzucił");
}
else
{
    Console.WriteLine("Zimno, jak w piekle, od kiedy ten... od kiedy diabły się boją po drewno schylić");
}

//Zadanie10

Console.WriteLine();
Console.WriteLine("Zadanie 10:");
Console.WriteLine();

int side1;
int side2;
int side3;

Console.WriteLine("Program policzy czy z boków podanej długości można zbudować trójkąt");
Console.WriteLine();

Console.Write("Podaj bok 1: ");
string side1FromConsole = Console.ReadLine();
Console.Write("Podaj bok 2: ");
string side2FromConsole = Console.ReadLine();
Console.Write("Podaj bok 3: ");
string side3FromConsole = Console.ReadLine();

Int32.TryParse(side1FromConsole, out side1);
Int32.TryParse(side2FromConsole, out side2);
Int32.TryParse(side3FromConsole, out side3);

string triangleOk = "Można zbudować trójkąt";
string triangleNG = "Nie można zbudować trójkąta";

//wartości bezwzględne
if (side1 <= 0)
{
    side1 = -side1;
}

if (side2 <= 0)
{
    side2 = -side2;
}

if (side3 <= 0)
{
    side3 = -side3;
}


if ((side1 >= side2) && (side1 >= side3))
{
    if (side1 < (side2 + side3))
    {
        Console.WriteLine(triangleOk);
    }
    else
    {
        Console.WriteLine(triangleNG);
    }
}
else if ((side2 >= side1) && (side2 >= side3))
{
    if (side2 < (side1 + side3))
    {
        Console.WriteLine(triangleOk);
    }
    else 
    { 
        Console.WriteLine(triangleNG); 
    }
}
else
{
    if (side3 < side1 + side2)
    {
        Console.WriteLine(triangleOk);
    }
    else
    {
        Console.WriteLine(triangleNG);
    }
}
//Zadanie11

Console.WriteLine();
Console.WriteLine("Zadanie 11:");
Console.WriteLine();

int degree;

Console.Write("Podaj ocenę ucznia: ");
string degreeFromConsole = Console.ReadLine();

Int32.TryParse(degreeFromConsole, out degree);

switch (degree)
{
    case 0:
        Console.WriteLine("Nieklasyfikowany");
        break;
    case 1:
        Console.WriteLine("Niedostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;
    default:
        Console.WriteLine("Błąd: Wybierz ocenę od 1 do 6");
        break;
}

//Zadanie12

Console.WriteLine();
Console.WriteLine("Zadanie 12:");
Console.WriteLine();

int day;

Console.Write("Podaj numer dnia tygodnia: ");
string dayFromConsole = Console.ReadLine();

Int32.TryParse(dayFromConsole, out day);

switch (day)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Pijątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Błąd: Podaj numer dnia tygodnia od 1 do 7");
        break;
}

//Zadanie13

Console.WriteLine();
Console.WriteLine("Zadanie 13:");
Console.WriteLine();
Console.WriteLine("Kalkulator");
Console.WriteLine();

float numero1;
float numero2;

Console.Write("Podaj pierwszą liczbę: ");
string numero1FromConsole = Console.ReadLine();

Console.Write("Podaj drugą liczbę: ");
string numero2FromConsole = Console.ReadLine();

float.TryParse(numero1FromConsole, out numero1);
float.TryParse(numero2FromConsole, out numero2);

int operacion;
Console.WriteLine();
Console.WriteLine("Podaj numer operacji do wykonania: ");
Console.WriteLine();
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
Console.WriteLine();
string operacionFromConsole = Console.ReadLine();

Int32.TryParse(operacionFromConsole, out operacion);

bool infinity = false;

float resultado = 0;
switch (operacion)
{
    case 1:
        resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;
    case 3:
        resultado = numero1 * numero2;
        break;
    case 4:
        if (numero2 !=0)
        {
            resultado = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Twój wynik: \u221E");
            Console.WriteLine();
            Console.WriteLine("Właśnie podzieliłeś przez 0.");
            infinity = true;
        }
        break;
    default:
        Console.WriteLine("Błąd: Wybierz numer działania od 1 do 4");
        break;
}

//int resultadoInt;

// Decimal.ToInt32(resultado);

Console.WriteLine();
if (!infinity)
{
    Console.Write("Twój wynik: ");
    Console.WriteLine(value: $"{resultado:0.00}");
}


