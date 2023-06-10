import java.util.Scanner;

public class Program {
  static void convert(double feet) {
      System.out.print(feet * 12.0);
  } 
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    double num = sc.nextDouble();
    convert(num);
  }
}
