using System;

namespace Extension
{
    public class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

        public Passport(
            string number,
            DateTimeOffset issueDate,
            string country,
            string personName) : base(title: "Passport", number, issueDate)
        {
            Country = country;
            PersonName = personName;
        }

        public override string Description => $"{base.Description}" +
                                              $"Country {Country} \n" +
                                              $"Owners`s name {PersonName} \n";

        public void ChangeIssueDate(DateTimeOffset newDate) => IssueDate = newDate;
    }
}