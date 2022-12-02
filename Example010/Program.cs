//int [] array = new int [10];
//for (int i=0;i<array.Length; i++){
//    array[i]= new Random().Next(0,100);
//    System.Console.WriteLine(array[i]);
//}

void FillArray(int [] collection){
    int length=collection.Length;
    int index = 0;
    while (index<length){
        collection[index]=new Random().Next(0,10);
        System.Console.WriteLine(collection[index]);
        index++;
    }
    
}
int ElArray(int [] a){
    int max = 0;
    int index =0;
    while(index<a.Length){
        if (a[index]>max){
            max =a[index];
        }    
        index++;
    }
    return max;
}
//int [] array1 = new int [20];
//FillArray(array1);
//System.Console.WriteLine();
int [] array2 = new int [5];
FillArray(array2);
System.Console.WriteLine();
int result = ElArray(array2);
System.Console.WriteLine(result);