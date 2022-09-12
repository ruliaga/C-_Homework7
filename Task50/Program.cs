Console.Clear();
Console.WriteLine("Введите i (номер строки) искомого элемента массива: ");
int i=int.Parse(Console.ReadLine());
Console.WriteLine("Введите j (номер столбца) искомого элемента массива: ");
int j=int.Parse(Console.ReadLine());

Random rnd=new Random();

Console.WriteLine("Сгенерирован новый массив:");

int [,] array = FillArray(rnd.Next(5,10),rnd.Next(5,10),0,10);
PrintArray(array);


int [,] FillArray(int rows, int columns,  int min, int max){

    int [,] array = new int [rows,columns];
        for (int i=0; i<rows;i++){
            for (int j=0;j<columns;j++){
                array [i,j]=new Random().Next(min,max);
                
            }
        }
        return array;
}

void PrintArray (int [,] filledArray){
    for (int i=0; i<filledArray.GetLength(0); i++){
        for (int j=0; j<filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]}  ");
        
         }
         Console.WriteLine();
    }
}

try
{
   Console.WriteLine($"Элемент с индексом [{i},{j}] -> {array[i,j]}");
}
catch (System.Exception e)
{
    
    Console.WriteLine($"Элемент с индексом [{i},{j}] -> Такого элемента не существует");
}



    