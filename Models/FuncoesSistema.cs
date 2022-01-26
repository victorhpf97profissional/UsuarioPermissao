namespace UsuarioPermissao.Models
{
    public class FuncoesSistema
    {

        FuncoesSistema(int id, int codigo, int funcoesSistemaId_PAI, string nome, string descricao)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.FuncoesSistemaId_PAI = funcoesSistemaId_PAI;
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public int Id { get; set; }
        public int Codigo { get; set; }
        public int FuncoesSistemaId_PAI { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}