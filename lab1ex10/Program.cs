/*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
tastatura. Numarul are exact 2 cifre*/



Console.WriteLine("Introduceti un numar din 2 cifre");
int nr = Convert.ToInt32(Console.ReadLine());
int primacifra=nr/10;
int doileacifra=nr%10;
int suma=primacifra+doileacifra;

Console.WriteLine("Suma cifrelor este: "+suma);
