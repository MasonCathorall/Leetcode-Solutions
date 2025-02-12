public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        Dictionary<string, int> d = new Dictionary<string, int>();
        List<string> list = new List<string>();

        for(int i = 0; (i + 10) <= s.Length; i++){
            string sub = s.Substring(i, 10);
            if(d.ContainsKey(sub)){
                d[sub]++;
            } else{
                d.Add(sub, 1);
            }
        }

        foreach(KeyValuePair<string, int> kvp in d){
            if(kvp.Value > 1) list.Add(kvp.Key);
        }

        return list;
    }
}