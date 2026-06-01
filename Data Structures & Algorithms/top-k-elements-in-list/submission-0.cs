public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {  
    List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }
    Dictionary<int,int> dico = new Dictionary<int,int>();
    foreach(int num in nums){
        if(dico.ContainsKey(num)){
            dico[num]++;
        }
        else{
            dico[num]=1;
        }
    }
    foreach(var elem in dico){
        freq[elem.Value].Add(elem.Key);
    }
    int[] res= new int[k];
    int index =0;
    for (int i = freq.Length - 1; i > 0; i--) {
            foreach (int n in freq[i]) {
                res[index++] = n;
                if (index == k) {
                    return res;
                }
            }
        }
    return res;
    }
}