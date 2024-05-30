public class app {

    public static void main(String[] args) {
        Thread_ t1=new Thread_(20,"din");
        Thread_ t2=new Thread_(30,"don");
        Thread_ t3=new Thread_(50,"dan");

        t1.start();
        t2.start();
        t3.start();

        try {
            t1.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        try {
            t2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        try {
            t3.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}