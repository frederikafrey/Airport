using Airport.Facade.Common;

namespace Airport.Facade.AirlinesCompany
{
    public sealed class AirlinesCompaniesView : UniqueEntityView 
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
