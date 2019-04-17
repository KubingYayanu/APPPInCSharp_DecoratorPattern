namespace APPPInCSharp_DecoratorPattern
{
    public class ModemDecorator : Modem
    {
        private Modem modem;

        public ModemDecorator(Modem m)
        {
            modem = m;
        }

        public string PhoneNumber => modem.PhoneNumber;

        public int SpeakerVolume
        {
            get { return modem.SpeakerVolume; }
            set { modem.SpeakerVolume = value; }
        }

        protected Modem Modem => modem;

        public virtual void Dial(string pno)
        {
            modem.Dial(pno);
        }

        public virtual void Hangup()
        {
            modem.Hangup();
        }
    }
}