/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = n;
        int high = 1;
        int firstBad = 0;

        while(high <= low){
            int mid = low + (high - low) /2;
            if(IsBadVersion(mid)){
                low = mid - 1;
                firstBad = mid;
            } else {
                high = mid + 1;
            }
        }

        return firstBad;
    }
}