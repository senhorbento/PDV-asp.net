namespace PDV_Generico.Models
{
    public class Usuario
    {
        public string? usuario   { get; set; }
        public string? senha     { get; set; }
        public string? funcao    { get; set; }

        public bool Login()
        {
            Usuario teste = new Usuario();
            teste.usuario = "opa";
            teste.senha = "123";

            if(this.usuario == teste.usuario && this.senha == teste.senha)
            {
                this.funcao = "Admin";
                return true;
            }
            return false;
        }
    }
}
