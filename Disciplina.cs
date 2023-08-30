namespace Prova_2
{
    public class Disciplina
    {
        public string NomeDisciplina { get; set; }
        public int CargaHoraria { get; set; }

        public Disciplina(string nomeDisciplina, int cargaHoraria)
        {
            NomeDisciplina = nomeDisciplina;
            CargaHoraria = cargaHoraria;
        }
    }
}
