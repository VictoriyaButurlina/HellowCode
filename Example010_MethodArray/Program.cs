int [] array = {1, 26, 56, 35, 34, 56, 6, 76, 8, 9};

int n = array.Length;

int find = 56;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
