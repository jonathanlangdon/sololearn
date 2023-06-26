import java.util.Scanner;

public class Main
{
public static void main(String[] args) {
   
    Scanner scanner = new Scanner(System.in);
    int choice = scanner.nextInt();
   
    String[] categories = {"PCs", "Notebooks", "Tablets", "Phones", "Аccessories"};
   
    try {
        System.out.println(categories[choice]);
    } catch(Exception e) {
        System.out.println("Wrong Option");
    }
}
}

// try and catch blocks allow for exception handling