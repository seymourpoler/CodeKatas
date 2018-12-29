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

        var currentBooks = clone(books);
        var result = 0;
        while(currentBooks.length > 0){
            const notDuplicated = findNotDuplicated(currentBooks);
            currentBooks = removeDuplicated(notDuplicated, currentBooks);
            result = result + self.bill(notDuplicated.length);
        }
        return result;
    }

    function clone(elements){
        const result = elements.slice(0);
        return result;
    }

    function findNotDuplicated(elements){
        let result = [];
        for (let position = 0; position < elements.length; position++)
            if (result.indexOf(elements[position]) === -1 && elements[position] !== '')
                result.push(elements[position]);
        return result;
    }

    function removeDuplicated(source, target){
        let result = clone(target);
        for(let position=0; position<source.length; position++){
            result = removeElement(result, source[position]);
        }
        return result;
    }

    function removeElement(elements, element){
        const result = elements.splice( elements.indexOf(element), 1);
        return result;
    }
}