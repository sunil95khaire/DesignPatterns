namespace Prototype
{
    public interface IEmployee
    {
        IEmployee Clone();

        string GetDetails();
    }
}
