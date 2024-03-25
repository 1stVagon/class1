namespace first21_03

{

    public class Calcifer
    {
        public string name = "Кальцифер";
        public int age = 1000;
        public string vocation = "огненный демон";
        public string appereance = "живой огненный шар с глазами и ртом";
        public string color = "обычно оранжево-желтый";
        public string size = "варьируется в зависимости от типа и количества топлива";
        public string place = "живет в замке Хаула";
        public string born = "рожден в пространстве";
        public string abilities = "Магические способности, огненная природа, видение будущего";
        public string role = "Источник энергии и движущая сила Бродячего замка";
        public string personality = "Умный, находчивый, чувство юмора, верный друг";
        public string power = "выполнить желания своего хозяина";
        public string charm = "Веселая и эксцентричная личность, популярная у зрителей";
        public string emotion = "склонен к временным перепадам настроения";
        public string wisdom = "обладает великой мудростью и пониманием";


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
        public void MovingHouse(int on_off)
        {
            int engine = on_off;

            if (engine == 0)
                Console.WriteLine("Увы, но мы стоим!");
            else if (engine == 1)
                Console.WriteLine("Кальцифер зажег двигатель! Едем дальше!");
        }
        public void HeatOven()
        {


        }
        public void Print()
        {
            Console.WriteLine(
                $"\nName: {name}" +
                $"\nAge: {age}" +
                $"\nVocation: {vocation}" +
                $"\nAppereance: {appereance}" +
                $"\nColor: {color}" +
                $"\nSize: {size}" +
                $"\nPlace: {place}" +
                $"\nBorn: {born}" +
                $"\nAbilities: {abilities}" +
                $"\nRole: {role}" +
                $"\nPersonality: {personality}" +
                $"\nPower: {power}" +
                $"\nCharm: {charm}" +
                $"\nEmotion: {emotion}" +
                $"\nWisdom: {wisdom}");
        }

    }
}
