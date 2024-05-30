public class Portafolio {

    //ATTRIBUTI
    int contenuto;
    boolean stato;

    //COSTRTUTTORE
    public Portafolio(int contenuto, boolean stato) {
        this.contenuto = contenuto;
        this.stato = stato;
    }    

    synchronized public void aggiugi_vincita(int soldi){
        contenuto+=soldi;
    }
    synchronized public boolean rimuovi_soldi(){
        if(stato){
            contenuto--;
            if(contenuto==0)
                stato=false;
            return true;
        }
        else
            return false;
    }
    
    //METODI SET E GET
    public int getContenuto() {
        return contenuto;
    }
    public void setContenuto(int contenuto) {
        this.contenuto = contenuto;
    }
    public boolean isStato() {
        return stato;
    }
    public void setStato(boolean stato) {
        this.stato = stato;
    }
}
