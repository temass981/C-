int [] a ={1,2,6,8,4};
int max =a[0];
for (int i=0; i<a.Length; i++){
    if (max<a[i]){
        max = a[i];
    }
}
Console.WriteLine(max);