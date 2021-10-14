namespace CSharpAlgorithms.Difficulties.Medium
{
    public class Solution {
        public int Compress(char[] chars) {
            if (chars.Length == 1) {
                return 1;
            }
            int arrPtr = 0;
            int charCt = 0;
            for (int i = 0; i < chars.Length; i++){
                char currentChar = chars[i];
                if (currentChar != chars[arrPtr]){
                    AppendToChars(chars, ref arrPtr, charCt.ToString());
                    charCt = 0;
                    arrPtr += 1;
                    chars[arrPtr] = currentChar;
                }
                charCt += 1;
            }
            AppendToChars(chars, ref arrPtr, charCt.ToString());
            return arrPtr + 1;
        }
        public void AppendToChars(char[] chars, ref int idx, string charCt){
            if (charCt == "1"){
                return;
            }
            foreach (char c in charCt){
                idx += 1;
                chars[idx] = c;
            }
        }
    }
}