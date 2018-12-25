let Cashier = require('./cashier');

describe('Cashier', function(){
    it('returns the price of each book', function(){
        const numberOfBooks = 1;
        const pricePerBook = 8;
        let cashier = new Cashier();
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(pricePerBook);
    });

    it('returns the price with discount for two books', function(){
        const numberOfBooks = 2;
        const totalPrice = 15.95;
        let cashier = new Cashier();
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(totalPrice);
    });
});