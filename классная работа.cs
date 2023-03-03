// See https://aka.ms/new-console-template for more information

//задача с о.м на нахождение cреднего курса. самого высокого и самого низкого курса валют.



/*
double[] array = new double[31];
/*заполнение массива случайным образом*/
/*Random random = new Random();
for (byte i = 0; i < array.Length; i++)
{
    array[i] = 60 + 5 * random.NextDouble();
    Console.WriteLine($"array[{i}]={array[i]:f2}");
}
double sum = 0;
/*
 * накопление суммы
 */
/*
for (byte i=0;i<array.Length;i++)
{
    sum+=array[i];
}
Console.WriteLine($"Среднее значение курса валюты={(double)sum/array.Length:c2}");
double min = array[0];
 double max = array[0];
byte indexMin = 0;
byte indexMax = 0;
for(byte i=1;i<array.Length;i++)
{
    if (array[i]<min)
    {
        min = array[i];
        indexMin = i;

    }
        if(array[i]>max)
    {
        max= array[i];
        indexMax = i;
    }

    
}
Console.WriteLine($"Самый низкий курс валют= {min}\t Дата:{indexMin}\n"
    + $"Самый высокий курс валюты ={max:f2}\t Дата:{indexMax}");
Console.ReadLine();
*/

int[] array = { -5, 1, 9, 0, 4, -4, 3 };
/*
for(int i=0; i<array.Length-1;i++)
{
    for(int j=i+1;j<array.Length;j++)
    {
        if (array[i]>array[j])
        {
            int p = array[i];
            array[i] = array[j];
            array[j] = p
        }


    }
}
*/
Array.Sort(array);
foreach (int elem in array)
{
    Console.Write($"{elem}\t");
}
Console.WriteLine();
Array.Reverse(array);
foreach(int elem in array)
{
    Console.Write($"{elem}\t");
}




























