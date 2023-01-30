//Biggie Size - Given an array, write a function that changes all //positive numbers in the array to the string "big".  Example: 
//makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].

var mu =[-1, 3, 5, -5];
function returns(a){for (let i = 0; i < a.length; i++) {if (a[i]<0) {a[i]="big"};}
console.log(a)
}
returns(mu)

//Print Low, Return High - Create a function that takes in an array of numbers. 
// The function should print the lowest value in the array, and return the highest value in the array.

var mu = [-1, 3, 5, -5];
function lowhigh(a){
    var max = Math.max(...a);
    var min = Math.min(...a);
     console.log(min)
     return max
}
lowhigh(mu)

//Print One, Return Another - Build a function that takes in an array of numbers.  
//The function should print the second-to-last value in the array, and return the first odd value in the array.
var mu = [-1, 3, 5, -5];
function printreturn(a) {
    let fistood =1
for (let i = 0; i <= a.length-1; i++) { if (i=a.length-2) {console.log(a[i])}
        
else {if (a[i]%2 !=0) {console.log(a[i]) }     
}return a[i]}}
printreturn(mu)



//Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each 
//value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
var mu = [1,2,3]
function double(a){
    let newarr=[]
    for (let i = 0; i < a.length; i++) {a[i]=a[i]*2; newarr.push(a[i])}
   // console.log(newarr)
    return newarr
}
double(mu)

//Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array. 
// Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.

var mu = [-1, 1, 1, 1];
function countPositives(a){
    var count =0
    for (let i = 0; i < a.length; i++) {if(a[i]>0){count=count +1;}
    a.splice(a.length-1,1,count )
       
    }console.log(a)
}
countPositives(mu)

//Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  
//Every time the array has three evens in a row, print "Even more so!".

function evenodds(a){
    var countood=0
    var counteven=0

    for (let i = 0; i < a.length; i++) {
        if (a[i]%2==0) {counteven= counteven + 1}
        
    }

}