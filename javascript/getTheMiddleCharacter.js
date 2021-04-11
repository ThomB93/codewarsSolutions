function getMiddle(s)
{
  //Code goes here!
  if(s.length % 2 === 0) { //even
    return s.substring((s.length/2)-1, (s.length/2)+1);
  }
  else { //odd
    return s.substring((s.length/2),(s.length/2)+1);
  }
}