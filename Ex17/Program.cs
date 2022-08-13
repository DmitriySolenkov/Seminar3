Console.WriteLine("ВВедите координату оси Х: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите координату оси Y: ");
int numY = Convert.ToInt32(Console.ReadLine());
if (numX!=0 && numY!=0)
{
    if (numX>0)
    {
        if(numY>0) Console.WriteLine("Точка находится в 1-ой четверти");
        else Console.WriteLine("Точка находится в 4-ой четверти");
    }
    if (numX<0)
    {
        if(numY>0) Console.WriteLine("Точка находится в 2-ой четверти");
        else Console.WriteLine("Точка находится в 3-eй четверти");
    }
}
else Console.WriteLine("Одна из координат равна 0!");