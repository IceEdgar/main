int[] array = { 1, 2, 3, 4, 66, 33, 6, 66 };

int n = array.Length;
int find = 66;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index+1;
    index++;
}
