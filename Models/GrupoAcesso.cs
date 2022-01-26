namespace UsuarioPermissao.Models
{
    public class GrupoAcesso
    {

        GrupoAcesso(int id, string nome, int ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Ativo = ativo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ativo { get; set; }
    }
}