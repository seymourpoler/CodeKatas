function Cashier(){
    let self = this;

    self.bill = function(numberOfBooks){
        const pricePerBook = 8;
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
        if(books.length == 0){
            return freePrice;
        }
        throw 'not implemented';    
    }
}

module.exports = Cashier;