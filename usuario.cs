using System;

/*Aqui está sendo criada uma classe chamada Usuario que representa um usuário do sistema de biblioteca.
A classe possui duas propriedades, Nome e IdUsuario, que permitem obter e definir o nome e o ID do usuário.
Além disso, a classe possui um construtor que inicializa uma nova instância da classe com o nome e o ID especificados.
Essa classe é um exemplo básico de programação orientada a objetos (POO) em C#.
*/

namespace SistemaBiblioteca
{
    /// <summary>
    /// Representa um usuário do sistema de biblioteca.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Obtém ou define o nome do usuário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o ID do usuário.
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe Usuario com o nome e ID especificados.
        /// </summary>
        /// <param name="nome">O nome do usuário.</param>
        /// <param name="idUsuario">O ID do usuário.</param>
        public Usuario(string nome, string idUsuario)
        {
            Nome = nome;
            IdUsuario = idUsuario;
        }
    }
}
