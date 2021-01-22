using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;


namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario usuario = new Usuario(){
               Nome = "Jose",
               CPF = "222.222.22",
               Email = "jose@teste.com.br" };

               XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

                
               StreamWriter stream = new StreamWriter(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado\Serializar-Deserializar\01_SerializarXML.xml");
               
               serializador.Serialize(stream, usuario);
          
        }
    }
}
