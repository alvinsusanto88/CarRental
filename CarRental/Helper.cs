namespace CarRental
{
    public static class Helper
    {
        public static bool IsNumeric(string val)
        {
            return double.TryParse(val, out double result);
        }
    }
}
