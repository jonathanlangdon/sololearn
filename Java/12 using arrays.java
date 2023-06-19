import  java.util.Scanner;

public class Program {
  public static void main(String[] args) {
    String[] menu = {"Tea", "Espresso", "Americano", "Water", "Hot Chocolate"};
    Scanner sc = new Scanner(System.in);
    int choice = sc.nextInt();
    if (choice < 0 || choice > menu.length - 1) {
      System.out.println("Invalid");
    } else {
      System.out.println(menu[choice]);
    }
  }

}
