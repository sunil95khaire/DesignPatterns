namespace Prototype
{
    public class Tester : IEmployee
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone(); // shallow copy of object - top level objects are getting cloned

            //return this.Clone(); // deep copy of object - all objects are getting cloned
        }

        public string GetDetails()
        {
            return Name + Address;
        }
    }
}
