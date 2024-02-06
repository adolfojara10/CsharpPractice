namespace InterfaceSegregation
{
    public interface IActivities: IWorkingActivities, IDesignActivities, IDeveloperActivities, ITesterActivities
    {
        new void Plan();
        new void Comunicate();
        new void Design();
        new void Develop();
        new void Test();
    }
}