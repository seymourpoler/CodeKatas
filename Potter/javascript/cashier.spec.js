describe('Cashier', function(){
    let cashier;

    beforeEach(function(){
        cashier = new Cashier();
    });

    describe('when the biil is requested with number of different books', function(){
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
    
        it('returns the price with discount for five books', function(){
            const numberOfBooks = 5;
            const totalPrice = 39.8;
            
            const price = cashier.bill(numberOfBooks);
            
            expect(price).toBe(totalPrice);
        });
    
        it('returns the price with discount for six books', function(){
            const numberOfBooks = 6;
            const totalPrice = 47.7;
            
            const price = cashier.bill(numberOfBooks);
            
            expect(price).toBe(totalPrice);
        });
    
        it('returns the price with discount for all collection books', function(){
            const numberOfBooks = 7;
            const totalPrice = 55.55;
            
            const price = cashier.bill(numberOfBooks);
            
            expect(price).toBe(totalPrice);
        });
    });

    describe('when the price is requested with all purchased books', function(){
        it('returns the price with null books', function(){
            const freePrice = 0;

            const result = cashier.calculatePrice(null);
    
            expect(result).toBe(freePrice);
        });

        it('returns the price with no books', function(){
            const freePrice = 0;

            const result = cashier.calculatePrice([]);
    
            expect(result).toBe(freePrice);
        });

        it('returns the price with one books', function(){
            const pricePerBook = 8;

            const result = cashier.calculatePrice([2]);
    
            expect(result).toBe(pricePerBook);
        });

        it('returns the price with two different books', function(){
            const totalPrice = 15.95;

            const result = cashier.calculatePrice([2, 5]);
    
            expect(result).toBe(totalPrice);
        });

        it('returns the price with two same books', function(){
            debugger;
            const totalPrice = 16;

            const result = cashier.calculatePrice([5, 5]);
    
            expect(result).toBe(totalPrice);
        });

        it('returns the price with three different books', function(){
            const totalPrice = 23.9;

            const result = cashier.calculatePrice([2, 5, 1]);
    
            expect(result).toBe(totalPrice);
        });

        it('returns the price with two different books', function(){
            const totalPrice = 23.95;

            const result = cashier.calculatePrice([2, 5, 2]);
    
            expect(result).toBe(totalPrice);
        });

        it('returns the price with the same three books', function(){
            const totalPrice = 24;

            const result = cashier.calculatePrice([2, 2, 2]);
    
            expect(result).toBe(totalPrice);
        });
    });
});