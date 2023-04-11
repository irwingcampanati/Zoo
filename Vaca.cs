namespace Zoo
{
    public class Vaca : Animal
    {
        public Vaca():base()
        {
            
        }
        public Vaca(string nome, DateTime dataNascimento, string cor, string som) 
            :base(nome, dataNascimento, cor, som)
        {
            Som = "Muuuuuuuu";
        }
        public bool EstaDoente { get; set; } = true;
    }
}