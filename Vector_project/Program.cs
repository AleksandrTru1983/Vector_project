
namespace Vector_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(11, 22, 33);
            Vector vector1 = new Vector(44, 33, 66);

            Console.WriteLine($"Длина вектора: {vector.GetLenght()}");
            Console.WriteLine($"Скалярное произведение: { vector.ScalarSumm(vector, vector1)}");
            Console.WriteLine($"Векторное произведение: {vector.CrossProduct(vector,vector1)}");
            Console.WriteLine($"Угол между векторами: {vector.GetCos(vector,vector1)}");
            Console.WriteLine($"Сумма векторов: {vector.GetSumm(vector,vector1)}");
            Console.WriteLine($"разность векторов: {vector.GetMinus(vector, vector1)}");         
        }

    }
}






    
   



