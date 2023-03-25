package net.seymourpoler.smartFridgeKata;

import java.util.ArrayList;
import java.util.Collections;

public class SmartFridgePrinter {
    private final DateService dateService;
    private final Printer printer;

    public SmartFridgePrinter(DateService dateService, Printer printer){
        this.dateService = dateService;
        this.printer = printer;
    }

    public void print(ArrayList<Product> products){
        if(products.isEmpty()){
            printer.print("");
            return;
        }

        Collections.sort(products, this::compare);
        var message = "";
        for (var product : products) {
            message = message + getMessage(product);
        }

        printer.print(message);
    }

    private String getMessage(Product product){
        if(product.isExpired(dateService.getDateNow()))
            return "EXPIRED: " + product.Name + "\r\n";

        return product.Name + ": " + product.getRemainingDays(dateService.getDateNow()) + " days remaining\r\n";
    }

    private int compare(Product p1, Product p2) {
        return p1.getRemainingDays(dateService.getDateNow()) - p2.getRemainingDays(dateService.getDateNow());
    }
}
