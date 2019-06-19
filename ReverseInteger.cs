public class Solution {
    public int Reverse(int x) {
        long result = 0, neg = 1;
        if(x<0){neg = -1;  x = -x;}
       
        while(x>0){
            result = (result * 10) + (x%10);
            x= x/10;
        }
        if(result<-2147483648 || result>2147483647) return 0;
        int y = Convert.ToInt32(result*neg);
        return y;
    }
}