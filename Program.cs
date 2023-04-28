using System;

namespace Laba_12_W
{

    class EventDelClass
    {
        private string name;

        public delegate void EventDel(string txt);
        public EventDelClass(string name)
        {
            this.name = name;
        }
        public event EventDel Event; 
        public void RaiseMyEvent()
        { 
            if (Event != null)
            {
                Event(name);
            }
        }
    }
    class Prekol
    { 
        private string text;
        public Prekol(string metodtext)
        {
            text = metodtext;
        }
        public void show(string objname)
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text);
        }
    }
    class Program
    {
        static void Main()
        {
            EventDelClass prekolObject1 = new EventDelClass("prekolObject1");
            EventDelClass prekolObject2 = new EventDelClass("prekolObject2");
           
            Prekol chtotozaPrekol = new Prekol("chtotozaPrekol");

            prekolObject1.Event += chtotozaPrekol.show;
            prekolObject2.Event += chtotozaPrekol.show;

             prekolObject1.RaiseMyEvent();
            Console.WriteLine();

             prekolObject2.RaiseMyEvent();
            Console.WriteLine();
        }
    }
}
