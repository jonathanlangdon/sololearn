import  java.util.Scanner;

public class Program {
  public static void main(String[] args) {
    Scanner scn = new Scanner(System.in);
    int temp = scn.nextInt();
    if (temp >= 100) {
      System.out.println("Boiling");
    } else {
      System.out.println("Not boiling");
    }
  }
}

// showing how to use if statements