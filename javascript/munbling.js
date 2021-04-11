function accum(s) {
    // your code
    var array = s.split("");
    var returnString = "";
    for(var i = 0; i < array.length; i++) {
    if(i == array.length-1) {
    returnString += array[i].toUpperCase() + array[i].toLowerCase().repeat(i);
    } else {
    returnString += array[i].toUpperCase() + array[i].toLowerCase().repeat(i) + "-";
    }
      
    }
    return returnString;
  }