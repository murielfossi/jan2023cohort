//Print out all odd numbers from 1 to 20
//The expected output will be 1, 3, 5, 7, 9, 11, 13, 15, 17, 19

for (var i = 1; i <= 20; i++) {
  if (i % 2 != 0) console.log(i);
}

//Sum and Print 1-5
//Sum numbers from 1 to 5, printing out the current number and sum so far at each step of the way

var sum = 0;
for (var i = 1; i <= 5; i++) {
  sum = sum + i;
  console.log("num:", i, "sum:", sum);
  // console.log('current value of i is:', i, 'current sum is:', sum)
}
