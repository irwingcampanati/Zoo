namespace Zoo
{
    public class Gato : Animal
    {
        public Gato() : base()
        {

        }
        public Gato(string nome, DateTime dataNascimento, string cor, string som)
            : base(nome, dataNascimento, cor, som)
        {
            Som = "Miauu";
        }
    }
}