namespace InterfaceSegregation
{
    public class Architect : IWorkingActivities, IDesignActivities, IDeveloperActivities, ITesterActivities
    {
        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

        void IWorkingActivities.Comunicate()
        {
            throw new NotImplementedException();
        }

        void IWorkingActivities.Plan()
        {
            throw new NotImplementedException();
        }
    }
}