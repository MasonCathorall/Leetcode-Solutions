public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        List<string> list = new List<string>();

        while(columnNumber > 0){
            columnNumber--;

            var num = columnNumber % 26;

            char c = chars[num];

            list.Insert(0, c.ToString());

            columnNumber /= 26;
        }

        return string.Join("", list);
    }
}