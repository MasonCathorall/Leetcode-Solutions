public class ValidWordAbbr {
    Dictionary<string, string> wordAbr = new Dictionary<string, string>();
    Dictionary<string, int> abrCount = new Dictionary<string, int>();

    public ValidWordAbbr(string[] dictionary) {
        foreach(string str in dictionary){
            if(wordAbr.ContainsKey(str))
                continue;
            string abr = ReturnAbbr(str);
            // Console.WriteLine(abr);

            if(!wordAbr.ContainsKey(str))
                wordAbr.Add(str, abr);
            
            if(!abrCount.ContainsKey(abr))
                abrCount.Add(abr, 0);
            
            abrCount[abr]++;
        }
    }
    
    public bool IsUnique(string word) {
        string abr = ReturnAbbr(word);

        if(!abrCount.ContainsKey(abr)) return true;
        else {
            return wordAbr.ContainsKey(word) && abrCount[abr] == 1;
        }
    }

    public string ReturnAbbr(string word){
        if(word.Length < 3) return word;
        int wordLen = word.Length-2;
        return word.Substring(0,1) + wordLen.ToString() + word.Substring(word.Length-1,1);
    }
}

/**
 * Your ValidWordAbbr object will be instantiated and called as such:
 * ValidWordAbbr obj = new ValidWordAbbr(dictionary);
 * bool param_1 = obj.IsUnique(word);
 */