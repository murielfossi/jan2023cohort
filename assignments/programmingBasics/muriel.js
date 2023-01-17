//predict 1

for (var num = 0; num < 15; num++) {
  console.log(num);
}

// this script will run number from 0 to 14

//predict 2
// This script will start adding 2 to 1 until is 9 (less than 10), it will only print those which the division by 3 will give 0
for (var i = 1; i < 10; i += 2) {
  if (i % 3 == 0) {
    console.log(i);
  }
}

//predict 3

//This code will only print the number divisible by 2 , by 3 and those which are not
for (var j = 1; j <= 15; j++) {
  if (j % 2 == 0) {
    j += 2;
  } else if (j % 3 == 0) {
    j++;
  }
  console.log(j);
}
copy;
