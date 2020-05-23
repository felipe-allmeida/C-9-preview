
namespace ConsoleApp1
{
    class Person
    {
        public enum EProfiency
        {
            JuniorDeveloper,
            Developer,
            SeniorDeveloper,
            Principal
        }
        public string FirstName { get; }
        public string LastName { get; }

        public int CodeProfiency { get; set; }

        #region Positional Records
        public Person(string firstName, string lastName)
            => (FirstName, LastName) = (firstName, lastName);

        public void Deconstruct(out string firstName, out string lastName)
            => (firstName, lastName) = (FirstName, LastName);
        #endregion
    }
}
