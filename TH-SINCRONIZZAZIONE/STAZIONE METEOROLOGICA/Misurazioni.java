import java.util.ArrayList;
import java.util.List;

public class Misurazioni {
    
    //ATTRIBUTI
    List<Misurazione> dati;
    int numel; 

    //COSTRUTTORE NON PARAMETRICO
    public Misurazioni() {
    }
    
    //COSTRUTTORE PARAMETRICO
    public Misurazioni(int dimensione) {
        dati= new ArrayList<Misurazione>();
        this.numel = dimensione;
    }

    //METODO SET
    public void setDimesione(int dimensione) {
        this.numel = dimensione;
    }

    //METODO ADD
    synchronized public void push(Misurazione m) {
        if (numel>=10) {
            System.out.println(new Exception("BUFFER PIENO")); 
        }
        dati.add(m);
    }

    //METODO REMOVE
    synchronized public Misurazione pop() {
        if (!dati.isEmpty())
            return dati.remove(numel);
        else
            return null;
    }

    public String toString (int num){
        return dati.get(num).toString();
    }

}
