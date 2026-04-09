import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Random rand = new Random();
        int[] numbers = new int[3];
        int[] firstDigits = new int[3];

        for (int i = 0; i < 3; i++) {
            numbers[i] = rand.nextInt(1000, 10000);
            firstDigits[i] = Integer.toString(numbers[i]).charAt(0) - '0';
        }

        System.out.println("Згенеровані числа: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
        System.out.println("Перші цифри: " + firstDigits[0] + ", " + firstDigits[1] + ", " + firstDigits[2]);

        int maxDigit = firstDigits[0];
        for (int i = 0; i < firstDigits.length; i++) {
            if (firstDigits[i] > maxDigit) {
                maxDigit = firstDigits[i];
            }
        }
        System.out.println("Найбільша перша цифра: " + maxDigit);

        // 2 task
        String text = "Sun сіло за містом, відкидаючи довгі тіні на вулиці.\n" +
                "Люди поверталися додому, розмовляючи та сміючись with friends.\n" +
                "Запах свіжого хліба доносився з найближчої пекарні.\n" +
                "Птахи літали по небу, повертаючись до своїх гнізд.\n" +
                "Була спокійна і затишна вечірня пора, ідеальна для прогулянки в парку.";

        System.out.println(text);
        System.out.println("Кількість символів: " + text.length());

        String[] lines = text.split("\n");
        int countLines = lines.length;
        System.out.println("Кількість рядків: " + countLines);

        String[] words = text.split("[\\s.,!?:;]+");
        int countWords = words.length;
        System.out.println("Кількість слів: " + countWords);

        int latinWords = 0;

        for (int i = 0; i < words.length; i++) {
            for (int j = 0; j < words[i].length(); j++) {
                char c = words[i].charAt(j);

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) {
                    latinWords++;
                    break;
                }
            }
        }
        System.out.println("Слів з латинськими буквами: " + latinWords);
    }
}