namespace UsuarioPermissao.Models
{
    public class Usuarios
    {

        Usuarios(int id, string nome, string email, string password, int ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Ativo = ativo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Ativo { get; set; }
    }
}