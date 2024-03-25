namespace first21_03

{

    public class Calcifer
    {
        public string name = "Кальцифер";
        public int age = 1000;
        public string vocation = "fire demon";
        public string appereance = "a living fireball with eyes and mounth";
        public string colour = "it's usually orange and yellow";
        public string size = "varies according to type and quantity of fuel";
        public string place = "live in Hawl's castle";
        public string born = "born in the space";
        public string abilities = "Magical abilities, fiery nature, future foresigh";
        public string role = "Source of energy and driving force of the Moving Castle";
        public string personality = "Intelligent, witty, sense of humor, loyal friend";
        public string power = "fulfill the wishes of his master";
        public string charm = "Cheerful and eccentric personality, popular with viewers";
        public string emotion = "Prone to occasional mood";
        public string wisdom = "Prossesses great wisdom and insight";

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
            Random random = new Random();
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
