using System;

/*
Esse código define uma classe chamada "Livro" que representa um livro em um sistema de biblioteca. 
A classe possui propriedades para armazenar o título, autor, editora e disponibilidade do livro. 
Além disso, possui um construtor que permite criar uma nova instância do livro com o título, autor e editora especificados.
*/

namespace SistemaBiblioteca
{

    /// <summary>
    /// Representa um livro.
    /// </summary>
    public class Livro
    {
        /// <summary>
        /// Obtém ou define o título do livro.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Obtém ou define o autor do livro.
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Obtém ou define a editora do livro.
        /// </summary>
        public string Editora { get; set; }

        /// <summary>
        /// Obtém ou define um valor que indica se o livro está disponível ou não.
        /// </summary>
        public bool Disponivel { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Livro"/> com o título, autor e editora especificados.
        /// </summary>
        /// <param name="titulo">O título do livro.</param>
        /// <param name="autor">O autor do livro.</param>
        /// <param name="editora">A editora do livro.</param>
        public Livro(string titulo, string autor, string editora)
        {
             Titulo = titulo;
             Autor = autor;
            Editora = editora;
            Disponivel = true;
        }
     }  
 }
