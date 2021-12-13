using E_JOGOS.Interface;
using System.IO;

namespace E_JOGOS.Models
{
    public class Equipe: EjogosBase, IEquipe
    {
        // Constructor - E Jogos
        private const string path = "Database/equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        } 


        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Image { get; set; }

        // Funcoa que vai preparar /convert de string para o tipe Equipe
        // private string

        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Image}";
        }


        public void Create(Equipe nova_equipe)
        {
            //receber um objeto de equipe.
            //e gravar no CSV.
            //

            //  "item;item;item;";

            string[] linha = { Prepare(nova_equipe) };

            File.AppendAllLines(path, linha);
        }

        /*
        public void Create(Equipe nova_equipe)
        {
            // Receber um objeto de Equipe.
            // e Gravar no CSV.

            // 
            string [] linha = { $"{nova_equipe.IdEquipe};{nova_equipe.Nome};{nova_equipe.Image}" };

            File.AppendAllLines(path, linha);
        }
        */

        public void Delete(int IdEquipe)
        {
            throw new System.NotImplementedException();
        }

        public list<Equipe> ReadAll()
        {
            list<Equipe> equipes = new list<Equipe>();
            string [] linhas =File.ReadAllLines(path);
            foreach(string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = item.Split(';')[1];
                equipe.Image = item.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;

        }

       
        public void Upadate(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}

