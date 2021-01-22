using System;
using _00_Biblioteca;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
           var filename = @"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado\Serializar-Deserializar\02_SerializarJSON.json";   

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(File.ReadAllText(filename));

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}",usuario.Nome, usuario.CPF, usuario.Email ); 
        }
        
    }
}
