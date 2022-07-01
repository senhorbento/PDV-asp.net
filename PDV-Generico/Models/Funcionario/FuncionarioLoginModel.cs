namespace PDV_Generico.Models.Funcionario
{
    public class FuncionarioLoginModel
    {
        public string? usuario { get; set; }
        public string? senha { get; set; }
        public string? funcao { get; set; }

        public bool Login()
        {
            FuncionarioLoginModel teste = new FuncionarioLoginModel();
            teste.usuario = "opa";
            teste.senha = "123";

            if (usuario == teste.usuario && senha == teste.senha)
            {
                funcao = "Admin";
                return true;
            }
            return false;
        }
    }
}
