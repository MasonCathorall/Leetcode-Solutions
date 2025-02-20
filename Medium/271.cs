public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        string delim = "π";
        string encode = "";

        foreach(string s in strs){
            encode += s;
            encode += delim;
        }

        // encode = encode

        return encode;
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {
        string delim = "π";
        List<string> str = new List<string>();
        s = s.Substring(0, s.Length - 1);
        string[] strs = s.Split(delim);
        

        foreach(string s1 in strs) {
            str.Add(s1);
        }

        return str;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));