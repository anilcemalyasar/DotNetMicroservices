namespace Mango.Web.Models
{
    public class CreateCouponRequest
    {
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
