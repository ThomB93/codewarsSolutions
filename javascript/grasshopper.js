function move (position, roll) {
    // return the new position
    return position + (roll*2);
  }
  function combat(health, damage) {
    // Write your code here
    var newHealth = health - damage;
    if(newHealth < 0) {
    return 0;
    }
    return health - damage;
    
  }