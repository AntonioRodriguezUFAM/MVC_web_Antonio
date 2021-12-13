using System.IO;

namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        // Criar uma funcao para criar a pasta e o Arquivo.
        // String path e o parametro da funcao, que tera o caminho
        // para analise
        public void CreateFolderAndFile(string path)
        {
            // Pasta / Arquivo.csv;
            string folder = path.Split('/')[0];
            string file =path.Split('/')[1];

            // Se nao existir criar a pasta.
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(file))
            {
                File.Create(path);
            }
        }
    }
}
