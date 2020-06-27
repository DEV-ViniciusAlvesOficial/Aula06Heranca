namespace Aula06Heranca
{
    public class CPF : Pessoa  
    //CPF não existe se a pessoa não existir /CPF faz parte da pessoa
    {
        public string cpf;
        public string rg;

        public bool validarCPF(){
            if(cpf != null){
            return true;
            }
            else{
            return false;
            }
        }
    }
}