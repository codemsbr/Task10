using Task10.Class;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller userController = new Controller();
            int userAnswer = 0;
            do
            {
                userController.Menu();
                userAnswer = Convert.ToInt32(Console.ReadLine());
                switch (userAnswer)
                {
                    case 1:
                        userController.CreateCar();
                        break;
                    case 2:
                        userController.CreateBicycle();
                        break;
                    case 3:
                        userController.CreatePlane();
                        break;
                    case 4:
                        userController.GetAll();
                        break;
                    case 5:
                        Console.Write("Enter Remove Index : ");
                        userController.RemoveIndex(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (userAnswer != 6);
        }
    }
}