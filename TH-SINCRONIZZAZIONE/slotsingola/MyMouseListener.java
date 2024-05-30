import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class MyMouseListener  implements MouseListener{

    MyPanel panel;
    ThreadGiocata tg = null;

    public MyMouseListener(MyPanel panel) {
        this.panel = panel;
    }

    @Override
    public void mouseClicked(MouseEvent e) {

        if(tg != null && tg.isAlive()){
            System.out.println("STA ANCORA ROLLANDO");
        }
        else if(panel.btt.isPressed(e.getX(),e.getY())){
            System.out.println("START!");
            this.tg= new ThreadGiocata(panel);
            this.tg.start();
        }
    }

    @Override
    public void mousePressed(MouseEvent e) {

    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }
    
}
