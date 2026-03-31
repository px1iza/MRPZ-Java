class OneThread extends Thread {
    public void run() {
        try {
            while (true) {
                System.out.println("1");
                Thread.sleep(1000);
            }
        } catch (InterruptedException e) {
            System.out.println(e);
        }
    }
}

class TwoThread extends Thread {
    public void run() {
        try {
            while (true) {
                System.out.println("2");
                Thread.sleep(2000);
            }
        } catch (InterruptedException e) {
            System.out.println(e);
        }
    }
}

class ThreeThread extends Thread {
    public void run() {
        try {
            while (true) {
                System.out.println("3");
                Thread.sleep(3000);
            }
        } catch (InterruptedException e) {
            System.out.println(e);
        }
    }
}

public class Main {
    public static void main(String[] args) {

        OneThread t1 = new OneThread();
        TwoThread t2 = new TwoThread();
        ThreeThread t3 = new ThreeThread();
        t1.start();
        t2.start();
        t3.start();
    }
}