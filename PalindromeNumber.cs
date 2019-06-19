public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)return false;
        int y = x, temp = 0;
        while(y>0){
            temp = (temp * 10) + y%10;
            y/=10;
        }
        if(temp==x)return true;
        return false;
    }
}