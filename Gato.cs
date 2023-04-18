namespace Zoo
{
    public class Gato : Animal
    {
        public Gato() : base()
        {
            Som = "Miauu";
        }
        public Gato(string nome, DateTime dataNascimento, string cor, string som)
            : base(nome, dataNascimento, cor, som)
        {
            Som = "Miauu";
        }
    }
}