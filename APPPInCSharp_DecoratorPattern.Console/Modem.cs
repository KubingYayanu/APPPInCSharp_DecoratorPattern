namespace APPPInCSharp_DecoratorPattern
{
    public interface Modem
    {
        void Dial(string pno);

        int SpeakerVolume { get; set; }
        string PhoneNumber { get; }
    }
}