using App;

int[] ints = { 1, 9, 5, 0, 20, -4, 12, 16, 7 };

var sum = 12;

var sumNumbers = new SumNumbers();

var numbers = sumNumbers.GetSumNumbers(ints, sum);

foreach(var item in numbers)
{
    Console.WriteLine($"{item.Key},{item.Value}");  
}








