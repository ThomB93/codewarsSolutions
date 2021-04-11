function invert(array) {
    var myArray = new Array(array.length);
     for (var i = 0; i < array.length; i++) {
        myArray[i] = array[i] + (array[i] * (-2));
     }
     return myArray;
  }