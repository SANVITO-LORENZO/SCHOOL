import java.util.ArrayList;
import java.util.List;

public class Consumatore extends Thread{
    Tavolo tavolo;
    List<Cibo>listaRimossi;

    public Consumatore() {
        this.tavolo = Tavolo.getIstanza();
        this.listaRimossi = new ArrayList<Cibo>();
    }

    @Override
    public void run() {
        while (!tavolo.stato || tavolo.tavolo.size()>0) {
            Cibo tmp = tavolo.removeCibo();
            
            if(tmp!=null){
                System.out.println("CIBO RIMOSSO");
                listaRimossi.add(tmp);
            }
            try {
                if(tmp!=null){
                    sleep(tmp.tmpConsumazione);
                }
                else
                    sleep(0);
                
            } catch (Exception e) {
            }
        }
    }

    public int getNumeroTot(){
        return listaRimossi.size();
    }

    public String LIstaStampa(){
        String tmp="";
        for (int index = 0; index < listaRimossi.size(); index++) {
            tmp+=listaRimossi.get(index).nome+" "+listaRimossi.get(index).id+"\r\n";
        }
        return tmp;
    }
}
