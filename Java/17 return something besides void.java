import java.util.Scanner;

public class Program {
  static double fahr(double celsius) {
    return 1.8 * celsius + 32;
  }
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    double c = sc.nextDouble();
    System.out.println(fahr(c));
  }
}

// an example of returning a double with a method instead of just void