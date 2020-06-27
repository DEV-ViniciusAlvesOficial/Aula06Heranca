namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
         public string cnpj;

         public bool validarCNPJ(){
             if(cnpj != null){
                 return true;
             }
             else{
                 return false;
             }
         } 
    }
}