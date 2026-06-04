public class Solution {
    public int MaxProfit(int[] prices) {
       int buyDay=0;
       int sellDay=1;
       int maxP = 0;
       while(sellDay<prices.Length){
        if(prices[buyDay]<prices[sellDay]){
            int profit = prices[sellDay]-prices[buyDay];
            maxP = Math.Max(maxP,profit);
        }
        else{
            buyDay=sellDay;
        }
        sellDay++;
       }
       return maxP;
    }
}
