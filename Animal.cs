﻿namespace Zoo
{
    public class Animal
    {
        public Animal()
        {
            Nome = "";
            DataNascimento = new DateTime();
            Cor = "";
        }
        public Animal(string nome, DateTime DataNascimento,string cor, string som)
        {
            Nome = nome;
            DataNascimento = DataNascimento;
            Cor = cor;
            Som = som;
        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cor { get; set; }
        public string Som { get; set; }
    }
}