namespace PDV_Generico.Models
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public bool Login()
        {
            Usuario teste = new Usuario();
            teste.usuario = "opa";
            teste.senha = "123";

            if(this.usuario == teste.usuario && this.senha == teste.senha)
            {
                return true;
            }
            return false;
        }
    }
}
