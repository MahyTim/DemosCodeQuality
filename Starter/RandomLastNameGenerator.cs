using Bogus;
using Bogus.DataSets;

namespace Starter
{
    public class RandomLastNameGenerator : ILastNameGenerator
    {
        public class LastName
        {
            public string Value { get; set; }
        }

        public string Generate()
        {
            return new Faker<LastName>("nl")
                .RuleFor(z => z.Value, z => z.Name.LastName(Name.Gender.Male))
                .Generate().Value;
        }
    }
}