namespace WhatsAppConsole
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        
        public Contatos(){
            
        }

        public Contatos(string _nome, string _telefone){
            this.Nome = _nome;
            this.Telefone = _telefone;
        }
    }
}