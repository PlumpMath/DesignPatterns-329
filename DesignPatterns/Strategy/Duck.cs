namespace DesignPatterns.Strategy
{
    public abstract class Duck 
    {
        public FlyBehaviour flyBehaviour { get; set; }
        public QuackBehaviour QuackBehaviour { get; set; }

        public Duck()
        {
        }

        public void SetFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehaviour(QuackBehaviour qc)
        {
            QuackBehaviour = qc;
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public abstract void Display();

        public void Swim()
        {
            System.Console.WriteLine("Hey Buddy I am Swimming");
        }
    }
}