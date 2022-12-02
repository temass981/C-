int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if (arg2> result) result =arg2;
    if (arg3> result) result = arg3;
    return result;
}
int a1 = 15, a2 = 14, a3 = 54,
    b1 = 16, b2 = 10, b3 = 75,
    c1 = 12, c2 = 65, c3 =95;

int first =Max(a1,a2,a3);
int second =Max(b1,b2,b3);
int three = Max (c1,c2,c3);
int result = Max(first,second,three);
Console.WriteLine(result);