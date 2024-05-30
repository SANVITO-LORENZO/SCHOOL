import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Produttore extends Thread {
    Tavolo tavolo;
    Random r;
    List<Cibo>listaProdotto;
        
    public Produttore() {
        this.tavolo = Tavolo.getIstanza();
        r= new Random();
        this.listaProdotto=new ArrayList<Cibo>();
    }

    @Override
    public void run() {
        while (!tavolo.stato) {

            int tmp= r.nextInt(3);
            Cibo c;
            if(tmp==0){
                c= new Panini(tavolo.getCont());
            }
            else if(tmp==1){
                c= new Pizza(tavolo.getCont());
            }
            else{
                c= new Patatine(tavolo.getCont());
            }


            listaProdotto.add(c);
            tavolo.addCibo(c);
            System.out.println("CIBO AGGIUNTO");

            try {
                sleep(c.tmpProduzione);
            } catch (Exception e) {
            }
        }
    }

    public int getNumeroTot(){
        return listaProdotto.size();
    }

    public String LIstaStampa(){
        String tmp="";
        for (int index = 0; index < listaProdotto.size(); index++) {
            tmp+=listaProdotto.get(index).nome+" "+listaProdotto.get(index).id+"\r\n";
        }
        return tmp;
    }
}
