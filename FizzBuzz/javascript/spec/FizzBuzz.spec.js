const fizzBuzz = require('../src/FizzBuzz');
//import {fizzBuzz} from '../src/FizzBuzz';

describe('fizz buzz kata', () => {
    it('works', () => {
        expect(true).toBe(true);
    });

    it('returns empty when is null', ()=>{
        const result = fizzBuzz(null);

        expect('').toBe(result);
    });

    it('returns empty when is undefined', () => {
        const result = fizzBuzz(undefined);

        expect('').toBe(result);
    });

    it('returns empty when is under one', () => {
        const result = fizzBuzz(-1);

        expect('').toBe(result);
    });
    
    it('returns empty when is zero', () => {
        const result = fizzBuzz(0);

        expect('').toBe(result);
    });
    
    it('returns number when is not divided by three and not five', () =>{
        const result = fizzBuzz(4);

        expect(4).toBe(result);
    });

    it('returns buzz when is divided by five', () => {
        const result = fizzBuzz(5);

        expect('buzz').toBe(result);
    })

    it('return fizzbuzz when is divided by thre and five', ()=>{
        const result = fizzBuzz(15);

        expect('fizzbuzz').toBe(result);
    });
});