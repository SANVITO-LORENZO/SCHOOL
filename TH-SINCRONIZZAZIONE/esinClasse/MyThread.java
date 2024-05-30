public class MyThread extends Thread {

    //ATTRIBUTI
    int num;
    MyVett vett;

    //COSTRUTTORE
    public MyThread(int num, MyVett vett) {
        this.num = num;
        this.vett = vett;
    }

    //RUN
    @Override
    public void run() {
        for (int x =0;x<100;x++){
            vett.addVett(num);
        }
    }
}
