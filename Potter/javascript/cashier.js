function Cashier(){
    let self = this;

    self.bill = function(numberOfBooks){
        const pricePerBook = 8;
        if(numberOfBooks == 1){
            return pricePerBook;
        }
        if(numberOfBooks == 2){
            const result = pricePerBook * numberOfBooks - (5/100);
            return result;
        }
        if(numberOfBooks == 3){
            const result = pricePerBook * numberOfBooks - (10/100);
            return result;
        }
        const result = pricePerBook * numberOfBooks - (15/100);
        return result;
        
    };
}

module.exports = Cashier;