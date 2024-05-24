// See https://aka.ms/new-console-template for more information
/* Deve conter as seguintes:
    - Classes: Livro, Usuario, Biblioteca, Emprestimo.
    - 1 arquivo pra cada classe e dps importar pelo namespace (SistemaBiblioteca) pro arquivo program.cs
    -
*/
using System;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Exemplo de uso
            Livro livro1 = new Livro("C# para Iniciantes", "Autor A", "12345");
            Usuario usuario1 = new Usuario("Dani", "U001");

            biblioteca.AdicionarLivro(livro1);
            biblioteca.RegistrarEmprestimo(livro1, usuario1);

            Livro livroEncontrado = biblioteca.ConsultarLivro("12345");
            Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo}");

            biblioteca.DevolverLivro(livro1);
            Console.WriteLine($"Livro {livro1.Titulo} devolvido com sucesso.");
        }
    }
}

