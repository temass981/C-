﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine();
int xa=10, ya=10,
    xb =10, yb =20,
    xc =30, yc =20;
    Console.SetCursorPosition(xa, ya);
    Console.WriteLine("0");
    Console.SetCursorPosition(xb, yb);
    Console.WriteLine("0");
    Console.SetCursorPosition(xc, yc);
    Console.WriteLine("0");

    int x=xa, y=ya;
    int count = 0;
    while (count < 100){
        int what = new Random().Next(0,3);
        if(what ==0){
            x=(x+xa)/2;
            y=(y+ya)/2;
        }
        if(what ==1){
            x=(x+xb)/2;
            y=(y+yb)/2;
        }
        if(what ==2){
            x=(x+xc)/2;
            y=(y+yc)/2;
        }
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
        count++;
    }