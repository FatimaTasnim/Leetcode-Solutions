public class Solution {
    public int RomanToInt(string s) {
       String[] str = new string[6] {"IV", "IX", "XL", "XC", "CD", "CM"};
       int[] nums = new int[6] {4, 9, 40, 90, 400, 900};
       int temp = 0;
        string num = s;
        for(int i=0;i<=5; i++){
            if(num.Contains(str[i])){
                temp += nums[i];
                num = num.Replace(str[i],"");
            }
        }
        

        char[] arr = num.ToCharArray();
        String st = "IVXLCDM";
        int[] vals = new int[7] {1,5,10,50,100,500,1000};

        for(int i = 0; i < arr.Length; i++){
            for(int j=0;j<=6;j++){
                if(arr[i].ToString()==st[j].ToString())temp += vals[j];
            }
        }

        return temp;
    }
}
