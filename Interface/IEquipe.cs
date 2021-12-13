using E_JOGOS.Models;

namespace E_JOGOS.Interface
{
    // Summary:
    // Responsavel por determinar quais metos uma classe Terra
    // e O contrato da Clase.
    public interface IEquipe
    {
        //Create
        void Create(Equipe nova_equipe);

        //Readall
        list<Equipe> ReadAll();

        //Update
        void Upadate(Equipe equipe);
        //Delete
        void Delete(int IdEquipe);
    }
}
