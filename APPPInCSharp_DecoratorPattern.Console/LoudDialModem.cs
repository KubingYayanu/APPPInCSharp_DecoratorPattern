namespace APPPInCSharp_DecoratorPattern
{
    public class LoudDialModem : Modem
    {
        private Modem itsModem;

        public LoudDialModem(Modem m)
        {
            itsModem = m;
        }

        public string PhoneNumber => itsModem.PhoneNumber;

        public int SpeakerVolume
        {
            get { return itsModem.SpeakerVolume; }
            set { itsModem.SpeakerVolume = value; }
        }

        public void Dial(string pno)
        {
            itsModem.SpeakerVolume = 10;
            itsModem.Dial(pno);
        }
    }
}