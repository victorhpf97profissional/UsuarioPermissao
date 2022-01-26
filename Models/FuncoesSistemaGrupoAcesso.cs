namespace UsuarioPermissao.Models
{
    public class FuncoesSistemaGrupoAcesso
    {

        FuncoesSistemaGrupoAcesso(int funcoesSistemaId, int grupoAcessoId, string privilegios, int ultimaAlteracao, int alteradoPor)
        {
            this.FuncoesSistemaId = funcoesSistemaId;
            this.GrupoAcessoId = grupoAcessoId;
            this.Privilegios = privilegios;
            this.UltimaAlteracao = ultimaAlteracao;
            this.AlteradoPor = alteradoPor;
        }

        public int FuncoesSistemaId { get; set; }
        public int GrupoAcessoId { get; set; }
        public string Privilegios { get; set; }
        public int UltimaAlteracao { get; set; }
        public int AlteradoPor { get; set; }

    }
}