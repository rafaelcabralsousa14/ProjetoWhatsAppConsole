using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WhatsAppConsole
{
    public class Agenda : iAgenda
    {
        public List<Contatos> contato;

        private const string PATH = "Database/contatos.csv"; 

        private string PrepararLinha(Contatos c){
            return $"\nNome:{c.Nome};Telefone:{c.Telefone}";
        }

        public void Cadastrar(Contatos c){
            string[] linha = new string[] {PrepararLinha(c)};
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(string _termo){
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(PATH)){
                string linha;
                while((linha = file.ReadLine()) != null){
                    linhas.Add(linha);
                }
                linhas.RemoveAll(z => z.Contains(_termo));
            }

            using(StreamWriter output = new StreamWriter(PATH)){
                output.Write(String.Join(Environment.NewLine, linhas.ToArray()));
            }
        } 

        public void Ler(){
            List<Contatos> cont = new List<Contatos>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (string linha in linhas)
            {
                string[] dado = linha.Split(";"); 
            
                Contatos c = new Contatos();
                c.Nome = Separar(dado[0]);
                c.Telefone = Separar(dado[1]);

                cont.Add(c);
                System.Console.WriteLine($"{c}");
            }         
        }

        public string Separar(string dado){
            return dado.Split(':')[1];
        }



    }
}