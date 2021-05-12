using System;

namespace GenericsExemplo1
{
    public abstract class Entity<T> where T:struct
    {
        public T Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataRegisto { get; set; }

        public void Executar<E>(E item)where E:class
        {
            Console.WriteLine($"Classe especializada: {item.ToString()}");
        }
    }
}
