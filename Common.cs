class Common{
     public static int findLCM(int a, int b) //method for finding LCM with parameters a and b
        {
            int num1, num2;                         //taking input from user by using num1 and num2 variables
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }

    public static bool isPallindrome(int val){
        string v=val.ToString();    
        return isPallindrome(v);
   }

   public static bool isPallindrome(string v){
        if(v.Length<=1){
            return true;
        }else{
            bool isPal=(v[0]==v[v.Length-1])?true:false;
            return isPal && isPallindrome(v.Substring(1,v.Length-2));
        }
   }

   public static List<int> GetPrimesValConstraint(long constraint){
    List<int> primes=new List<int>{2,3,5,7};
    int cntPrime=3;
    for(int i=10;i<constraint;i++){
        bool isPrime=true;

        foreach(int prime in primes){
            if(i%prime==0){
                isPrime=false;
                break;
            }
        }
        if(isPrime){
            cntPrime++;
            primes.Add(i);
        }
    }
    return primes;
   }

    public static long GetPrimesValPosition(long index){
    List<int> primes=new List<int>{2,3,5,7};
    int cntPrime=3;
    for(int i=10;;i++){
        bool isPrime=true;

        foreach(int prime in primes){
            if(i%prime==0){
                isPrime=false;
                break;
            }
        }
        if(isPrime){
            cntPrime++;
            primes.Add(i);
            if(cntPrime>index){
                break;
            }
        }
    }
    return primes[cntPrime-2];
   }
}