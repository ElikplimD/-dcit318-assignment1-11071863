namespace TicketPriceCalculator
{
    public class TicketPriceCalculator
    {
        public int GetTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7;
            }
            else
            {
                return 10;
            }
        }
    }
}