int[] array = { 13, 22, 3, 42, 54, 66, 37, 18, };
int n = array.Lenght;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(array[index]);
        break;
    }
    index = index++;
}