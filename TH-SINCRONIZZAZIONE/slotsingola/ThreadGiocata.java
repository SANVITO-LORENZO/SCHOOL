public class ThreadGiocata extends Thread {

    MyPanel panel;
    Portafolio portafolio;

    public ThreadGiocata(MyPanel panel) {
        this.panel = panel;
        this.portafolio = Portafolio.getInstanza();
    }

    @Override
    public void run() {

        if(portafolio.effettuaGiocata()==false){
            panel.risultato="NON HAI ABBASTANZA SOLDI!";
            return;
        }

        Thrullo t1= new Thrullo(panel.r1);
        Thrullo t2= new Thrullo(panel.r2);
        Thrullo t3= new Thrullo(panel.r3);

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

        System.out.println("RISULTATI: "+ panel.r1.valore+" "+ panel.r2.valore+" "+panel.r3.valore);

        if(panel.r1.valore==panel.r2.valore&&panel.r2.valore==panel.r3.valore){
            panel.risultato="vinto";
            portafolio.aggiungivincita(10);
        }
        else
            panel.risultato="perso";
    }
                
    
}
