
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
public class MyKeyListener  implements KeyListener{

    MyPanel pannello;

    public MyKeyListener(MyPanel pannello) {
        this.pannello = pannello;
    }

    @Override
    public void keyTyped(KeyEvent e) {
    }

    @Override
    public void keyReleased(KeyEvent e) {
    }

    @Override
    public void keyPressed(KeyEvent e) {

        char car=e.getKeyChar();
        //System.out.println("P R E M U T O --> "+ car);
        if(car=='d'|| car=='D'){
            //System.out.println("MI SPOSTO A DESTRA: ");
            pannello.spostaQuadratinoDelta(10, 0);
        }

        if(car=='w'|| car=='W'){
            //System.out.println("MI SPOSTO IN SU : ");
            pannello.spostaQuadratinoDelta(0, -10);
        }

        if(car=='a'|| car=='A'){
            //System.out.println("MI SPOSTO A SINISTA: ");
            pannello.spostaQuadratinoDelta(-10, 0);
        }

        if(car=='s'|| car=='S'){
            //System.out.println("MI SPOSTO IN GIU: ");
            pannello.spostaQuadratinoDelta(0, 10);
        }        
    }


    
}
