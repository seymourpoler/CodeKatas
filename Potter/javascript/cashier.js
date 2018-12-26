function Cashier(){
    let self = this;
    const pricePerBook = 8;

    self.bill = function(numberOfBooks){
        
        const percentageDiscount = calculatePercentageDiscount(numberOfBooks);
        const price = (pricePerBook * numberOfBooks)
        const priceWithPercentageDiscount =  price - percentageDiscount;
        return priceWithPercentageDiscount;

        function calculatePercentageDiscount(numberOfBooks){
            const discounts = [0, 0, 5, 10, 15, 20, 30, 45];
            const percent = 100;
            const discount = discounts[numberOfBooks];
            return discount / percent;
        }
    };

    self.calculatePrice = function(books){
        const freePrice = 0;
        if(!books){
            return freePrice;
        }
        if(books.length == 0){
            return freePrice;
        }
        if(books.length == 1){
            return pricePerBook;
        }
        if(books.length == 2){
            if(books[0] != books[1]){
                const result = self.bill(2);
                return result;
            }
            const result = pricePerBook * 2;
            return result;
        }
        throw 'not implemented';    
    }
}

module.exports = Cashier;