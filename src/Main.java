

class Main {
    public static void main(String[] args) {

        System.out.println("Rabirokh Elizaveta");
        System.out.println("121 Group");
        System.out.println("Var 22");
        System.out.println();

        int matrix[][] = new int[4][4];
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                matrix[i][j] = (int) (Math.random() * 10);
            }
        }

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }

        for (int i = 0; i < 4; i++) {
            int temp = matrix[i][0];
            matrix[i][0] = matrix[i][i];
            matrix[i][i] = temp;
        }
        System.out.println();

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix.length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }

        int sum = 0;
        for (int i = 0; i < 4; i++) {
            sum = matrix[i][0] + sum;
        }
        System.out.println(sum);

    }
}
