describe("Money Breakdown", function() {
  var money = new Money();
  beforeEach(function(){});
  it("breakdown for 1 euro", function(){
    var result = money.breakDown(1);
    expect(result[0].moneyType).toBe('coins');
  });
});
