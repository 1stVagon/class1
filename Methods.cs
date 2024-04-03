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
            {
                Console.Write("Цвет Кальцифера: ");
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine("Красный");
                Console.ResetColor(); // сбрасываем в стандартный
            }    
            else if (red == 0 && green == 255 && blue == 0)
            {
                Console.Write("Цвет Кальцифера: ");
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine("Зеленый");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else if (red == 0 && green == 0 && blue == 255)
            {
                Console.Write("Цвет Кальцифера: ");
                Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
                Console.WriteLine("Синий");
                Console.ResetColor(); // сбрасываем в стандартный
            }

        }
        public void MovingHouse(int engine)
        {
            if (engine == 0)
                Console.WriteLine("Увы, но мы стоим!");
            else if (engine == 1)
                Console.WriteLine("Кальцифер зажег двигатель! Едем дальше!");
        }
        public void Dialog1()
        {
            Console.WriteLine("— Иди ляг, придурок, — сонно промычал Кальцифер. — Ты же пьян в стельку.");
            Console.WriteLine("\n1. — Кто, я?"+
                "\n2. - Не правда!" +
                "\n3. - Я трезв");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("— Кто, я? — оскорбился Хоул. — Заверяю вас, друзья мои, я тре тер тверез как стеклышко!" +
                    " — И он поднялся и побрел наверх, держась за перила, словно боялся, что стоит их отпустить — и они куда-нибудь денутся." +
                    " Дверь спальни ловко увернулась от него. — Какое гнусное коварство! — заметил чародей, натыкаясь на стену." +
                    " – Спасением мне станет мое сиятельное бесчестье и леденящая душу злобность — Он еще несколько раз наткнулся на стену — в разных местах, а потом наконец обнаружил дверь спальни и вломился в нее. " +
                    "Софи было слышно, как он там падает на пол, жалуясь, что кровать постоянно отпрыгивает в сторону.");
            }
            else if (choose == 2)
            {
                Dialog1();
            }
            else if (choose == 3)
            {
                Dialog1();
            }
        }
        public void AddLogs()
        {
            Console.Write("Введиет количество бревен которое хотите подбросить: ");
            int addLogs = Convert.ToInt32(Console.ReadLine());
            if (addLogs > 0)
                Console.WriteLine("Поехали");
            else
            {
                Console.WriteLine("Стоим!");
                AddLogs();
            }
        }
        public void FiresPower()
        {
            Console.WriteLine("Скажите что-нибудь кадьциферу!" + "\n1.bebebe" + "\n2. ути мой сладкий");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
                Console.WriteLine("Вы усилили пыл Кальцифера!");
                FiresPower();
            }
            else if (choose == "2")
            {
                Console.WriteLine("Вы уменьшили пыл Кальцифера!");
                FiresPower();
            }
        }
    }
}