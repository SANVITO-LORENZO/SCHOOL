public class CElezione {

    /*costante massimo voti */
    static final int MAXVOTI=50;
    int numpers;


    CElezione(){
        CPersona[]vett=new CPersona[MAXVOTI];
        numpers=0;
    }

    void addVoto(String nome){
        for(int x=0;x<numpers;x++){
            if (vett[x]->getnome()=="nome")
                vett[x]->addVoto();
        }
    }

    String visualizzaElenco(){ 
        String tmp="";
        for(int x=0;x<numpers;x++){
            tmp+=x.getnome()+"\n";
        }
        return tmp;
    }

    void ordinaElenco(){

    }

    int getVoti(CPersona persona){
        String tmp="";
        for(int x=0;x<numpers;x++){
            tmp+=x.getnome()+"\t";
            tmp+=x.getVoti()+"\n";
        }
        return tmp;
    }

    void eleminaVoto(CPersona persona){
        persona.eleminaVoto();
    }

    CElezione ritornaElenco(){
        return CElezione;
    }

    String visualizzaRisultati(){
        return "";
    }


}
