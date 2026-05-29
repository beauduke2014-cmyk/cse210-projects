public class Reference
{
    private string _cdw_reference;

    public void cdw_getReference(string cdw_reference)
    {
        _cdw_reference = cdw_reference;
    }

    public string cdw_toString()
    {
        return _cdw_reference;
    }
}