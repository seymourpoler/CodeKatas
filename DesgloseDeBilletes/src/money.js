function Money(){
  var moneyType = {'tickets': [500, 200, 100, 50, 20, 10, 5], 'coins': [2, 1]};
  this.breakDown = function(money){
    return [{'quantity':1, 'moneyType': 'coins', 'moneyValue':1}];
  };
}
