public class App {

    public static void main(String[] args) {
        ThNipote thN1 = new ThNipote("qui");
        ThNipote thN2 = new ThNipote("quo");
        ThNipote thN3 = new ThNipote("qua");

        ThNonno thNo1= new ThNonno("paperino");
        ThNonno thNo2= new ThNonno("paperina");

        ThStampa thS = new ThStampa();

        thN1.start();
        thN2.start();
        thN3.start();
        thNo1.start();
        thNo2.start();
        thS.start();

        try {
            thN1.join();       
            thN2.join();
            thN3.join();
            thNo1.join();
            thNo2.join();
            thS.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        Tavolo tavolo= Tavolo.getIstanza();
        System.out.println("LISTA COMPLETA");
        System.out.println(tavolo.stampa());

        System.out.println(tavolo.classifica());
        
        if(tavolo.paperino>tavolo.paperina){
            System.out.println("PAPERINO: " + tavolo.paperino);
            System.out.println("PAPERINA: " + tavolo.paperina);
        }
        else
            System.out.println("PAPERINA: " + tavolo.paperina);
            System.out.println("PAPERINO: " + tavolo.paperino);

        
    }
}