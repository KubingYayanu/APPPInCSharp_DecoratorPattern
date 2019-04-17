namespace APPPInCSharp_DecoratorPattern
{
    public class HayesModem : Modem
    {
        private string phoneNumber;
        private int speakerVolume;

        public string PhoneNumber => phoneNumber;

        public int SpeakerVolume
        {
            get { return speakerVolume; }
            set { speakerVolume = value; }
        }

        public void Dial(string pno)
        {
            phoneNumber = pno;
        }
    }
}