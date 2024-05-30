public class ThHacker extends Thread {
    Stato stato;
    Aereo aereo;
    public ThHacker() {
        this.stato=Stato.ottieniIstanza();
        this.aereo=Aereo.ottieniistanza();
    }
    @Override
    public void run() {
        while(stato.stato==1){
            try {
                aereo.eliminaPosto();
                Thread.sleep(800);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
