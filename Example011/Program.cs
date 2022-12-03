Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if ((a%b)==0){
    System.Console.WriteLine("Число " + b + " кратно числу " + a);
}else{
    System.Console.WriteLine("Остаток от деления числа " + a+ " на число " + b + " = " + (a%b));
}
