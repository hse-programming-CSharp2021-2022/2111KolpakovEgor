using System;

namespace _04_02
{
    public abstract class Creature
    { 
        public string Name { get; private set; }
        public Creature(string s, string l) { Name = s; Location = l; }
        public string Location { get; private set; }
        public abstract void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e);
    }
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        public string Message { get; set; }
    }

    public class Wizard
    {
        public string Name { get; private set; }

        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) { Name = s; }
        public Wizard() { }
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }

    public class Hobbit: Creature
    {
        public Hobbit(string s, string l) : base(s,l) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Сейчас нахожусь в {Location}");
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }
    public class Human: Creature
    {
        public Human(string s, string l) : base(s, l) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Сейчас нахожусь в {Location}");
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
        }
    }
    public class Elf: Creature
    {  
        public Elf(string s, string l) : base(s, l) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Сейчас нахожусь в {Location}");
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    }
    public class Dwarf: Creature
    { 
        public Dwarf(string s, string l) : base(s, l) { }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Сейчас нахожусь в {Location}");
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");

            Creature[] creatures = new Creature[8];

            creatures[0] = new Hobbit("Фродо", "Напад");
            creatures[1] = new Hobbit("Сэм", "Напад");
            creatures[2] = new Hobbit("Пипин", "Напад");
            creatures[3] = new Hobbit("Мэри", "Напад");
            creatures[4] = new Human("Боромир", "Ивановка");
            creatures[5] = new Human("Арагорн", "Ивановка");
            creatures[6] = new Dwarf("Гимли", "Норвинд");
            creatures[7] = new Elf("Легалос", "Лес");

            foreach (var h in creatures)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;

            wizard.SomeThisIsChangedInTheAir();
        }
    }
}
