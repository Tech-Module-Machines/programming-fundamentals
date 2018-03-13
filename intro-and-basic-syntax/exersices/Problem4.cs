import java.math.BigDecimal;
import java.util.Scanner;

public class P04_BeverageLabels {
    public static void main(String[] args) {
		//We initialize the scanner to read from the console
        Scanner scan = new Scanner(System.in);
		//the next 4 rows are what we will read
        String product = scan.nextLine();
        int volume = Integer.parseInt(scan.nextLine());
        int energyPer100ml = Integer.parseInt(scan.nextLine());
        int sugarPer100ml = Integer.parseInt(scan.nextLine());
        //we put the input in big decimal object
        BigDecimal totalEnergy = new BigDecimal(String.valueOf(energyPer100ml / 100.0 * volume));
        BigDecimal totalSugar = new BigDecimal(String.valueOf(sugarPer100ml * volume / 100.0));
     // we print the results with printf where we implemented our custom method
        System.out.printf("%dml %s:%n", volume, product);
        System.out.printf("%skcal, %sg sugars", customRound(totalEnergy), customRound(totalSugar));
    }
      //Here is the our method for custom round
    static String customRound(BigDecimal number){
        String numberString = number.setScale(12,BigDecimal.ROUND_HALF_UP).toString();
        int index = 15 - numberString.indexOf('.');
        number = new BigDecimal(numberString).setScale(index,BigDecimal.ROUND_HALF_UP)
                .setScale(12, BigDecimal.ROUND_HALF_UP).stripTrailingZeros();
        double numDouble = Double.parseDouble(number.toString());
        boolean remainder = numDouble % 1 == 0;
        return remainder ? String.format("%.0f", numDouble) : number.toString();
    }
}