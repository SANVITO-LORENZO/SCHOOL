public class Thrullo extends Thread {

 private rullo rullo;

    public Thrullo(rullo rullo) {
    this.rullo = rullo;
}

    @Override
    public void run() {

        int num_cas=(int)(Math.random()*10);
        for(int i=0;i<num_cas;i++){
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            this.rullo.cambiavalore();
        }
    }

}
