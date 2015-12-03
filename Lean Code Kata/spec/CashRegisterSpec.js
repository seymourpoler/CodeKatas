describe("Cash Register", function() {
  var cashRegister;
  var CHERRY = 'cherry';
  var BANNANA = 'bannana';
  var PLANTANO = 'platano';
  var APPLE = 'apple';

  beforeEach(function() {
    cashRegister = new CashRegister();
  });

  it("the price for a bannana", function(){
    var billResult = cashRegister.with(BANNANA).getTheBill();
    
    expect(billResult.totalPrice).toEqual(100);
  });
  it("the price for a apple", function(){
    var billResult = cashRegister.with(APPLE).getTheBill();
    
    expect(billResult.totalPrice).toEqual(75);
  });
  it("the price for a cherry", function(){
    var billResult = cashRegister.with(CHERRY).getTheBill();
    
    expect(billResult.totalPrice).toEqual(90);
  });
  it("the price for cherry and apple", function(){
    var billResult = cashRegister.with(CHERRY)
                                  .with(APPLE)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(165);
  });
  it("the price for apple and bannana", function(){
    var billResult = cashRegister.with(APPLE)
                                  .with(BANNANA)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(175);
  });
  it("the price for apple, bannana and cherry", function(){
    var billResult = cashRegister.with(APPLE)
                                  .with(BANNANA)
                                  .with(CHERRY)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(265);
  });
  it("the price for apple, bannana and cherry", function(){
    var billResult = cashRegister.with(APPLE)
                                  .with(BANNANA)
                                  .with(CHERRY)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(265);
  });
  it("second cherry have price", function(){
    var billResult = cashRegister.with(CHERRY)
                                  .with(CHERRY)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(135);
  });
  it("the price for a type of bannana, is platano", function(){
    var billResult = cashRegister.with(PLANTANO).getTheBill();
    expect(billResult.totalPrice).toEqual(105);
  });
  it("3 cherrys plus apple", function(){
    var billResult = cashRegister.with(CHERRY)
                                  .with(CHERRY)
                                  .with(CHERRY)
                                  .with(APPLE)
                                  .getTheBill();
    
    expect(billResult.totalPrice).toEqual(300);
  });
});
