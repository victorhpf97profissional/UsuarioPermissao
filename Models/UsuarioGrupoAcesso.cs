namespace UsuarioPermissao.Models
{
    public class UsuarioGrupoAcesso
    {

        UsuarioGrupoAcesso(int usuarioId, int grupoAcessoId, int ativo, int ultimaAlteracao, int alteradoPor)
        {
            this.UsuarioId = usuarioId;
            this.GrupoAcessoId = grupoAcessoId;
            this.Ativo = ativo;
            this.UltimaAlteracao = ultimaAlteracao;
            this.AlteradoPor = alteradoPor;
        }

        public int UsuarioId { get; set; }
        public int GrupoAcessoId { get; set; }
        public int Ativo { get; set; }
        public int UltimaAlteracao { get; set; }
        public int AlteradoPor { get; set; }
    }
}