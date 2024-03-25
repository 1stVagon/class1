namespace first21_03
{
    public class Person
    {
        public string name = "Calcifier";
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

        public void Print()
        {
            Console.WriteLine(
                $"\nName: {name}" +
                $"\nAge: {age}" +
                $"\nVocation: {vocation}" +
                $"\nAppereance: {appereance}" +
                $"\nColour: {colour}" +
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

        public void StartMovingCastle()
        {
            Console.WriteLine("Calcifer brings the Moving Castle to life.");
        }

        public void AssistInAdventures(string prediction)
        {
            Console.WriteLine($"Calcifer predicts: {prediction}");
        }

        public void FulfillWish(string wish)
        {
            Console.WriteLine($"Calcifer grants the wish: {wish}");
        }

        public void PlayfulBanter()
        {
            Console.WriteLine("Calcifer jokes and teases, creating a lively atmosphere.");
        }

        public void ShowDevotion()
        {
            Console.WriteLine("Calcifer shows loyalty and readiness to sacrifice for his friends.");
        }

        public string wish = "";

    }
}
