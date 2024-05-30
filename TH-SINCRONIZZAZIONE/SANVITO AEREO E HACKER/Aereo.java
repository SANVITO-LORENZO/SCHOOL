import java.util.Random;

public class Aereo {
    Posto vett[];
    String vettAgenzia[]=new String[5];
    int maxel=100;
    int numel=0;    
    Stato stato;
    
    static Aereo istanza=null;
    static Aereo ottieniistanza(){
        if(istanza== null){
            istanza = new Aereo();
        }
        return istanza;
    }
    private Aereo() {
        stato= Stato.ottieniIstanza();
        vettAgenzia[0]="A1";
        vettAgenzia[1]="A2";
        vettAgenzia[2]="A3";
        vettAgenzia[3]="A4";
        vettAgenzia[4]="A5";
        inizializza();
        riempimeta();
    }

    private void inizializza(){
        vett=new Posto[maxel];
        for(int x=0;x<maxel;x++){
            vett[x]=new Posto(x+1, null);
            System.out.println("POSTO INIZIALIZZATO: "+ (x));
        }
    }

    private void riempimeta(){
        Random random = new Random();
        for(int x=0;x<maxel/2;x++){
            int tmp=random.nextInt(5);
            vett[x].cambiastato();
            vett[x].setAgenzia(vettAgenzia[tmp]);
            System.out.println("POSTO AGGIUNTO: "+ (x));
        }
        numel=maxel/2;
    }

    public synchronized void eliminaPosto(){
        if(numel>0){
            Random random = new Random();
            boolean eliminato=false;
            while (eliminato==false) 
            {
                int tmp=random.nextInt(maxel);
                if(vett[tmp].isStato()==false){
                    vett[tmp].cambiastato();
                    vett[tmp].setAgenzia(null);
                    System.out.println("POSTO ELIMINATO: " + tmp);
                    numel--;
                }
                    
                    eliminato=true;
                if(numel==0){
                    stato.stato=3;
                }
            }
        }
    }

    public synchronized void aggiungiPosti(int posti, Agenzia agenzia){

        
        if(controllaspazzi(posti)==-1)
            return;
        else{
            int tmp=controllaspazzi(posti);
            for(int x=0;x<posti;x++){
                vett[(tmp+x)].cambiastato();
                vett[(tmp+x)].setAgenzia(agenzia.nome);
                aumentaNumel();
                System.out.println("POSTO AGGIUNTO: " + (tmp+x));
            }
            if(numel==maxel){
                stato.stato=2;
            }
        }
    }

    private int controllaspazzi(int posti){
        for (int i = 0; i < vett.length; i++) {
            if(vett[i].stato == true)
            {
                int tmp = 1;
                while(tmp < posti)
                {                
                    if(i + tmp < 100)
                    {
                        if(vett[i + tmp].stato == true)
                        {
                            tmp++;
                        }
                        else
                            break;
                    }
                    else
                        break;            
                }
                if(tmp == posti)
                    return i;
            }
            
        }
        return -1;
    }

    private synchronized void aumentaNumel(){
        numel++;
    }


}
