package net.seymourpoler.smartFridgeKata;

import java.util.ArrayList;

public class SmartFridge {
    private final SmartFridgePrinter smartFridgePrinter;
    private boolean isClosed;
    private ArrayList<Product> products;

    public SmartFridge(SmartFridgePrinter smartFridgePrinter) {
        this.smartFridgePrinter = smartFridgePrinter;
        isClosed = true;
        products = new ArrayList<>();
    }

    public void add(Product product) {
        if (isClosed){
            throw new UnsupportedOperationException();
        }
        products.add(product);
    }

    public void open() {
        isClosed = false;
        for (var product: products) {
            product.updateExpiration();
        }
    }

    public void close() {
        isClosed = true;
    }

    public void show() {
        if(!isClosed)
            throw new IllegalStateException();

        smartFridgePrinter.print(products);
    }
}
