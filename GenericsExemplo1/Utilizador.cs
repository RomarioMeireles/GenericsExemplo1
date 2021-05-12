using System;

namespace GenericsExemplo1
{
    public class Utilizador:Entity<Guid>
    {
        public string UserName { get; set; }
    }
}
