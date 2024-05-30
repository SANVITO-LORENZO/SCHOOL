import java.util.Random;

public class ThAgenzia extends Thread {
    Stato stato;
    Agenzia agenzia;
    Aereo aereo;
    Random random = new Random();
    public ThAgenzia(Agenzia agenzia) {
        this.agenzia = agenzia;
        this.stato=Stato.ottieniIstanza();
        this.aereo=Aereo.ottieniistanza();
    }
    @Override
    public void run() {
        while(stato.stato==1){
            
            try {
                aereo.aggiungiPosti(random.nextInt(6), agenzia);
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

    

}
