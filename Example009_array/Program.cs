int Max(int a1, int a2, int a3){
    int arg = a1;
    if (arg<a2) arg=a2;
    if (arg<a3) arg =a3;
    return arg;
}
int [] array ={10,3,4,543,12,142,54,213,123,4235,543,3123};
//int max = Max(
//    Max(array[0],array[1],array[2]),
//    Max(array[3],array[4],array[5]),
//    Max(array[6],array[7],array[8])
//);
//int max = 0;
System.Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());
for (int i=0; i<array.Length; i++){
    
    if(a==array[i]) System.Console.WriteLine("Ваше число находится в массиве под индексом "+ i);
}
//System.Console.WriteLine(max);