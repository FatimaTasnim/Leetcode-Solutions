public class Solution {
    public int LengthOfLongestSubstring(string s) {
         Dictionary<char,int> map = new Dictionary<char,int>();  
         int maxima, i;
         i = maxima = 0;
    
         while(i < s.Length){
            if(map.ContainsKey(s[i])){
                maxima = Math.Max(maxima,map.Count);
                i = map[s[i]] + 1;  
                map.Clear();                             
            }
            else{
                map.Add(s[i],i); 
                i++;
            }
        }
        
        return  Math.Max(maxima,map.Count);
    }
}