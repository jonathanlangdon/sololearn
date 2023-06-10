import java.util.Scanner;

public class Main {

   public static void main(String[] args) {
       Scanner read = new Scanner(System.in);
       String firstName = read.nextLine();
       String lastName = read.nextLine();
       int age = read.nextInt();
       int roomNumber = read.nextInt();
       Customer customer = new Customer();
       customer.firstName = firstName;
       customer.lastName = lastName;
       customer.age = age;
       customer.roomNumber = roomNumber;
       customer.saveCustomerInfo();
   }
}

class Customer {
   String firstName;
   String lastName;
   int age;
   int roomNumber;
   public void saveCustomerInfo() {
       System.out.println("First name: " + firstName);
       System.out.println("Second name: " + lastName);
       System.out.println("Age: " + age);
       System.out.println("Room number: " + roomNumber);
   }
}
