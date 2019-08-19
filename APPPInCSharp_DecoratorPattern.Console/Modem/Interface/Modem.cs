namespace APPPInCSharp_DecoratorPattern
{
    public interface Modem
    {
        void Dial(string pno);
        void Hangup();

        int SpeakerVolume { get; set; }
        string PhoneNumber { get; }
    }
}