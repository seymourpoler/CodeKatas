package net.seymourpoler.smartFridgeKata;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;

public class Product {
    public final String Name;
    private LocalDate expiration;
    private final Condition typeOfCondition;

    public Product(String name, String expiration, String condition) {
        Name = name;
        this.expiration = parse(expiration);
        typeOfCondition = Condition.valueOf(condition.toUpperCase());
    }

    private LocalDate parse(String expiration){
        var formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");
        return LocalDate.parse(expiration, formatter);
    }

    public int getRemainingDays(LocalDate dateNow) {
        var daysInBetween = ChronoUnit.DAYS.between(dateNow, expiration);
        return Math.toIntExact(daysInBetween);
    }

    public boolean isExpired(LocalDate now) {
        var daysInBetween = ChronoUnit.DAYS.between(now, expiration);
        return daysInBetween < 0;
    }

    public void updateExpiration(){
        if(typeOfCondition == Condition.OPENED){
            expiration = expiration.minus(2, ChronoUnit.DAYS);
            return;
        }
        expiration = expiration.minus(1, ChronoUnit.DAYS);
    }

    private enum Condition {
        OPENED("opened"),
        SEALED("sealed");

        private String condition;
        Condition(String condition){
            this.condition = condition;
        }

        public String condition(){
            return this.condition;
        }
    }
}
