
class Solutions{
    /*
        Problem 1
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        Find the sum of all the multiples of 3 or 5 below 1000.

        below 10 that are multiples of 3 are: 3,6,9
    */
    public int Multiples(int[] nums,int limit){
        int sum=0;
        int lcm=Common.findLCM(nums[0],nums[1]);
        foreach(int num in nums){
            int cnt=1;
            int multipleVal=num*cnt;
            
            while(multipleVal<limit){
                sum+=multipleVal;
                cnt++;
                multipleVal=num*cnt;
            }
        }
        int lcmcnt=1;
        int lcmmultipleVal=lcm*lcmcnt;
        while(lcmmultipleVal<limit){
            sum-=lcmmultipleVal;
            lcmcnt++;
            lcmmultipleVal=lcm*lcmcnt;
        }
        return sum;
    }

   /*
        Problem 2
        Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.  
   */
   public long FibSum(){
    int x1=1;
    int x2=2;
    int buf=x2;
    long sum=0;
    while(x2<4e6){
        if(x2%2==0){
            sum+=x2;
        }
        x2=x1+x2;
        x1=buf;
        buf=x2;
    }
    return sum;
   }

   /*
    Problem 3
        The prime factors of 13195 are 5, 7, 13 and 29.

        What is the largest prime factor of the number 600851475143 ?
   */
   public long LargestPrimeFactor(){
    int sqrt=(int)Math.Sqrt(600851475143);
    // List<int> primes=new List<int>{2,3,5,7};
    // int cntPrime=3;
    // for(int i=10;i<sqrt;i++){
    //     bool isPrime=true;

    //     foreach(int prime in primes){
    //         if(i%prime==0){
    //             isPrime=false;
    //             break;
    //         }
    //     }
    //     if(isPrime){
    //         cntPrime++;
    //         primes.Add(i);
    //     }
    // }
    List<int> primes=Common.GetPrimesValConstraint(sqrt);
    int biggest=2;
    foreach(int prime in primes){
        if(600851475143%prime==0){
            biggest=prime;
        }
    }

    return biggest;
   }

   /*
    Problem 4
    A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    Find the largest palindrome made from the product of two 3-digit numbers.
   */
   public int P4(){
    int biggestPal=int.MinValue;

    for(int i=100;i<=999;i++){
        for(int j=100;j<=999;j++){
            int product=i*j;
            if(product%1000000==product){
                if(Common.isPallindrome(product) && product>biggestPal){
                    biggestPal=product;
                }
            }
        }
    }
    return biggestPal;
   }

    /*
    Problem 5
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
   public int P5(){
    int x1=1;
    int x2=2;
    int lcm;
    for(int i=1;i<21;i++){
        x1=i;
        lcm=Common.findLCM(x1,x2);        
        x2=lcm;
    }
    return x2;
   }

   /*
Problem 6
The sum of the squares of the first ten natural numbers is, 1^2+2^2+3^2+.....+10^2=385.

The square of the sum of the first ten natural numbers is, (1+2+3+...+10)^2=3025.

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025-385=2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
   */

   public int P6(){
    int sqSum=0;
    for(int i=1;i<101;i++){
        sqSum+=(int)Math.Pow(i,2);        
    }

    int sumSq=(int)Math.Pow((100*101)/2,2);
    int diff=sumSq-sqSum;
    return diff;
   }

   /*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
   */
    public long P7(){
        long rqPrime=Common.GetPrimesValPosition(10001);
        return rqPrime;
    }

/*
The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.

73167176531330624919225119674426574742355349194934
96983520312774506326239578318016984801869478851843
85861560789112949495459501737958331952853208805511
12540698747158523863050715693290963295227443043557
66896648950445244523161731856403098711121722383113
62229893423380308135336276614282806444486645238749
30358907296290491560440772390713810515859307960866
70172427121883998797908792274921901699720888093776
65727333001053367881220235421809751254540594752243
52584907711670556013604839586446706324415722155397
53697817977846174064955149290862569321978468622482
83972241375657056057490261407972968652414535100474
82166370484403199890008895243450658541227588666881
16427171479924442928230863465674813919123162824586
17866458359124566529476545682848912883142607690042
24219022671055626321111109370544217506941658960408
07198403850962455444362981230987879927244284909188
84580156166097919133875499200524063689912560717606
05886116467109405077541002256983155200055935729725
71636269561882670428252483600823257530420752963450

Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
*/
    public long P8(){
        string num=@"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        const int adjNum=13;
        long greatestProduct=0;
        for(int i=0;i<num.Length-adjNum;i++){
            string current=num.Substring(i,adjNum);
            if(current=="9989"){
                int x=0;
            }
            long currentProduct=1;
            foreach(char c in current){
                currentProduct*=(int)char.GetNumericValue(c);
            }
            if(currentProduct>greatestProduct){
                greatestProduct=currentProduct;
            }
        }
        return greatestProduct;
    }
/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 3**2 + 4**2 = 9 + 16 = 25 = 5**2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

public int P9(){
    int val=1000;
    int pro=1;
    for(int i=1;i<val+1;i++){
        for(int j=i+1;j<val+1;j++){
            int c=val-i-j;
            if(i*i+j*j==c*c){
                pro= i*j*c;
            }
        }
    }
    return pro;
}

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/
public double P10(){
    double constraint=2e6;
    long sum=0;
    List<int> primes=Common.GetPrimesValConstraint((long)constraint);

    foreach(int prime in primes){
        sum+=prime;
    }
    return Convert.ToInt64(sum);
}

/*
In the 20×20 grid below, four numbers along a diagonal line have been marked in red.

08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48

The product of these numbers is 26 × 63 × 78 × 14 = 1788696.

What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?
*/
public int P11(){
    int[,] arr=new int[20,20];
    string str=@"08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
7 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";

    string[] lines=str.Split("\n");
    
    for(int i=0;i<lines.Length;i++){
        string[] element=lines[i].Split(" ");
        for(int j=0;j<element.Length;j++){
            arr[i,j]=Convert.ToInt32(element[j]);
        }
    }

    for(int i=0;i<20;i++){
        for(int j=0;j<20;j++){
            //current element to top, bottom, left, right

            //vertical i.e. i
            int topVal=i-4+1;
            int bottomVal=i+4-1;

            //horizontal i.e. j
            int leftVal=j-4+1;
            int rightVal=j+4-1;
            
            int product=1;
            int tempProduct=1;
            //top
            if(topVal>=0){
                for(int x=i;x>=topVal;x--){
                    tempProduct*=arr[x,j];
                }
            }
            //bottom
            if(bottomVal<20){
                tempProduct=1;
                for(int x=i;x<=bottomVal;x++){
                    tempProduct*=arr[x,j];
                }
            }
            //left
            if(leftVal>=0){
                tempProduct=1;
                for(int x=j;x>=leftVal;x--){
                    tempProduct*=arr[i,x];
                }
            }
            //right
            if(rightVal<20){
                tempProduct=1;
                for(int x=j;x<=rightVal;x++){
                    tempProduct*=arr[i,x];
                }
            }
        }
        
    }
    return 0;
}
}