int a1 = 15, b1 = 23, c1 = 33, 
    a2 = 154, b2 = 232, c2 = 331, 
    a3 = 17, b3 = 26, c3 = 39;
int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine (max);