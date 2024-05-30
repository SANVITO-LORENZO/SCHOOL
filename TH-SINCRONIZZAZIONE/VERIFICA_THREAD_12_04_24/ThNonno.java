import java.util.Random;

public class ThNonno extends Thread {
    Stato stato;
    Tavolo vett;
    String nome;
    Random random= new Random();

    public ThNonno(String nome) {
        this.stato = Stato.getIstanza();
        this.vett = Tavolo.getIstanza();
        this.nome=nome;
    }

    @Override
    public void run() {
        while(!stato.stato){
            vett.removeCaramella(nome);
            try {
                sleep(300 + random.nextInt(150));
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
