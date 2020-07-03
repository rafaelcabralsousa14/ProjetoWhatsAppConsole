namespace WhatsAppConsole
{
    public class Mensagens
    {
        public Contatos Destinatario { get; set; }
        public string Texto { get; set; }

        public string Enviar(Contatos c){
            return $"Mensagem '{Texto}' enviada para {c}";
        }
    }
}