using Prova_2;

class Program
{
    static void Main(string[] args)
    {
        Disciplina disciplina = new Disciplina("Álgebra", 80);

        Aluno aluno = new Aluno("Fulano", true, disciplina);

        aluno.AtribuirNota1();
        aluno.AtribuirNota2();
        aluno.CalcularMedia();
        aluno.AtribuirFalta();
        aluno.VerificarStatus();

        Console.WriteLine($"O aluno {aluno.Nome} está {aluno.Status} na disciplina {disciplina.NomeDisciplina}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
