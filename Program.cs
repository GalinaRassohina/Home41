// Напишите метод, который принимает на вход два числа (A и B) и возводит 
//число A в натуральную степень B.3, 5 -> 243 (3⁵) 2, 4 -> 16
// В методе цикл, который умножает А само на себя В раз
void PowerNumber (int a , int b)
{
 int result = 1;
  for( int i = 1; i < b+1; i++) 
 {
    result =result * a;
 }
 Console.WriteLine($"{a}^{b } = {result}");
}
PowerNumber(3, 5);




