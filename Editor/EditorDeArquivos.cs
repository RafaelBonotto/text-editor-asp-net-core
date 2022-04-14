using System;
using System.IO;

namespace Editor
{
    public class EditorDeArquivos
    {
        public void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu menu = new();
            menu.ExibirMenu();
        }

        public void Editar()
        {

        }
    }
}
