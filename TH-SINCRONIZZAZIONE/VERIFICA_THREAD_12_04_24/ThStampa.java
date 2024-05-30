public class ThStampa extends Thread{
    Tavolo tavolo;
    Stato stato;

    public ThStampa() {
        this.tavolo = Tavolo.getIstanza();
        this.stato = Stato.getIstanza();
    }

    @Override
    public void run() {
        
        while(!stato.stato){
            System.out.println(tavolo.stampa());
            try {
                sleep(70);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }       
        }
    }

    

}
