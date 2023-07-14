public class Solution {
    public bool IsPalindrome(int x) {
        int number_normal=x;
        int sum=0;
        while(x>0){
            sum = (10*sum)+(x%10);
            x=x/10;
        }
        return number_normal==sum;
    }
}