let Cashier = require('./cashier');

describe('Cashier', function(){
    let cashier;
    
    beforeEach(function(){
        cashier = new Cashier();
    });

    it('returns the price of each book', function(){
        const numberOfBooks = 1;
        const pricePerBook = 8;
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(pricePerBook);
    });

    it('returns the price with discount for two books', function(){
        const numberOfBooks = 2;
        const totalPrice = 15.95;
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(totalPrice);
    });
});