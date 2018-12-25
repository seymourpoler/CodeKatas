function Cashier(){
    let self = this;

    self.bill = function(numberOfBooks){
        const pricePerBook = 8;
        return pricePerBook;
    };
}

module.exports = Cashier;