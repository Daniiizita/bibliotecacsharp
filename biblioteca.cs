using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        private List<Livro> Livros { get; set; } = new List<Livro>();
        private List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        private List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public Livro ConsultarLivro(string titulo)
        {
            return Livros.FirstOrDefault(l => l.Titulo == titulo);
        }

        public void RegistrarEmprestimo(Livro livro, Usuario usuario)
        {
            if (livro.Disponivel)
            {
                livro.Disponivel = false;
                Emprestimos.Add(new Emprestimo(livro, usuario));
            }
            else
            {
                Console.WriteLine("Livro indisponível.");
            }
        }

        public void DevolverLivro(Livro livro)
        {
            var emprestimo = Emprestimos.FirstOrDefault(e => e.Livro == livro && !e.Concluido);
            if (emprestimo != null)
            {
                livro.Disponivel = true;
                emprestimo.Concluir();
            }
        }
    }
}
