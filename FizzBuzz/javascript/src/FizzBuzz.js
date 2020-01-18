function fizzBuzz(number){
    if(IsNotNumber(number)){
        return '';
    }
    
    if(number <= 0){
        return '';
    }
    
    if(isDividedByThree(number) && isDividedByFive(number)){
        return 'fizzbuzz';
    }
    if(isDividedByThree(number)){
        return 'fizz';
    }
    if(isDividedByFive(number)){
        return 'buzz';
    }

    return number;

    function IsNotNumber(aNumber){
        return aNumber === undefined || aNumber === null;
    }

    function isDividedByThree(aNumber){
        return aNumber % 3 == 0;
    }

    function isDividedByFive(aNumber){
        return aNumber % 5 == 0;
    }
}

module.exports = fizzBuzz;
//export function fizzBuzz;