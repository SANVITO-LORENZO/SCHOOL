import java.time.LocalDate;

public class Misurazione {

    //ATTRIBUTI 
    int temperatura,umidita,pressione;
    LocalDate data;

    //COSTRUTTORE NON PARAMETRICO
    public Misurazione() {
    };

    //COSTRUTTORE  PARAMETRICO
    public Misurazione(int temperatura, int umidita, int pressione, LocalDate data) {
        this.temperatura = temperatura;
        this.umidita = umidita;
        this.pressione = pressione;
        this.data = data;
    }

    //METODI SET
    public void setTemperatura(int temperatura) {
        this.temperatura = temperatura;
    }
    public void setUmidita(int umidita) {
        this.umidita = umidita;
    }
    public void setPressione(int pressione) {
        this.pressione = pressione;
    }
    public void setdata(LocalDate data) {
        this.data = data;
    }

    //METODI GET
    public int getTemperatura() {
        return temperatura;
    }
    public int getUmidita() {
        return umidita;
    }
    public int getPressione() {
        return pressione;
    }
    public LocalDate getdata() {
        return data;
    }

    public String toString(){
        String tmp="";
        tmp+="TEMPERATURA:"+ temperatura;
        tmp+="\r\n";
        tmp+="UMIDITA':"+ umidita;
        tmp+="\r\n";
        tmp+="PRESSIONE:"+ pressione;
        tmp+="\r\n";
        tmp+="DATA:"+ data;
        tmp+="\r\n";
        return tmp;
    }

}
