import  java.util.Scanner;

public class Program {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    int num = sc.nextInt();
    int i = 1;
    int sum = 0;
    while (i < num + 1) {
      sum += i;
      i++;
    }
    System.out.println(sum);
  }

}
