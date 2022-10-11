void Zadacha58()
{
    int rows=4;
    int columns=4;
    int[,]numbers=new int[rows, columns];
    
    FillArray(numbers);
    PrintArray (numbers);           
}

void FillArray (int[,] numb)
{
    int rows=numb.GetLength(0);
    int columns=numb.GetLength(1);
    int n=1;
    for (int i=0; i<columns; i++)
    {
        numb[0, i]= n;
        n++;
    }
    for (int i=1; i<columns; i++)
    {
        numb[i, columns-1]= n;
        n++;
    }
    for (int i=1; i<columns-1; i++)
    {
        numb[rows-1, columns-i-1]= n;
        n++;
    }
    for (int i=1; i<rows-1; i++)
    {
        numb[rows-i, 0]= n;
        n++;
    }
    for (int i=0; i<columns-1; i++)
    {
        numb[1, i]= n;
        n++;        
    }
    for (int i=1; i<columns-1; i++)
    {
        numb[rows-2, columns-i-1]= n;
        n++;
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
Zadacha58();
