import java.awt.Color;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.Random;

public class MyMouseListener implements MouseListener {

    MyPanel pannello;
    Quadrato quadrato;

    public MyMouseListener(MyPanel pannello, Quadrato quadrato) {
        this.pannello = pannello;
        this.quadrato = quadrato;
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        
        pannello.spostaQuadratino(e.getX(), e.getY());
        System.out.println("x= "+e.getX()+"\t y= " +e.getY());

        if(e.getX()>=quadrato.getX() || e.getX()<=quadrato.getX()+quadrato.getWidth()){
            Random random=new Random();
            quadrato.setBackgroundColor(Color.getHSBColor(random.nextInt(256),random.nextInt(256),random.nextInt(256)));
        }
        if(e.getY()>=quadrato.getY() || e.getY()<=quadrato.getY()+quadrato.getHeight()){
            Random random=new Random();
            quadrato.setBackgroundColor(Color.getHSBColor(random.nextInt(256),random.nextInt(256),random.nextInt(256)));
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
