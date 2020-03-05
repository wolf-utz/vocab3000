namespace Vocab3000.Exam.Settings
{
    public class DefaultSettings : ISettings
    {
        public int GetVocabCount()
        {
            return 10;
        }

        public bool HelpIsAllowed()
        {
            return true;
        }
    }
}