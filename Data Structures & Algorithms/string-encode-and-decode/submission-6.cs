public class Solution {

    public string Encode(IList<string> strs) {
         string res="";
        if(strs.Count()<10){
            res = "0"+strs.Count().ToString();
        }
        if(strs.Count()>=10&&strs.Count()<100){
            res = strs.Count().ToString();
        }
        Console.WriteLine("_INIT_"+res);       
        foreach(string s in strs){
            if(s.Length<10){
                res+="00"+s.Length.ToString();
                Console.WriteLine("_DANS00_");                              
            } 
            if(s.Length>=10 && s.Length<100){
                res+="0"+s.Length.ToString();
                Console.WriteLine("_DANS0_");
            }
            if(s.Length<=200 && s.Length>=100) {
                res+= s.Length.ToString();
                Console.WriteLine("_DANS_");
            }
            Console.WriteLine("_BOUCLE"+s+"_"+res);        
        }       
        foreach(string s in strs){
           res+=s;
        }
        return res;
    }

    public List<string> Decode(string s) {   
       List<string> res = new List<string>();
       int numberOfStr = int.Parse(s.Substring(0,2));
       int sizeOfStr = 0;
       int sizeofPrevStr =0;    
        for(int i = 0; i<numberOfStr;i++){
         sizeOfStr = int.Parse(s.Substring((3*i)+2,3));
         res.Add(s.Substring(2+(3*numberOfStr)+sizeofPrevStr,sizeOfStr));  
         sizeofPrevStr += sizeOfStr;     
        } 
       return res;
   }
}
