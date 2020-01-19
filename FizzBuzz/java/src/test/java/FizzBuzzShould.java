import com.sun.org.apache.xpath.internal.operations.Bool;
import org.junit.Assert;
import org.junit.Test;
import sun.reflect.generics.reflectiveObjects.NotImplementedException;

public class FizzBuzzShould {
    @Test
    public void return_string_empty_when_is_null(){
        Assert.assertEquals("", fizzBuzz(null));
    }
    @Test
    public void work(){
        Assert.assertEquals(true, true);
    }

    @Test
    public void return_fizz_when_is_divisible_by_thee(){
        Assert.assertEquals("fizz", fizzBuzz(3));
    }

    @Test
    public void return_buzz_when_is_divisible_by_five(){
        Assert.assertEquals("buzz", fizzBuzz(5));
    }

    @Test
    public void return_fizzBuzz_when_is_divisible_by_three_and_five(){
        Assert.assertEquals("fizzBuzz", fizzBuzz(15));
    }

    @Test
    public void return_the_same_number_when_is_neither_divisible_by_three_nor_five(){
        final Integer number = 4;
        Assert.assertEquals(number.toString(), fizzBuzz(number));
    }

    private String fizzBuzz(Integer number) {
        if(number == null){
            return "";
        }
        if(isDivisibleByThree(number) && isDivisibleByFive(number)){
            return "fizzBuzz";
        }
        if(isDivisibleByThree(number)){
            return "fizz";
        }
        if(isDivisibleByFive(number)){
            return "buzz";
        }
        return number.toString();
    }

    private Boolean isDivisibleByThree(Integer number){
        return isDivisibleBy(number, 3);
    }

    private Boolean isDivisibleByFive(Integer number){
        return isDivisibleBy(number, 5);
    }

    private Boolean isDivisibleBy(Integer dividend, Integer divider){
        return dividend % divider == 0;
    }
}
