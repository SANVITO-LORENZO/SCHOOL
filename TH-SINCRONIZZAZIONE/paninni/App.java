public class App {

    public static void main(String[] args) {
         TimerTavolo t= new TimerTavolo();
         Produttore p1 = new Produttore();
         Consumatore c1 = new Consumatore();
         t.start();
         c1.start();
         p1.start();

         try {
            c1.join();
            p1.join();
         } catch (Exception e) {
         }

         System.out.println("TOT RIMOSSI DA CONSUMATORE 1");
         System.out.println(c1.getNumeroTot());
         System.out.println(c1.LIstaStampa());

         System.out.println("TOT PRODOTTI DA PRODUTTORE 1");
         System.out.println(p1.getNumeroTot());
         System.out.println(p1.LIstaStampa());
         
    }
}