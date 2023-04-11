namespace Zoo
{
    public class Cachorro : Animal
    {
        public Cachorro() : base()
        {

        }
        public Cachorro(string nome, DateTime dataNascimento, string cor, string som)
            : base(nome, dataNascimento, cor, som)
        {
            Som = "Au Au Au";
        }
        public bool TemMancha { get; set; } = true;
    }
}