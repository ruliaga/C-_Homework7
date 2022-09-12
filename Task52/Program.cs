Console.Clear();
Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();


Random rnd=new Random();

Console.WriteLine("Сгенерирован новый массив:");

int [,] array = FillArray(rnd.Next(3,5),rnd.Next(3,5),0,10);
PrintArray(array);
SumColumns(array);


int [,] FillArray(int rows, int columns,  int min, int max){

    int [,] array = new int [rows,columns];
        for (int i=0; i<rows;i++){
            for (int j=0;j<columns;j++){
                array [i,j]=new Random().Next(min,max);
                
            }
        }
        return array;
}

void SumColumns (int [,] array){
    Console.Write("Среднее арифметическое каждого столбца ->");
        
     for (int i=0; i<array.GetLength(0);i++){
            int sum=0;
            for (int j=0;j<array.GetLength(1);j++){
                sum=sum+array[i,j];
            }
            Console.Write($"{Convert.ToDouble(sum/array.GetLength(1))}  ");
     }

}


void PrintArray (int [,] filledArray){
    for (int i=0; i<filledArray.GetLength(0); i++){
        for (int j=0; j<filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]}  ");
        
         }
         Console.WriteLine();
    }
}


