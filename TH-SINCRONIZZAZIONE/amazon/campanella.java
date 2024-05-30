public class campanella  extends Thread{
    boolean stato;

    public campanella() {
        this.stato= true;
    }

    @Override
    public void run() {
        
        try {
            sleep(60000);
        } catch (Exception e) {
            
        }

        this.stato=false;
    }

    public boolean isStato() {
        return stato;
    }
    
    
}


