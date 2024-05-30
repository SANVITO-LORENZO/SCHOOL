public class TimerTavolo extends Thread{
    
    boolean finito;
    Tavolo tavolo;

    public TimerTavolo() {
        this.finito = false;
        tavolo= Tavolo.getIstanza();
    }

    @Override
    public void run() {
        try {
            sleep(5000);
            
        } catch (Exception e) {
            e.printStackTrace();
        }
         tavolo.stato= true;
    }

}
