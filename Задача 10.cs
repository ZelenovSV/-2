    int random = new Random().Next(100, 1000);
    int SecondNamber = random - (random/100)*100;
    Console.WriteLine("Случайное число: " + random);
    Console.WriteLine("Вторая цифра: " + SecondNamber/10);
   
