function vowelChange(str, vow) {
    var array = str.split("");
    for(var i = 0; i<array.length; i++) {
      if(array[i] == 'a' || array[i] == 'i' || array[i] == 'e' || array[i] == 'o' || array[i] == 'u') {
        array[i] = vow;
      }
    }
    var retString = array.join("");
    return retString;
  }