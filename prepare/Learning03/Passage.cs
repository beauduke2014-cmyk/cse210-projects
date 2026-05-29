public class Passage
{
    private List<Word> _cdw_words = new List<Word>();

    public void cdw_setPassage()
    {
        foreach (Word word in _cdw_words){
            cdw_setWord(word);
        }
    }

}