int[] array = {33, 43, 45, 65, 32, 13, 43, 12};


int n = array .Length;
int find = 43;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}