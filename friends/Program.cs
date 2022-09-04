/* Задача про собаку и двух друзей из курса "Введение в программирование"
*/

// Метод подсчета, сколько раз собака пробежит от одного друга к другому, в зависимости
// от того, идут друзья навстречу друг другу или друг за другом.
void DogRunsCount(double distance, double firstFriendSpeed,
                  double secondFriendSpeed, double dogSpeed)
{
    double time = 0;
    int counter = 0;
    int RunToFirstFriend = 1;

    while (distance > 10)
    {
        if (RunToFirstFriend == 1)
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            RunToFirstFriend = 2;
        }
        else
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            RunToFirstFriend = 1;
        }
        distance = distance - time * (secondFriendSpeed + firstFriendSpeed);
        counter++;
        Console.WriteLine(counter);
    }
    Console.WriteLine($@"Собака пробежит {counter} раз от одного друга к другому, 
    прежде чем они встретятся.");
}

Console.Write("Введите расстояние между друзьями в метрах: ");
double inputDistance = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость первого друга м/мин: ");
double inputSpeedFriend1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость второго друга м/мин: ");
double inputSpeedFriend2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость собаки м/мин: ");
double inputSpeedDog = Convert.ToDouble(Console.ReadLine());

DogRunsCount(inputDistance, inputSpeedFriend1, inputSpeedFriend2, inputSpeedDog);