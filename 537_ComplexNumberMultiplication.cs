public class Solution {
    // a + bi
    public class ComplexNumber
    {
        public int a;
        public int b;
        
        public ComplexNumber(string str){
            List<string> nums = str.Split('+').ToList();
            nums[1] = nums[1].Replace("i", "");
            
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
        }
    }
    
    public string ComplexNumberMultiply(string x, string y) {
        ComplexNumber num1 = new ComplexNumber(x);
        ComplexNumber num2 = new ComplexNumber(y);
        
        var realNum =  (num1.a * num2.a) - (num1.b * num2.b) ;
        var compNum =  (num1.b * num2.a) + (num1.a * num2.b) ;
        
        var res = new StringBuilder();
        
        return res.Append(realNum.ToString()).Append("+").Append(compNum.ToString()).Append("i").ToString();
    }
}