public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Count() == 0) return "";
        if(strs.Count() == 1) return strs[0];
        int idx = 0;
        bool x = true;
        string res = "";
        while(x){
            foreach (var item in strs){
                if(idx >= item.Length || item[idx] != strs[0][idx]){
                    x = false;
                    return res;
                }
            }
            res += strs[0][idx];
            idx++;

        }
        return res;
    }
}
