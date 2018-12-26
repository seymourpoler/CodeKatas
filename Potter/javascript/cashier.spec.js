let Cashier = require('./cashier');

describe('Cashier', function(){
    let cashier;

    beforeEach(function(){
        cashier = new Cashier();
    });

    it('returns zero if there is no books', function(){
        const numberOfBooks = 0;
        const noPrice = 0;
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(noPrice);
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

    it('returns the price with discount for three books', function(){
        const numberOfBooks = 3;
        const totalPrice = 23.9;
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(totalPrice);
    });

    it('returns the price with discount for four books', function(){
        const numberOfBooks = 4;
        const totalPrice = 31.85;
        
        const price = cashier.bill(numberOfBooks);
        
        expect(price).toBe(totalPrice);
    });
    
});