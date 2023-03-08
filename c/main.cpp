// 1. (2 pts) Write a function named triangle to output the following pattern:
//  *
//  **
//  ***
//  ****
//  *****
//  ******
//  *******
// Your function should have one parameter, x, which denotes the number of rows 
// (and columns) to be printed. The pattern above is for x=7.

// 2.(1.5 pts) Write a recursive function named sumOver that takes an int parameter 
// n and returns a double value which is the sum of the reciprocals of the first n 
// positive integers. The reciprocal of x is 1.0/x. For example, sumOver(3)
// returns 1.833 which is 1.0/1 + 1.0/2 + 1.0/3. Your function must work for values 
// of n greater than or equal to 0. By definition, sumOver(0) = 0.
// Do not use loops, extra parameters, or global or static variables
#include <iostream>
#include <string>
using namespace std;

string First(int x);
double sumOver(int n);
int * subarraySum(int arr[],int N, int S);

int main(void){
    cout<<First(8);
    cout<<endl;
    cout<<sumOver(100);
    cout<<endl;

    int a[4]={10,7,4,2};
    int * x=subarraySum(a,4,6);
    for(int i=0;i<2;i++){
        cout<<x[i]<<" ";
    }
}

double sumOver(int n){
    if(n==0) return 0;
    int x=n-1;
    if(n==1){
        return 1;
    }
    return (1.0/(double)n)+sumOver(x);
}

string First(int x){
    int spaces=x-1;
    int star=1;
    string str="";
    for(int i=0;i<x;i++){
        for(int s=spaces;s>0;s--){
        str+=" ";
        }
        for(int a=0;a<star;a++){
            str+="*";
        }
        spaces--;
        star++;
        str+="\n";
    }
    return str;
}

// Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array that adds to a given number S and return the left and right index(1-based indexing) of that subarray.

// In case of multiple subarrays, return the subarray indexes which come first on moving from left to right.

// Note:- You have to return an ArrayList consisting of two elements left and right. In case no such subarray exists return an array consisting of element -1.

// Example 1:

// Input:
// N = 5, S = 12
// A[] = {1,2,3,7,5}
// Output: 2 4
// Explanation: The sum of elements 
// from 2nd position to 4th position 
// is 12.
 

// Example 2:

// Input:
// N = 10, S = 15
// A[] = {1,2,3,4,5,6,7,8,9,10}
// Output: 1 5
// Explanation: The sum of elements 
// from 1st position to 5th position
// is 15.
 

// Your Task:
// You don't need to read input or print anything.
// The task is to complete the function subarraySum() which takes arr,  N, and S
// as input parameters and returns an ArrayList containing the starting and ending
// positions of the first such occurring subarray from the left where sum equals to S.
// The two indexes in the array should be according to 1-based indexing.
// If no such subarray is found, return an array consisting of only one element that is -1.
// Expected Time Complexity: O(N)
// Expected Auxiliary Space: O(1)
// Constraints:
// 1 <= N <= 105
// 1 <= Ai <= 109

int * subarraySum(int arr[],int N, int S){
    // int* x=arr;
    int currentS=0;
    int st=0;
    int end=0;
    for(int i=0;i<N;i++){
        // cout<<x[i] << endl;
        currentS+=arr[i];
        if(currentS>S){
            currentS-=arr[st];
            st++;
        }
        if(currentS==S){
            end=i;
            return new int[2]{st+1,end+1};
        }
    }
    return new int[1]{-1};
}