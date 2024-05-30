import java.util.List;
import java.util.Random;

public class Astronauta extends Thread {
    
    //ATTRIBUTI
    int nome;
    Semaforo tute;
    int tmpCambiarsi;
    int tmpLavoro;
    int tmpTotatle;
    List<Astronauta> lista;
    int lavoro;
    Random r;

    //COSTRUTTORE
    public Astronauta(Semaforo tute, List<Astronauta> lista, int lavoro,int nome) {
        this.nome=nome;
        this.tute = tute;
        this.tmpCambiarsi = 0;
        this.tmpTotatle = 0;
        this.tmpLavoro = 0;
        this.lista = lista;
        this.lavoro = lavoro;
        this.r= new Random();
    }

    @Override
    public void run() {

        System.out.println("astronauta "+ nome+ " inizia");

        //METTERSI LA TUTA
        System.out.println("astronauta "+ nome+ " FASE 1");
        int tmp1=r.nextInt(2000)+1000;
        try {
            sleep(tmp1);
        } catch (Exception e) {}

        //USCIRE DALLA STAZIONE
        System.out.println("astronauta "+ nome+ " FASE 2");
        int tmp2=r.nextInt(3000)+5000;
        try {
            sleep(tmp2);
        } catch (Exception e) {}

        //LAVORO
        System.out.println("astronauta "+ nome+ " FASE 3");
        int tmp3=0;
        if(lavoro==1)
            tmp3=r.nextInt(5000)+5000;
        if(lavoro==2)
            tmp3=r.nextInt(9000)+3000;
        if(lavoro==3)
            tmp3=r.nextInt(10000)+10000;
        try {
            sleep(tmp3);
        } catch (Exception e) {}

        //TORNARE ALLA STAZIONE
        System.out.println("astronauta "+ nome+ " FASE 4");
        int tmp4=r.nextInt(3000)+5000;
        try {
            sleep(tmp4);
        } catch (Exception e) {}

        //TOGLIERSI LA TUTA
        System.out.println("astronauta "+ nome+ " FASE 5");
        int tmp5=r.nextInt(2000)+1000;
        try {
            sleep(tmp5);
        } catch (Exception e) {}

        System.out.println("astronauta "+ nome+ " finisce");
        this.tmpTotatle= tmp1+tmp2+tmp3+tmp4+tmp5;
        this.tmpLavoro= tmp3;
        this.tmpCambiarsi = tmp1+tmp5;

        inserisciAstronauta(this);

        tute.V();

    }

    //FATTA QUESTA FUNZIONE NEL CASO DUE ASTRONAUTI FINISCANO NELLO STESSO MOMENTO
    synchronized public void inserisciAstronauta(Astronauta a){
        lista.add(a);
    }

    

}
