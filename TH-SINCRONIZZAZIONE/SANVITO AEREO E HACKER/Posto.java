public class Posto {
    int numero;
    String agenzia;
    boolean stato;



    public Posto(int numero, String agenzia) {
        this.numero = numero;
        this.agenzia = agenzia;
        this.stato = true;
    }

    public void setAgenzia(String agenzia) {
        this.agenzia = agenzia;
    }
    public void setStato(boolean stato) {
        this.stato = stato;
    }
    public String getAgenzia() {
        return agenzia;
    }

    public boolean isStato() {
        return stato;
    }

    public void cambiastato(){
        if(stato)
            stato=false;
        else
            stato=true;
    }
}
