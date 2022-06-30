void OneOfNum(int num_1, int num_2)
{       
    if (num_1 % num_2 == 0)
    {
        Console.WriteLine($"{num_1}, {num_2} -> кратные");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_2} -> не кратные, остаток {num_1 % num_2}");        
    }    
}
int a = new Random().Next(1,100);
int b = new Random().Next(1,50);
OneOfNum(a,b);

