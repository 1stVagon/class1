namespace first21_03

{

    public class Methods
    {
        public void ChangeColor()
        {
            Random random = new Random();

            // Генерируем случайные значения R, G, B для создания цвета
            int red = random.Next(2) == 0 ? 0 : 255;
            int green = random.Next(2) == 0 ? 0 : 255;
            int blue = random.Next(2) == 0 ? 0 : 255;

            if (green == 255)
            {
                red = 0;
                blue = 0;
            }

            if (blue == 255)
            {
                red = 0;
                green = 0;
            }

            if (red == 255)
            {
                green = 0;
                blue = 0;
            }

            if (red == 255 && green == 0 && blue == 0)
                Console.WriteLine("Цвет Кальцифера: Красный");
            else if (red == 0 && green == 255 && blue == 0)
                Console.WriteLine("Цвет Кальцифера: Зеленый");
            else if (red == 0 && green == 0 && blue == 255)
                Console.WriteLine("Цвет Кальцифера: Синий");

        }
        public void MovingHouse(int engine)
        {
            if (engine == 0)
                Console.WriteLine("Увы, но мы стоим!");
            else if (engine == 1)
                Console.WriteLine("Кальцифер зажег двигатель! Едем дальше!");
        }
        public void HeatOven()
        {

        }
    }
}