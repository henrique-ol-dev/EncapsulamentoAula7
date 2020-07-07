namespace Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get ; set ;}
          public string ComprarComDescontoMastercard(float desconto){
            
            cvv="456";
            
            return "Compra realizada com " + parcelas + " parcelas e com  R$" + desconto + " de desconto";
          }
    }
}