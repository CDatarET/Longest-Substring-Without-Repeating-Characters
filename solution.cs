public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int l = 0;
        int max = 0;
        for(int i = 0; i < s.Length; i++){
            while(set.Contains(s[i])) set.Remove(s[l++]);

            set.Add(s[i]);
            max = Math.Max(max, set.Count);
        }

        return(max);
    }
}
