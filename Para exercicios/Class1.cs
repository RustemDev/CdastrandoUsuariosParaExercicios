using System;
using System.Collections.Generic;
namespace Para_exercicios
{
    public class Class1
    {
        static void Main(string[] args)
        {

            List<string> usuarios = new List<string>();
            List<string> nomes = new List<string>();

            Console.WriteLine("Escreva quantos usuarios vc quer cadastrar ");
            int quantdeusuarios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes dos usuarios ");


            for (int i = 0; i < quantdeusuarios; i++)
            {
                usuarios.Add(Console.ReadLine());
            }

            Console.WriteLine("Os usuarios escolhidos foram " + quantdeusuarios);

            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine(usuarios[i]);
            }


            Console.WriteLine("Digite quantos nomes que você quer adicionar ");
            int quantdenomes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os nomes ");

            for (int i = 0; i < quantdenomes; i++)
            {
                nomes.Add(Console.ReadLine());

            }

            Console.WriteLine("Os nomes escolhidos foram ");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine("Usuarios inseridos, bom dia! ");

            Console.ReadLine();





            List<string> frutas = new List<string>();

            Console.WriteLine("Digite o numero de frutas que vc ira levar");
            int quantdefrutas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes das frutas escolhidas");

            for (int i = 0; i < quantdefrutas; i++)
            {
                frutas.Add(Console.ReadLine());

            }

            Console.WriteLine("AS frutas foram escolhidas" + quantdefrutas);

            for (int i = 0; i < frutas.Count; i++)
            {
                Console.WriteLine(frutas[i]);
            }

            Console.WriteLine("Frutas escolhidas obrigado!");

            Console.ReadLine();

            List<string> clientes = new List<string>();


            Console.WriteLine("Escreva quantos usuarios vc quer cadastrar ");
            int clientsm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes dos usuarios ");


            for (int i = 0; i < clientsm; i++)
            {
                clientes.Add(Console.ReadLine());


            }

            Console.WriteLine("Os usuarios escolhidos foram " + quantdeusuarios);

            for (int i = 0; i < usuarios.Count; i++) 
            {
                Console.WriteLine(usuarios[i]);
            }

            List<string> nomes2 = new List<string>();

            Console.WriteLine("Digite os nomes que você quer adicionar");
            int nomesclient = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os nomes");

            for (int i = 0; i < nomesclient; i++)
            {
                nomes2.Add(Console.ReadLine());

            }



            Console.ReadLine();
        }
    }
}
