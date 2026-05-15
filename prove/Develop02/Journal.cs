public class Journal
{
    //where all the journal entries will be stored
    public List<Entry> _cdw_entries = new List<Entry>();

    //compile the journal for writing
    public string cdw_compileJournal()
    {
        string cdw_journal = "";
        foreach(Entry entry in _cdw_entries)
        {
            cdw_journal += entry.cdw_compileEntry();
        }
        return cdw_journal;
    }

    //Save the journal to a seperate file to be added to and loaded later.
    public void cdw_writeToFile(string cdw_fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(cdw_fileName))
        {
            foreach(Entry cdw_entry in _cdw_entries)
            {
                outputFile.WriteLine(cdw_entry.cdw_toFile());
            }
        }
    }
}