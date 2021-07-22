namespace ChainOfResponsibility_Pattern.CustomerChainOfResponsibility
{
    public abstract class TransferMoney
    {
        protected readonly TransferMoney _successor;

        public TransferMoney(TransferMoney successor)
        {
            _successor = successor;
        }

        public abstract ResponseContext Execute(RequestContext requestContext);
    }
}
