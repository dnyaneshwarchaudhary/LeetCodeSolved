public class Solution {
    public int[] PlusOne(int[] digits) {
        // [9,9] -> [1,0,0]
        int length = digits.Length;
        int add = 1;
        for (int i = length - 1; i>=0; i--){
            int sum = digits[i] + add;
            digits[i] = sum % 10 ;
            add = sum / 10;
            if (add == 0){
              break;
            }
        }
        if (add == 1){
            int[] result = new int[length + 1];
            result[0] = 1;
            return result;
        }
        return digits;
    }
}