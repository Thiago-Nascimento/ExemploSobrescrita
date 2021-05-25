namespace ExemploSobrescrita.Classes
{
    public abstract class Player
    {
        private float Velocidade;
        private float ForcaPulo;

        public virtual string Correr() {
            return "O Player correu!";
        }

        public virtual string Pular() {
            return "O Player pulou!";
        }
    }
}