public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for (int i=0;i<32;i++) {
            uint b = (n >> i) & 1;
            res += b << (31- i);
        }
        return res;
        
    }
}
