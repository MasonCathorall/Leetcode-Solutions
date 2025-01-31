public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        ArrayList list = new ArrayList();
        for(int i = 0; i < m; i++){
            list.Add(nums1[i]);
        }

        for(int i = 0; i < n; i++){
            list.Add(nums2[i]);
        }

        list.Sort();

        int count = 0;

        foreach(int k in list){
            nums1[count] = k;
            count++;
        }
    }
}