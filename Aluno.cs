﻿namespace Prova_2
{
    public class Aluno
    {
        public string Nome { get; protected set; }
        public double Nota1 { get; protected set; }
        public double Nota2 { get; protected set; }
        public double Media { get; protected set; }
        public int Faltas { get; protected set; }
        public string Status { get; protected set; }
        public bool SemestreFinalizado { get; protected set; }
        public Disciplina Disciplina { get; protected set; }

        public Aluno(string nome, bool semestreFinalizado, Disciplina disciplina)
        {
            SetNome(nome);
            SetSemestreFinalizado(semestreFinalizado);
            SetDisciplina(disciplina);
        }

        public void SetNome(string nome)
        { 
            Nome = nome; 
        }

        public void SetSemestreFinalizado(bool semestreFinalizado)
        {
            SemestreFinalizado = semestreFinalizado;
        }

        public void SetDisciplina(Disciplina disciplina)
        {
            Disciplina = disciplina;
        }

        public double AtribuirNota1()
        {
            Console.Write("Digite a primeira nota do aluno: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            return Nota1;
        }

        public double AtribuirNota2()
        {
            Console.Write("Digite a segunda nota do aluno: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());
            return Nota2;
        }

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2) / 2;
        }

        public double AtribuirFalta()
        {
            Console.Write("Digite o número de faltas: ");
            Faltas = Convert.ToInt32(Console.ReadLine());
            return Faltas;
        }

        public void AbonarFalta(int quantidade)
        {
            if (Faltas >= quantidade)
            {
                Faltas -= quantidade;
                Console.WriteLine($"{quantidade} falta(s) abonada(s).");
            }
            else
            {
                Console.WriteLine("Não é possível abonar mais faltas do que as que estão registradas.");
            }
        }

        public string VerificarStatus()
        {
            if (!SemestreFinalizado)
            {
                return "Semestre não finalizado";
            }

            if (Faltas > 0.25 * Disciplina.CargaHoraria)
            {
                Status = "Reprovado";
            }
            else if (Media >= 7)
            {
                Status = "Aprovado";
            }
            else
            {
                Status = "Reprovado";
            }

            return Status;
        }
    }
}

