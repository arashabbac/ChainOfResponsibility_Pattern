namespace ChainOfResponsibility_Pattern.CustomerChainOfResponsibility
{
    public class RequestContext
    {
        public string Password { get; set; }
        public int Value { get; set; }
        public Models.Customer FromCustomer { get; set; }
        public Models.Customer ToCustomer { get; set; }
    }
}
