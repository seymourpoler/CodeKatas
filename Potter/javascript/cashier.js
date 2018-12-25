function Cashier(){
    let self = this;

    self.bill = function(numberOfBooks){
        const pricePerBook = 8;
        if(numberOfBooks == 1){
            return pricePerBook;
        }
        return 15.95;
    };
}

module.exports = Cashier;