namespace GameInterfaces
{
    public class Building : IHasValue
    {
        public float Value { get; }
        public string Type{ get; }
        public float Area { get; }

        public Building(float value, string type, float area)
        {
            Value = value;
            Type = type;
            Area = area;
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,8:f2}{2:f2}", Type, Value, Area);
        }
        public bool Equals(IHasValue other)
        {
            if (other == null) return false;
            return Value == other.Value;
        }
    }
}