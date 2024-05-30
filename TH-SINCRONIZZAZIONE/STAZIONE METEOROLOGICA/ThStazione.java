import java.time.LocalDate;
import java.util.Random;

public class ThStazione extends Thread {

    //ATTRIBUTI
    String nomeCitta;
    Random random= new Random();
    Misurazioni buffer;
    Semaforo mutexBuffer;
    Semaforo semLetto;
    Semaforo semScritto;
    ContatoreBuffer contatore;

    //COSTRUTTORE NON PARAMETRICO
    public ThStazione() {
       
    }

    //COSTRUTTORE PARAMETRICO
    public ThStazione(String nomeCitta,Misurazioni buffer, Semaforo mutex, ContatoreBuffer contatore, Semaforo bufferDatoScritto, Semaforo bufferDatoLetto) {
        this.nomeCitta = nomeCitta;
        this.buffer = buffer;
        this.mutexBuffer=mutex;
        this.contatore= contatore;
        this.semLetto=bufferDatoLetto;
        this.semScritto=bufferDatoScritto;
    }

    //METODI SET
    public void setNomeCitta(String nomeCitta) {
        this.nomeCitta = nomeCitta;
    }
    public void setBuffer(Misurazioni buffer) {
        this.buffer = buffer;
    }

    //METODO RUN
    @Override
    public void run() {
        int tmp=0;
        while (tmp!=10) {
            try {
                
                int temp = -60 + random.nextInt(120);
                int um = -5 + random.nextInt(210);
                int bar = 940 + random.nextInt(115);
                LocalDate data = LocalDate.now();

                semLetto.P();
                mutexBuffer.P();
                buffer.push(new Misurazione(temp, um,  bar,data));
                mutexBuffer.V();
                semScritto.V();
                
                System.out.println("AGGIUNTA AL BUFFER");
                sleep(3000);
                tmp++;

            } 
            catch (Exception e) {    
            }
        }
        contatore.add();
    }
    
}
