public class Word
{
    private string _cdw_word;
    private bool _cdw_hidden = false;

    public void cdw_setWord(string word)
    {
        _cdw_word = word;
    }

    public void cdw_hideWord()
    {
        if (_cdw_hidden == false)
        {
            _cdw_hidden = true;
        }
    }

    public string cdw_toString()
    {
        if (_cdw_hidden == true)
        {
            return "_______";
        }
        else
        {
            return _cdw_word;
        }
    }
}