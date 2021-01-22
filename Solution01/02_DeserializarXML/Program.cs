using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;



namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader stream = new StreamReader(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado\Serializar-Deserializar\01_SerializarXML.xml");   

            XmlSerializer serealizado = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario) serealizado.Deserialize(stream);

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}",usuario.Nome, usuario.CPF, usuario.Email ); 
        }
    }
}
