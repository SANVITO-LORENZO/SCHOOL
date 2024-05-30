import java.util.Random;

public class Tavolo {
    Caramella vett[];
    Stato stato;
    int maxel=100;
    int numel=0;
    int paperino=0;
    int paperina=0;



    static Tavolo istanza= null;
    static synchronized Tavolo getIstanza(){
        if(istanza == null)
            istanza= new Tavolo();
        return istanza;
    }

    private Tavolo() {
        vett = new Caramella[100];
        stato=Stato.getIstanza();
        inizializzaTavolo();
    }

    private void inizializzaTavolo(){
        for (int i = 0; i < vett.length; i++) {
            vett[i]= new Caramella();
        }
    }

    public synchronized void addCaramelle( String postIt){

        Random random = new Random();
        int tmp=-1;
        int contatore=0;
        int numCaramelle= random.nextInt(5);

        while(contatore!=numCaramelle){
            int num=random.nextInt(maxel);
            if((num + 1) == tmp){
                break;
            }
            else if(!vett[num].isPrenotata()){
                tmp=num;
                vett[num].cambiaStato();
                vett[num].setpostIt(postIt);
                contatore++;
                numel++;
                if(numel==maxel)
                    stato.stato=true;
            }
        }
    }

    public synchronized void removeCaramella(String nome){

        Random random = new Random();
        String postIt1="";
        String postIt2="";
        String postIt3="";
        int contatore =0;
        int numCaramelle= random.nextInt(4);
        if(numel>0){
           while(contatore!=numCaramelle){
            int num=random.nextInt(maxel);
            if(vett[num].isPrenotata()){
                if(contatore==0){
                    postIt1=vett[num].getpostIt();
                }
                else if(contatore==1){
                    postIt2=vett[num].getpostIt();
                    if(postIt1==postIt2){
                        postIt2="";
                        break;
                    }
                }
                else if(contatore==2){
                    postIt3=vett[num].getpostIt();
                    if(postIt3==postIt1 || postIt3==postIt2){
                        postIt3="";
                        break;
                    }
                }
                numel--;
                contatore++;
                vett[num].cambiaStato();
                vett[num].setpostIt("");

                if(nome == "paperino"){
                    paperino++;
                }
                else if(nome == "paperina"){
                    paperina++;
                }
            }
            else{
                return;
            }
            }        
        }
        
    }

    public int getPaperino() {
        return paperino;
    }

    public int getPaperina() {
        return paperina;
    }

    public String stampa() {
        String tmp="";
        for (int i = 0; i < maxel; i++) {
            if(vett[i].prenotata){
                tmp+=i+": P ";
                tmp+=vett[i].postIt + "\r\n";
            }
            else
                tmp+=i+": L"+ "\r\n";
        }
        return tmp;
    }

    public int trovaOccorrenza(String nome){
        int tmp=0;
        for(int t=0;t<maxel;t++){
            if(vett[t].postIt==nome)
                tmp++;
        }
        return tmp;
    }

    public String classifica(){
        String tmp="";
        int qui = trovaOccorrenza("qui");
        int quo = trovaOccorrenza("quo");
        int qua = trovaOccorrenza("qua");

        if(qui>quo && qui> qua){
            tmp+="qui: " + qui;
            tmp+="\r\n";
            if(quo>qua){
                tmp+="quo: " + quo;
                tmp+="\r\n";
                tmp+="qua: " + qua;
                tmp+="\r\n";
            }
            else{
                tmp+="qua: " + qua;
                tmp+="\r\n";
                tmp+="quo: " + quo;
                tmp+="\r\n";
            }     
        }

        else if(qua>quo && qua> qui){
            tmp+="qua: " + qua;
            tmp+="\r\n";
            if(quo>qui){
                tmp+="quo: " + quo;
                tmp+="\r\n";
                tmp+="qui: " + qui;
                tmp+="\r\n";
            }
            else{
                tmp+="qui: " + qui;
                tmp+="\r\n";
                tmp+="quo: " + quo;
                tmp+="\r\n";
            }     
        }

        else{
            tmp+="quo: " + quo;
            tmp+="\r\n";
            if(qua>qui){
                tmp+="qua: " + qua;
                tmp+="\r\n";
                tmp+="qui: " + qui;
                tmp+="\r\n";
            }
            else{
                tmp+="qui: " + qui;
                tmp+="\r\n";
                tmp+="qua: " + qua;
                tmp+="\r\n";
            } 
        }
        return tmp;

    }
}
