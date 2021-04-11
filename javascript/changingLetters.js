function swap(st){
    var array = st.split("");
    var newArr = array.map(element => {
      if(['a', 'e', 'i', 'o', 'u'].indexOf(element.toLowerCase()) !== -1) {
        return element.toUpperCase();
      }
      return element;
    })
    return newArr.join("");
    
  }