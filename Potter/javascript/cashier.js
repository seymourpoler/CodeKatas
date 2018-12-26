function Cashier(){
    let self = this;
    const discounts = [0, 0, 5, 10, 15, 20, 30, 45];

    self.bill = function(numberOfBooks){
        const pricePerBook = 8;
        const percentageDiscount = calculatePercentageDiscount(numberOfBooks);
        const price = (pricePerBook * numberOfBooks)
        const priceWithPercentageDiscount =  price - percentageDiscount;
        return priceWithPercentageDiscount;

        function calculatePercentageDiscount(numberOfBooks){
            const percent = 100;
            const discount = discounts[numberOfBooks];
            return discount / percent;
        }
    };
}

module.exports = Cashier;