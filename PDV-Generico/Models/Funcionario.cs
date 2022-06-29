namespace PDV_Generico.Models
{
    public class Funcionario
    {
        public string? id           { get; set; }
        public string? nome         { get; set; }
        public string? email        { get; set; }
        public string? usuario      { get; set; }
        public string? senha        { get; set; }
        public string? funcao       { get; set; }
        public string? telefone     { get; set; }
        public string? cpf_cnpj     { get; set; }

        public bool Login()
        {
            Funcionario teste = new Funcionario();
            teste.usuario = "opa";
            teste.senha = "123";

            if (this.usuario == teste.usuario && this.senha == teste.senha)
            {
                this.funcao = "Admin";
                return true;
            }
            return false;
        }
    }
}
