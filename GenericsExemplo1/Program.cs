using System;
using System.Collections.Generic;

namespace GenericsExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region teste1
            //List<int> numeros = new List<int>();
            //numeros.Add(1);
            //numeros.Add(2);
            //numeros.Add(3);

            //foreach(var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> nomes = new List<string>();
            //nomes.Add("Romario");
            ////nomes.Add(1)

            //List<object> lista = new List<object>();
            //lista.Add("Romário");
            //lista.Add(2021);

            //foreach(var item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            var pf = new Professor()
            {
                DataRegisto=DateTime.Now,
                Nome="Admilson Meireles",
                Numero="12345",
                Id=1
            };
            Console.WriteLine("-------------Professor------------");
            Console.WriteLine($"Id: {pf.Id}\nNome: {pf.Nome}\nNumero: {pf.Numero}\nData: {pf.DataRegisto}");
            pf.Executar(pf);
            Console.WriteLine("-------------Estudante------------");
            var et = new Estudante()
            {
                DataRegisto = DateTime.Now,
                Nome = "Romário Meireles",
                NumeroMatricula = "1000",
                Id = 1
            };

            Console.WriteLine($"Id: {et.Id}\nNome: {et.Nome}\nNumero: {et.NumeroMatricula}\nData: {et.DataRegisto}");
            pf.Executar(et);
            Console.WriteLine("-------------Utilizador------------");
            var ut = new Utilizador()
            {
                DataRegisto = DateTime.Now,
                Nome = "Romário Meireles",
                UserName = "rmeireles",
                Id = Guid.NewGuid()
            };

            Console.WriteLine($"Id: {ut.Id}\nNome: {ut.Nome}\nUserName: {ut.UserName}\nData: {ut.DataRegisto}");
            pf.Executar(ut);
        }
    }
}
