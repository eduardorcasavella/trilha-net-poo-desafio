namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //FEITO!
    public class Nokia : Smartphone //Herdando de Smartphone
    {
        //Construtor que invoca o construtor da classe base
        public Nokia(string numero,string modelo,string imei,int memoria):base(numero,modelo,imei,memoria)
        {
           
        }
               
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //Feito!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp + " no Nokia...\n");            
        }
    }
}