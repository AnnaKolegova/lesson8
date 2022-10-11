void Zadacha54()
{
    Random random= new Random();
    int rows=random.Next(1,4);
    int columns=random.Next(1,5);
    Console.WriteLine ($"Массив  размером - строчек {rows}, столбцов {columns}");
    int[,]numbers=new int[rows, columns];
    
    FillArray(numbers);
    PrintArray (numbers);
    Sort(numbers);
    Console.WriteLine ("отсортированный массив");
    PrintArray (numbers);
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
void Sort(int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
   
       
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
           int min=j;
            for (int k=j+1; k<columns;k++)
            {
                if (numb[i,k]>numb[i,min]) 
                {
                    min=k;
                }
            }
            int temp=numb[i,j];
            numb[i,j]=numb[i,min];
            numb[i,min]=temp;
        }
        
    }
}
Zadacha54();
