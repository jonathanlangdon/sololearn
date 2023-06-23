import java.util.Scanner;

public class Program {
  static void bot() {
      Scanner sc = new Scanner(System.in);
      int num = sc.nextInt();
      if (num == 1) {
        System.out.println("Order confirmed");
      } else if (num == 2) {
         System.out.println("info@sololearn.com");
    } else {
      System.out.println("Try again");
    }
  } 
  public static void main(String[] args) {
    bot();
  }
 
}
//creating new methods 