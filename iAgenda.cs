using System.IO;

namespace WhatsAppConsole
{
    public interface iAgenda
    {
        void Cadastrar(Contatos c);
        void Excluir(string _termo);
        void Ler();



    
    }
}