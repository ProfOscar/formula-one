namespace FormulaOneDLL
{
    public class Country
    {
        public Country(string isoCode, string description)
        {
            IsoCode = isoCode;
            Description = description;
        }

        public string IsoCode { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return IsoCode + " - " + Description;
        }
    }
}
