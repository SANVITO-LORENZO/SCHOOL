public class App {
    public static void main(String[] args) {

        //ATTRIBUTI
        MyVett vett = new MyVett();
        int num = 10;
        MyThread[] threads = new MyThread[num];

        //CREO E STARTO I THREAD
        for (int i = 0; i < num; i++) {
            threads[i] = new MyThread(i + 1, vett);
            threads[i].start();
        }

        try {
            //JOIN
            for (int i = 0; i < num; i++) {
                threads[i].join();
            }
            //STAMPA VETTORE
            for(int x=0;x<1000;x++){
                System.out.println("numero: " + vett.getel(x));
            }
        } catch (Exception e) {
            
        }
    }
}
