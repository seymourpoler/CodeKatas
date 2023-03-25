package net.seymourpoler.smartFridgeKata;

import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;

import static org.mockito.Mockito.*;

public class SmartFridgeShould {
    Printer printer;
    SmartFridge smartFridge;
    DateService dateService;
    SmartFridgePrinter smartFridgePrinter;

    @Before
    public void setUp(){
        printer = mock(Printer.class);
        dateService = mock(DateService.class);
        smartFridgePrinter = new SmartFridgePrinter(dateService, printer);
        smartFridge = new SmartFridge(smartFridgePrinter);
    }

    @Test(expected = UnsupportedOperationException.class)
    public void throw_exception_when_is_closed_and_add_a_product(){
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
    }

    @Test(expected = UnsupportedOperationException.class)
    public void throw_exception_when_open_and_close_and_add_a_product(){
        smartFridge.open();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
        smartFridge.close();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
    }

    @Test
    public void decrease_two_days_opened_product_expiration_when_fridge_is_opened(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 16));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "17-10-2021", "opened"));
        smartFridge.close();
        smartFridge.open();smartFridge.close();
        smartFridge.open();smartFridge.close();

        smartFridge.show();

        final String expectedResult = "EXPIRED: Milk\r\n";
        verify(printer).print(expectedResult);
    }

    @Test
    public void decrease_one_days_sealed_product_expiration_when_fridge_is_opened(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 16));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "17-10-2021", "sealed"));
        smartFridge.close();
        smartFridge.open();smartFridge.close();

        smartFridge.show();

        final String expectedResult = "Milk: 0 days remaining\r\n";
        verify(printer).print(expectedResult);
    }

    @Test
    public void not_show_nothing_when_is_empty(){
        smartFridge.show();

        verify(printer).print("");
    }

    @Test(expected = IllegalStateException.class)
    public void throw_exception_when_is_not_closed(){
        smartFridge.open();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));

        smartFridge.show();
    }

    @Test
    public void show_a_product(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 18));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
        smartFridge.close();

        smartFridge.show();

        final String expectedResult = "Milk: 3 days remaining\r\n";
        verify(printer).print(expectedResult);
    }

    @Test
    public void show_a_expired_product(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 18));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "16-10-2021", "sealed"));
        smartFridge.close();

        smartFridge.show();

        final String expectedResult = "EXPIRED: Milk\r\n";
        verify(printer).print(expectedResult);
    }

    @Test
    public void show_several_products(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 18));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
        smartFridge.add(new Product("Cheese", "18-11-2021", "opened"));
        smartFridge.add(new Product("Beef", "10-10-2021", "sealed"));
        smartFridge.close();

        smartFridge.show();

        final String expectedResult = "EXPIRED: Beef\r\n" +
                "Milk: 3 days remaining\r\n" +
                "Cheese: 31 days remaining\r\n";
        verify(printer).print(expectedResult);
    }
}
