class Solution:
    def lengthOfLongestSubstring(self, s):
        hs = set()
        l = 0
        m = 0
        for i in range(len(s)):
            while s[i] in hs:
                hs.discard(s[l])
                l += 1
            
            hs.add(s[i])
            m = max(m, i - l + 1)

        return m
