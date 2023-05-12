using System;

namespace Laba_12_W
{

    class EventDelegateClass
    {
        private string name;

        public delegate void EventDelegate(string txt);
        public EventDelegateClass(string name)
        {
            this.name = name;
        }
        public event EventDelegate Event; 
        public void RaiseMyEvent()
        { 
            if (Event != null)
            {
                Event(name);
            }
        }
    }
    class KaClass
    { 
        private string text;
        public KaClass(string metodtext)
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
            EventDelegateClass kaOdject1 = new EventDelegateClass("KaOdject1");
            EventDelegateClass kaOdject2 = new EventDelegateClass("KaOdject2");
           
            KaClass KaClassObject = new KaToClass("KaClassObject");

            kaOdject1.Event += KaClassObject.show;
            kaOdject2.Event += KaClassObject.show;

            kaOdject1.RaiseMyEvent();
            Console.WriteLine();

            kaOdject2.RaiseMyEvent();
            Console.WriteLine();
        }
    }
}
