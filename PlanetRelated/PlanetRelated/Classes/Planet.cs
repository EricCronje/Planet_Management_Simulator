namespace PlanetRelated.Classes
{
    public class Planet
    {
        private string? GUID {  get; set; }
        private string? Name { get; set; }
        private string? ShortDescription { get; set; }
        private string? LongDescription { get; set; }

        public Planet(string name, string shortDescription, string longDescription)
        {
            SetGUID();

            Name = name;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
        }

        private void SetGUID()
        {
            //Globally unique identifier

            //GUID is a 128-bit unique identifier commonly
            //represented as a 32-character hexadecimal
            //string in the format
            //“xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx”,
            //where each “x” represents a
            //hexadecimal digit (0-9, A-F)

            //GUIDs play a pivotal role in programming,
            //serving as universally unique identifiers
            //across distributed systems and applications.
            //They offer a dependable mechanism for generating
            //identifiers that are highly unlikely
            //to collide or be duplicated. GUIDs find
            //extensive use in various scenarios,
            //including primary keys, unique
            //constraints in databases, session
            //identifiers, and resource naming, among others.

            GUID = Guid.NewGuid().ToString();
            //make sure the GUID is valid...
            
        }
    }
}
