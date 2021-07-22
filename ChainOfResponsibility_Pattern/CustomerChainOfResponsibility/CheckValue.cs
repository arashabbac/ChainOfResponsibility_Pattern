namespace ChainOfResponsibility_Pattern.CustomerChainOfResponsibility
{
    public class CheckValue : TransferMoney
    {
        public CheckValue(TransferMoney successor) : base(successor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if(requestContext.FromCustomer.AccountValue >= requestContext.Value)
            {
                return (_successor.Execute(requestContext));
            }
            else
            {
                return new ResponseContext
                {
                    Message = "Invalid Value",
                };
            }
        }
    }
}
