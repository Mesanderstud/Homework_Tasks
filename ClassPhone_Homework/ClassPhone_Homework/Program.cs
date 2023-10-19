namespace PhoneCall
{
    class Phone
    {
        private string number;
        private string model;
        private string weight;

        public string Number { get { return number; } }
        public string Model { get { return model; } }
        public string Weight { get { return weight; } }

        public Phone(string number, string model, string weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine("Звонит " + name);
        }

        public void SendMessage(params string[] phoneNumbers)
        {
            Console.WriteLine("Отправлены сообщения на следующие номера телефонов:");
            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("8913789239", "iPhone", "150 г");
            Phone phone2 = new Phone("1382349892", "Samsung", "200 г");
            Phone phone3 = new Phone("+79812376424", "Nokia", "100 г");

            Console.WriteLine($"Номер 1 телефона: " + phone1.Number + " Модель: " +  phone1.Model + " Вес: " +  phone1.Weight);
            Console.WriteLine($"Номер 2 телефона: " + phone2.Number + " Модель: " +  phone2.Model + " Вес: " +  phone2.Weight);
            Console.WriteLine($"Номер 3 телефона: " + phone3.Number + " Модель: " +  phone3.Model + " Вес: " +  phone3.Weight);

            phone1.ReceiveCall("Лешка");
            Console.WriteLine("Номер телефона: " + phone1.Number);

            phone2.ReceiveCall("Алеша");
            Console.WriteLine("Номер телефона: " + phone2.Number);

            phone3.ReceiveCall("Алексей");
            Console.WriteLine("Номер телефона: " + phone3.Number);

            phone1.SendMessage("8913789239", "1382349892");
            phone2.SendMessage("8913789239", "1382349892", "+79812376424");
            }
    }
}