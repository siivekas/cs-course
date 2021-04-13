using System;

namespace Extension
{
    public class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }
        
        public override string Description => $"Type {GetType()} \n" +
                                     $"Title {Title} \n" +
                                     $"Number {Number} \n" +
                                     $"Issue date {IssueDate} \n" +
                                     $"Country {Country} \n" +
                                     $"Owners`s name {PersonName} \n";
    }
}