import  java.util.Scanner;

public class Program {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    int age = sc.nextInt();
    String message = "";
    if (age > 0 && age < 12) {
      message = "Child";
    } else if (age > 11 && age < 18) {
      message = "Teen";
    } else if (age > 17 && age < 65) {
      message = "Adult";
    }
    System.out.println(message);
  }
}
