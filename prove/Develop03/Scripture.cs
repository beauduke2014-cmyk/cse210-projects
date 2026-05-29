public class Scripture
{
    private Reference _cdw_reference;
    private Passage _cdw_passage;
    public void cdw_getScripture(string reference, string passage)
    {
        Reference cdw_newReference = new Reference();
        cdw_newReference.cdw_getReference(reference);
        _cdw_reference = cdw_newReference;
        //Split of list obtained from ChatGPT
        List<string> cdw_passageList = passage.Split(' ').ToList();
        Passage cdw_newPassage = new Passage();
        cdw_newPassage.cdw_getPassage(cdw_passageList);
        _cdw_passage = cdw_newPassage;
    }

    public string cdw_toString(bool hide)
    {
        string cdw_rvalue = "";
        if (_cdw_passage.cdw_toString(hide) != "quit")
        {
            cdw_rvalue += _cdw_reference.cdw_toString() + "\n";
            cdw_rvalue += _cdw_passage.cdw_toString(hide);
            return cdw_rvalue;
        }
        else
        {
            return "quit";
        }
    }
}