namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Comunicate()
        {
                        Console.WriteLine("I'm talking to the team user");

        }

        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}