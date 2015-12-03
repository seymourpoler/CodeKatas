describe("Cash Register", function() {
  var cashRegister;

  beforeEach(function() {
    cashRegister = new CashRegister();
  });
  it("the price for a bannana", function(){
    var billResult = cashRegister.with('bannana').getTheBill();
    expect(billResult.totalPrice).toEqual(100);
  });
  it("the price for a apple", function(){
    var billResult = cashRegister.with('apple').getTheBill();
    expect(billResult.totalPrice).toEqual(75);
  });
  it("the price for a cherry", function(){
    var billResult = cashRegister.with('cherry').getTheBill();
    expect(billResult.totalPrice).toEqual(90);
  });
});
