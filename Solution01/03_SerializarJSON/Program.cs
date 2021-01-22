using System;
using System.Web;
using _00_Biblioteca;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
              Usuario usuario = new Usuario(){
               Nome = "Maria",
               CPF = "222.333.22",
               Email = "maria@teste.com.br" };

            string json = JsonConvert.SerializeObject(usuario, Formatting.Indented);

            StreamWriter sw = new StreamWriter(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado\Serializar-Deserializar\02_SerializarJSON.json");

              
            sw.WriteLine(json);

            sw.Close();


            // serializador = new JavaScriptSerializer();
            //string stringObjSerializado = serializador.Serealize(usuario);
            
            //StreamWriter sw = new StreamWriter(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado\Serializar-Deserializar\02_SerializarJSON.json");
            //sw.WriteLine(stringObjSerializado);
        
        }
    }
}
