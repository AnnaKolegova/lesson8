void Zadacha56()
{
    Random random= new Random();
    int rows=random.Next(1,5);
    int columns=random.Next(1,7);
    Console.WriteLine ($"Массив  размером - строчек {rows}, столбцов {columns}");
    int[,]numbers=new int[rows, columns];
    
    FillArray(numbers);
    PrintArray (numbers);
    Summa(numbers);       
}

void FillArray (int[,] numb)
{
    Random random= new Random();
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            numb[i,j]=random.Next(1,5);
        }
    }
}

void PrintArray (int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
           Console.Write(numb[i,j]+"\t");
        }
        Console.WriteLine(); 
    }    
}
void Summa(int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    double minsum=100000000000;  
    int minrows=0;      
    for (int i=0; i<rows; i++)
    {
        int sum=0;
        for (int j=0; j<columns; j++)
        {
            sum=sum+numb[i,j];
        }
        if (sum<minsum)
        {
            minsum=sum;
            minrows=i+1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов {minsum} равен {minrows}");        
    }
Zadacha56();