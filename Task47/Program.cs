Console.Clear();
Console.WriteLine("Введите m (количество строк массива):");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите n (количество столбцов массива):");
int n=int.Parse(Console.ReadLine());
double [,] array = FillArray(m,n,-10,10);
PrintArray(array);

double [,] FillArray(int rows, int columns,  int min, int max){

    double [,] array = new double [rows,columns];
        for (int i=0; i<rows;i++){
            for (int j=0;j<columns;j++){
                array [i,j]=Math.Round((new Random().NextDouble()*(new Random().Next(min,max))),2);
                
            }
        }
        return array;
}

void PrintArray (double [,] filledArray){
    for (int i=0; i<filledArray.GetLength(0); i++){
        for (int j=0; j<filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]}  ");
        
         }
         Console.WriteLine();



    }
}

