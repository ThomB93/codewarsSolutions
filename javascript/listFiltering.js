function filter_list(l) {
    // Return a new array with the strings filtered out
   var numbers = l.filter((ele) => {
   return typeof ele == "number";
   })
   return numbers;
  }