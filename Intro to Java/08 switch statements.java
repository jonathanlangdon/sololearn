import  java.util.Scanner;

public class Program {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    String color = sc.nextLine();
    int number = 0;
    switch (color) {
      case "red":
        number = 1;
        break;
      case "green":
        number = 2;
        break;
      case "black":
        number = 3;
        break;
    }
    System.out.println(number);
    }
}
