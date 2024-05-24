using System;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Livro Livro { get; private set; }
        public Usuario Usuario { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public bool Concluido { get; private set; }

        public Emprestimo(Livro livro, Usuario usuario)
        {
            Livro = livro;
            Usuario = usuario;
            DataEmprestimo = DateTime.Now;
            Concluido = false;
        }

        public void Concluir()
        {
            Concluido = true;
        }
    }
}
