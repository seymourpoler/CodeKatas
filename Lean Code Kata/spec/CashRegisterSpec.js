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
  it("the price for cherry and apple", function(){
    var billResult = cashRegister.with('cherry').with('apple').getTheBill();
    expect(billResult.totalPrice).toEqual(165);
  });
  it("the price for apple and bannana", function(){
    var billResult = cashRegister.with('apple').with('bannana').getTheBill();
    expect(billResult.totalPrice).toEqual(175);
  });
  it("the price for apple, bannana and cherry", function(){
    var billResult = cashRegister.with('apple').with('bannana').with('cherry').getTheBill();
    expect(billResult.totalPrice).toEqual(265);
  });
});
