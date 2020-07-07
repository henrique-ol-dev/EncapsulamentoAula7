namespace Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set;}
        public string titular { get; set;}
        public string bandeira { get; set;}
        public string token= "a33afr66qa6fg6sda6h6h6a4d6ahnj6f";
        public string cvv { get; set;}

        public string aprovarCompra(){
            return "compra aprovada";
        }

            private bool validarToken(){
            if(token!=null){
                return true;

            }
                return false;
           }

           protected bool validarCompra(){
               return true;
           }

    }
}