public class Entry
{
    //Save the prompt used for the entry
    public string _cdw_prompt;
    //Save the date the entry was entered
    public string _cdw_date;
    //Save the text from the entry itself
    public string _cdw_entry;

    //Compile the entry to correct formatting (date, prompt, entry)
    public string cdw_compileEntry()
    {
        string cdw_entry = _cdw_date + " " + _cdw_prompt + "\n" + _cdw_entry +"\n";
        return cdw_entry;
    }

    //Compile the entry for formatting to save to a new file. With ,, separating the individual parts.
    public string cdw_toFile()
    {
        string cdw_entry = _cdw_date + ",," + _cdw_prompt + ",," + _cdw_entry;
        return cdw_entry;
    }
}