
int[] treeAngle = new int[3];

for (int i = 0; i < treeAngle.Length; i++)
{
    Console.WriteLine($"введите длину {i + 1} стороны треугольника");
    treeAngle[i] = Convert.ToInt32(Console.ReadLine());
}

bool checkIsset()
{
    for (int i = 0; i < treeAngle.Length; i++)
    {
        if (treeAngle[i] > treeAngle[0] + treeAngle[1] + treeAngle[2] - treeAngle[i]) return false;
    }
    return true;
}

Console.Write($"Треугольник со сторонами {treeAngle[0]}, {treeAngle[1]}, {treeAngle[2]} ");
if(checkIsset()) Console.WriteLine("существует");
else Console.WriteLine("не существует");

