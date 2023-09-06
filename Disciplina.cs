namespace Prova_2
{
    public class Disciplina
    {
        public string NomeDisciplina { get; protected set; }
        public int CargaHoraria { get; protected set; }

        public Disciplina(string nomeDisciplina, int cargaHoraria)
        {
            SetNomeDisciplina(nomeDisciplina);
            SetCargaHoraria(cargaHoraria);
        }

        public void SetNomeDisciplina(string nomeDisciplina)
        {
            NomeDisciplina = nomeDisciplina;
        }

        public void SetCargaHoraria(int cargaHoraria)
        {
            CargaHoraria = cargaHoraria;
        }
    }
}
