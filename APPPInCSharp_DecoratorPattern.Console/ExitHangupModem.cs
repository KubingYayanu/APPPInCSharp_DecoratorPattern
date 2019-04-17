namespace APPPInCSharp_DecoratorPattern
{
    public class ExitHangupModem : ModemDecorator
    {
        public ExitHangupModem(Modem m)
            : base(m)
        {
        }

        public override void Hangup()
        {
            System.Console.WriteLine("exit");
            Modem.Hangup();
        }
    }
}