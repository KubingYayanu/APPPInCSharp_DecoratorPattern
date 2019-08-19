namespace APPPInCSharp_DecoratorPattern
{
    public class LoudDialModemV2 : ModemDecorator
    {
        public LoudDialModemV2(Modem m)
            : base(m)
        {
        }

        public override void Dial(string pno)
        {
            Modem.SpeakerVolume = 10;
            Modem.Dial(pno);
        }
    }
}