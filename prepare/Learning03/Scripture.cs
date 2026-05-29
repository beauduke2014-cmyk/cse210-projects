public class Scripture
{
    private string _cdw_reference;
    private string _cdw_passage;
    public string cdw_constructor(string reference, string passage)
    {
        _cdw_reference = reference;
        _cdw_passage = passage;
        return _cdw_reference;
    }
}