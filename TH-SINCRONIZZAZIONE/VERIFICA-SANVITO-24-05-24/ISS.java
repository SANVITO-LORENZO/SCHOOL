import java.util.ArrayList;
import java.util.List;

public class ISS extends Thread{

    Semaforo tute;
    List<Astronauta> lista;

    public ISS() {
        this.tute = new Semaforo(3);
        this.lista = new ArrayList<Astronauta>();
    }


    @Override
    public void run() {
        for (int i = 0; i < 12; i++) {

            //CONTROLLO SULL'INDICE PER DEFINIRE IL LAVORO
            int tmp=0;
            if(i<13)
                tmp=3;
            if (i<9)
                tmp=2;
            if (i<5)
                tmp=1;

           tute.P();
            Astronauta a = new Astronauta(tute,lista,tmp,i+1);
            a.start();
        }
    }

    public int getTempoMedioPannelli(){
        int tmp =0;
        int cont=0;
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).lavoro==1){
                tmp+=lista.get(i).tmpLavoro;
                cont++;
            }
        }
        return tmp /cont;
    }

    public int getTempoMedioValvola(){
        int tmp =0;
        int cont=0;
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).lavoro==2){
                tmp+=lista.get(i).tmpLavoro;
                cont++;
            }
        }
        return tmp /cont;
    }

    public int getTempoMedioAntenna(){
        int tmp =0;
        int cont=0;
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).lavoro==3){
                tmp+=lista.get(i).tmpLavoro;
                cont++;
            }
        }
        return tmp /cont;
    }

    public int getMinCambiamento(){
        int tmp =lista.get(0).tmpCambiarsi;

        for (int i = 1; i < lista.size(); i++) {
            if(tmp>lista.get(i).tmpCambiarsi)
                tmp=lista.get(i).tmpCambiarsi;
        }
        return tmp;
    }

    public int getMaxCambiamento(){
        int tmp =lista.get(0).tmpCambiarsi;

        for (int i = 1; i < lista.size(); i++) {
            if(tmp<lista.get(i).tmpCambiarsi)
                tmp=lista.get(i).tmpCambiarsi;
        }
        return tmp;
    }

}
