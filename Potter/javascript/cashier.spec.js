let Cashier = require('./cashier');

describe('Potter', function(){
    it('returns the price of each book', function(){
        const numberOfBooks = 1;
        const pricePerBook = 8;
        let cashier = new Cashier();
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(pricePerBook);
    });
});