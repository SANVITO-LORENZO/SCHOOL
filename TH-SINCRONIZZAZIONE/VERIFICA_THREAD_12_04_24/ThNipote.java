import java.util.Random;

public class ThNipote extends Thread{
    Stato stato;
    Tavolo vett;
    String nome;
    Random random= new Random();
    public ThNipote(String nome) {
        this.stato = Stato.getIstanza();
        this.vett = Tavolo.getIstanza();
        this.nome=nome;
    }

    @Override
    public void run() {
        while(!stato.stato){
            vett.addCaramelle(nome);
            try {
                sleep(250 + random.nextInt(150));
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

    

}
