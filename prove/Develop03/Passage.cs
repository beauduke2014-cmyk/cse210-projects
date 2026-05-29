public class Passage
{
    private List<Word> _cdw_words = new List<Word>();

    private List<int> _cdw_wordsHiddenIndex = new List<int>();

    public void cdw_getPassage(List<string> cdw_words)
    {
        foreach (string word in cdw_words)
        {
            Word newWord = new Word();
            newWord.cdw_setWord(word);
            _cdw_words.Add(newWord);
        }
    }

    public string cdw_toString(bool hide)
    {
        string cdw_rvalue = "";
        if (cdw_checkHidden() == false)
        {
            if (hide == true)
            {
                cdw_randomHide();
                foreach(int cdw_index in _cdw_wordsHiddenIndex)
                {
                    _cdw_words[cdw_index].cdw_hideWord();
                }
            }
            
            foreach (Word word in _cdw_words)
            {
                cdw_rvalue += word.cdw_toString() + " ";
            }
            return cdw_rvalue;
        }
        else
        {
            return "quit";
        }
        
    }

    private bool cdw_randomHide()
    {
        bool cdw_all = cdw_checkHidden();
        if (cdw_all == false)
        {
            Random cdw_random = new Random();
            int cdw_countFlag = 0;
            while (cdw_countFlag < 1)
            {
                int cdw_randomIndex = cdw_random.Next(_cdw_words.Count);
                if (!_cdw_wordsHiddenIndex.Contains(cdw_randomIndex))
                {
                    _cdw_wordsHiddenIndex.Add(cdw_randomIndex);
                    cdw_countFlag += 1;
                }
            }
            return false;
        }
        
        else
        {
            return true;
        }
    }
    
    private bool cdw_checkHidden()
    {
        if(_cdw_words.Count == _cdw_wordsHiddenIndex.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}