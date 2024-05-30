import java.util.Random;

public class ThServer extends Thread {

    // ATTRIBUTI
    Misurazioni buffer;
    Misurazioni corrette;
    Misurazioni sbagliate;
    Semaforo mutexBuffer;
    Semaforo mutexCorrette;
    Semaforo mutexSbagliate;
    Semaforo semLetto;
    Semaforo semScritto;
    public ThServer(Misurazioni buffer, Misurazioni corrette, Misurazioni sbagliate, Semaforo mutexBuffer,
            Semaforo mutexCorrette, Semaforo mutexSbagliate, Semaforo bufferDatoScritto, Semaforo bufferDatoLetto) {
        this.buffer = buffer;
        this.corrette = corrette;
        this.sbagliate = sbagliate;
        this.mutexBuffer = mutexBuffer;
        this.mutexCorrette = mutexCorrette;
        this.mutexSbagliate = mutexSbagliate;
        this.semLetto=bufferDatoLetto;
        this.semScritto=bufferDatoScritto;
    }

    Random random;

    @Override
    public void run() {
        while (true) {
            semScritto.P();
            mutexBuffer.P();
            Misurazione tmp = buffer.pop();
            mutexBuffer.V();
            semLetto.V();
            System.out.println("RIMOSSA DAL BUFFER");
            if (controllo(tmp) == true) {
                mutexCorrette.P();
                corrette.push(tmp);
                mutexCorrette.V();
                System.out.println("AGGIUNTA ALLE CORRETTE");
            } else {
                mutexSbagliate.P();
                sbagliate.push(tmp);
                mutexSbagliate.V();
                System.out.println("AGGIUNTA ALLE SBAGLIATE");
            }
            try {
                sleep(random.nextInt(200) + 200);
            } catch (Exception e) {
            }

        }

    }

    public boolean controllo(Misurazione tmp) {
        boolean controllo = true;
        if (tmp == null)
           return false;
        if (tmp.pressione < 950 || tmp.pressione > 1050) {
            controllo = false;
        }
        if (tmp.temperatura < -50 || tmp.temperatura > 50) {
            controllo = false;
        }
        if (tmp.umidita < -5 || tmp.umidita > 105) {
            controllo = false;
        }
        return controllo;
    }

}
