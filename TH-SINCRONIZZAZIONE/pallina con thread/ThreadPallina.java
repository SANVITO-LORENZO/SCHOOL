public class ThreadPallina extends Thread {


    //attributi
    MyPanel pannello;
    Pallina p;

    ThreadPallina(MyPanel pannello,Pallina pallina){
        this.pannello=pannello;
        this.p=pallina;
    }

    @Override
    public void run() {
        pannello.addpallina(p);
        while(true){

            int posx=p.getX();
            int posy=p.getY();
            System.out.println("-------------------------");
            System.out.println("x= "+p.getX() );
            System.out.println("y= "+p.getY() );

            if(p.getDirezione()==0){
                posy+=10;
                posx+=10;
                if(posy+p.getHeight()>pannello.getHeight()||posx>pannello.getWidth())
                    p.setDirezione(1);
            }
            if(p.getDirezione()==1){
                posy-=10;
                posx+=10;
                if(posy<0||posx+p.getWidth()>pannello.getWidth())
                    p.setDirezione(2);
            }
            if(p.getDirezione()==2){
                posy-=10;
                posx-=10;
                if(posy<0||posx<0)
                    p.setDirezione(3);
            }
            if(p.getDirezione()==3){
                posy+=10;
                posx-=10;
                if(posy>pannello.getHeight()||posx<0){
                    p.setDirezione(0);}
            }
            p.setY(posy);
            p.setX(posx);

            try{
            Thread.sleep(10);
             }catch (InterruptedException e) {
            } 
    }
    }
}
