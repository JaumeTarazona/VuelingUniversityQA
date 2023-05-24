// Exercise 1

function birthChecker(age) {
  if (age >= 18) {
    return "You are of legal age";
  } else {
    return "You are underage.";
  }
}

console.log(birthChecker(2));

// Exercise 2

function primeNumber(num) {
  if (num <= 1) {
    return false;
  }

  for (var i = 2; i < num; i++) {
    if (num % i === 0) {
      return false;
    }
  }
  return true;
}

console.log(primeNumber(1));

// Exercise 3

var arrayPrime = [1, 2, 3, 4, 5, 6, 8, 9, 10, 22, 45, 47, 67, 56];
var primeArray = [];

function arrayPrimePrinter(array) {
  for (var i = 0; i < array.length; i++) {
    if (primeNumber(array[i])) {
      primeArray[primeArray.length] = array[i];
    }
  }
  console.log(primeArray);
}

arrayPrimePrinter(arrayPrime);

// Exercise 4
var numbersArray = [1, 3, 4, -2, 40, 50, -40];

function highestNumber(numbersArray) {
  var highest = numbersArray[0];

  for (var i = 1; i < numbersArray.length; i++) {
    if (numbersArray[i] > highest) {
      highest = numbersArray[i];
    }
  }

  console.log(highest);
}

highestNumber(numbersArray);

// Exercise 5
var wordsArray = ["jefe", "Ornithorhynchus", "hola", "adeu"];

function longestWord(wordsArray) {
  var longWord = "";

  for (var i = 0; i < wordsArray.length; i++) {
    if (wordsArray[i].length > longWord.length) {
      longWord = wordsArray[i];
    }
  }

  return longWord;
}

console.log(longestWord(wordsArray));

// Exercise 6

function duplicateArray(numbersArray) {
  var duplicatedArray = [];

  for (var i = 0; i < numbersArray.length; i++) {
    var duplicatedNumber = numbersArray[i] * 2;
    duplicatedArray[i] = duplicatedNumber;
  }
  return duplicatedArray;
}

console.log(duplicateArray(numbersArray));

// Exercise 7
function mediaOverage(numbersArray) {
  var AgeSum = 0;
  var OverageNumber = 0;

  for (var i = 0; i < numbersArray.length; i++) {
    var legalStatus = birthChecker(numbersArray[i]);
    if (legalStatus === "You are of legal age") {
      AgeSum += numbersArray[i];
      OverageNumber++;
    }
  }
  var averageAge = AgeSum / OverageNumber;
  return averageAge;
}

console.log(mediaOverage(numbersArray));


