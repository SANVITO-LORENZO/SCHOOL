import java.util.Date;

public class ThTempo extends Thread{
    ISS stazione;
    long tempo;

    public ThTempo(ISS stazione) {
        this.stazione = stazione;
        this.tempo = 0;
    }

    @Override
    public void run() {
        Date d1 = new Date();
        while (stazione.lista.size()<12) {
            try {
                sleep(1);
            } catch (Exception e) {}
        }
        Date d2 = new Date();
        tempo=d2.getTime()-d1.getTime();
    }

}
