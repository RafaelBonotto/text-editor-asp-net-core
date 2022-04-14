using System;

namespace Editor
{
    public class Menu
    {
        public void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());
            EditorDeArquivos editorDeArquivos = new();

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: editorDeArquivos.Abrir(); break;
                case 2: editorDeArquivos.Editar(); break;
                default: this.ExibirMenu(); break;
            }
        }
    }
}
