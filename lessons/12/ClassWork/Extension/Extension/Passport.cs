using System;

namespace Extension
{
    public class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

        public Passport(string number, DateTimeOffset issueDate) : base(title: "Passport", number, issueDate)
        {
        }

        public override string Description => $"{base.Description}" +
                                              $"Country {Country} \n" +
                                              $"Owners`s name {PersonName} \n";
    }
}