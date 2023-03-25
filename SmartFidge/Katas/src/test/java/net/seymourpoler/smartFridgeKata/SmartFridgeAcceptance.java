package net.seymourpoler.smartFridgeKata;

import org.junit.Before;
import org.junit.Test;

import java.time.LocalDate;

import static org.mockito.Mockito.*;

public class SmartFridgeAcceptance {
    Printer printer;
    DateService dateService;
    SmartFridgePrinter smartFridgePrinter;
    SmartFridge smartFridge;

    @Before
    public void setUp(){
        printer = mock(Printer.class);
        dateService = mock(DateService.class);
        smartFridgePrinter = new SmartFridgePrinter(dateService, printer);
        smartFridge = new SmartFridge(smartFridgePrinter);
    }

    @Test
    public void  show_products(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 18));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "21-10-2021", "sealed"));
        smartFridge.add(new Product("Cheese", "18-11-2021", "sealed"));
        smartFridge.add(new Product("Beef", "18-10-2021", "sealed"));
        smartFridge.add(new Product("Lettuce", "22-10-2021", "sealed"));
        smartFridge.close();

        smartFridge.show();

        verify(printer).print("Beef: 0 days remaining\r\n" +
                "Milk: 3 days remaining\r\n" +
                "Lettuce: 4 days remaining\r\n" +
                "Cheese: 31 days remaining\r\n");
    }

    @Test
    public void  show_expired_products(){
        when(dateService.getDateNow()).thenReturn(LocalDate.of(2021, 10, 18));
        smartFridge.open();
        smartFridge.add(new Product("Milk", "18-10-2021", "opened"));
        smartFridge.close();
        smartFridge.open();
        smartFridge.add(new Product("Cheese", "18-11-2021", "sealed"));
        smartFridge.close();
        smartFridge.open();
        smartFridge.add(new Product("Beef", "18-10-2021", "sealed"));
        smartFridge.close();
        smartFridge.open();
        smartFridge.add(new Product("Lettuce", "22-10-2021", "sealed"));
        smartFridge.close();
        smartFridge.open();
        smartFridge.add(new Product("Tomato", "21-10-2021", "opened"));
        smartFridge.close();
        smartFridge.open();
        smartFridge.add(new Product("Orange", "20-10-2021", "sealed"));
        smartFridge.close();

        smartFridge.show();

        verify(printer).print("EXPIRED: Milk\r\n" +
                "EXPIRED: Beef\r\n" +
                "Tomato: 1 days remaining\r\n" +
                "Lettuce: 2 days remaining\r\n" +
                "Orange: 2 days remaining\r\n" +
                "Cheese: 27 days remaining\r\n");
    }
}
