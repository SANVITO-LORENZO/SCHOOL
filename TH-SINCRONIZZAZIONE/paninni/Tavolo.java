import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Tavolo {
    
    List<Cibo>tavolo;
    boolean stato;
    Random r;
    int contatore;

    private Tavolo() {
        this.tavolo = new ArrayList<Cibo>();
        stato = false;
        r= new Random();
        contatore=0;
        
    }

    private static Tavolo istanza;

    synchronized public static Tavolo getIstanza(){
        if(istanza==null)
            istanza= new Tavolo();
        return istanza;
    } 


    synchronized public void addCibo(Cibo cibo){
        tavolo.add(cibo);
    }

    synchronized public Cibo removeCibo(){
        if(tavolo.size()>0){
            int tmp = r.nextInt(tavolo.size());
            return tavolo.remove(tmp);
        }
        return null;
    }

    synchronized int getCont(){
        return contatore++;
    }
}
