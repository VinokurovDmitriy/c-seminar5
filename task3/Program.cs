int n = Convert.ToInt32(Console.ReadLine());
string str = "";
int count = 0;
while(n > 0)
{
    str += "" + n % 2;
    n /= 2;
    count++;
}

char[] array = str.ToCharArray();

void revertArray()
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        char temp = array[i];
        array[i] = array[^(i + 1)];
        array[^(i + 1)] = temp;
    }
}

void printRevert()
{
    for(int i = str.Length - 1; i >= 0; i--)
    {
        Console.Write(str[i]);
    }
    Console.WriteLine();
}
printRevert();
revertArray();
Console.WriteLine(array);