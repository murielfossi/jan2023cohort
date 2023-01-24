//Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.
var newArr=[]
function returns(a){
    for(let i=1; i<=255; i++){newArr.push(i)}
    console.log(a)
}
returns(newArr)

//Get even 1000 - Write a function that would get the sum of all the even numbers from 1 to 1000.  
//You may use a modulus operator for this exercise.

function geteven(a) {var sum = 0;
    for(let i=1; i<=a; i++){
        if (i%2==0) {sum =sum + i;}
    }
    console.log(sum);
}
geteven(1000)

//or this method

function geteven() {
  var sum = 0;
  for (let i = 1; i <= 1000; i++) {
    if (i % 2 == 0) {
      sum = sum + i;
    }
  }
  console.log(sum);
}
geteven();

//Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999).
function sumodd(a){var sum = 0;
    for (let i = 1; i <= a; i++) {if (i%2 !=0) {sum =sum +i}
}
console.log(sum)
}
sumodd(6)

//Iterate an array - Write a function that returns the sum of all 
//the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).
var mu = [1, 2, 5];
var mum = [-5, 2, 5, 12];
function arraysum(a) {
    var sum = 0;
    for (let i = 0; i < a.length; i++) {sum= sum +a[i] }
    console.log(sum)
    
}
arraysum(mu)
arraysum(mum)

//Find max - Given an array with multiple values, 
//write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
var mu = [-3, 3, 5, 7];
 function maxi(a) {
  let max = Math.max(...a); 
  console.log(max)
}
maxi(mu)

//Find average - Given an array with multiple values, 
//write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)
var mu = [1, 3, 5, 7, 20];
function avg(a){
    sum=0
    for (let i = 0; i < a.length; i++) {sum =sum + a[i] }
    avg=sum/a.length
    console.log(avg)
}
avg(mu)

//Array odd - Write a function that would return an array of all the odd numbers between 1 to 50.
// (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.

    var newarray = [];
    function arrayodd() {
      for (let i = 1; i <=50; i++)
        if (i % 2 != 0) {
          newarray.push(i);
        }
      console.log(newarray);
    }
    arrayodd(newarray);


    // Given an array with multiple values, write a function that replaces each value in 
    //the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])
var mum= [1,5,10,-2]
var mu=[1,25,100,4]
function squared(a){
    for (let i = 0; i < a.length; i++) {
        a[i]=a[i]*a[i]
    }
    console.log(a)
}
    squared(mum)
squared(mu)

    ///zerro out negative number in javascript
    var num =99
    var um =-99
    function zeronumber(a){
        for (let i = 0; i < a; i++) {if (a<0) {a=0}}
         console.log(a);
    }
zeronumber(num)
zeronumber(um)

    // orrr this method 
var num =-99
num =Math.max(0,num); //0
console.log(num)

    // ///zerro out negative number in an array javascript
   
    function zeronumber(a) {
      for (let i = 0; i < a.length; i++) {
        if (a[i] < 0) { a[i] = 0;}
      }
      console.log(a);
    }
    zeronumber([-9,35,-38,35,-225])

zeronumber(num)
zeronumber(um)



//Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if 
//arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).

function greaterThanY(arr, y) {
  var count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] > y) {
      count++; // count= count +1
    }
  }
  console.log(count);
}
greaterThanY([1, 2, 3, 4, 5, 6, 7, 8, 9], 4);

//this method give us the exact number
var arr = [1, 3, 5, 7] 
var  Y = 3
function greater(a, y){
    var count = 0
    for (let i = 0; i < a.length; i++) {
if (a[i]>Y) {console.log(a[i]);
}}}
greater(arr,Y)


//Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains 
//the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])
 var mu=[1,5,10,-2] 

function minmaxavg(a){
var newArr =[]
var sum =0 
var max = Math.max(...a);
         var min = Math.min(...a);  // le math.nin ci je nai pas besoin dutiliser i parceque cest concu pour passer dans chaque array, je peux lutiliser pour un array qui contien un aray
           for (var i = 0; i < a.length; i++) {
        
         var sum= sum + a[i]  
    }
avg=sum/a.length
    
    newArr.push(max, min, avg);
  console.log(newArr);
    
}
minmaxavg(mu)


//Swap Values - Write a function that will swap the first and last values of any given array. 
//The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).
var mu= [1,5,10,-2]
function swap (a){
  let arrfirst=a[0]
  let arrlast =a[a.length-1]
    for (let i = 0; i <= a.length-1; i++) {if (i= a.length-1) {  a.splice(i,1,arrfirst) && a.splice(0,1,arrlast)}    
    }
    console.log(a)
} 

swap(mu)

//set the last number in the array equal to 0
let arr = [1,2,3,4,5,6,7,8,9]
for(let i = 0; i <= arr.length-1; i++) {
    if(i = arr.length -1) {
        arr[i] = 0  
}
console.log(arr)
 } 


//Number to String - Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. 
//For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].

var mum= [-1, -3, 2];
function replaces(a){
  for (let i = 0; i < a.length; i++) if (a[i]<0){a[i]="Dojo"}
  //else if (a[i]>0) {a[i]=a[i] } //not really mandatory because it work without this
    console.log(a)
  }
replaces(mum)