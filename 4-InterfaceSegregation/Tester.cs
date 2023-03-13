namespace InterfaceSegregation
{
    public class Tester : ITestActivities , IWorkingActivities
    {
        public Tester()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }


        public void Test() 
        {
            Console.WriteLine("I'm testing the application");
        }
    }
}