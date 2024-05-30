import javax.swing.JPanel;
import java.awt.Dimension;
import java.awt.Graphics;

public class MyPanel extends JPanel {

    /**attributi */
    Quadrato q;


    /**costruttore */
    public MyPanel() {
        q=new Quadrato(10, 10, 100, 100);
    }

    /**metodo che setta le dimensioni iniziali della finestra */
    @Override
    public Dimension getPreferredSize(){
        return new Dimension(800,800);
    }

    /**metodo che disegna la figura */
    public void paintComponent(Graphics g){
        super.paintComponent(g);

        g.setColor(q.getBackgroundColor());
        g.fillRect(q.getX(), q.getY(), q.getWidth(), q.getHeight());
        g.setColor(q.getBorderColor());
        g.drawRect(q.getX(), q.getY(), q.getWidth(), q.getHeight());
    }

    /**metodo che muove la figura */
    public void spostaQuadratino(int x,int y){
        q.setX(x);
        q.setY(y);
        int limiteX=this.getWidth()-q.getWidth();
        if(q.getX()>limiteX)
            q.setX(limiteX);
        else if(q.getX()<0)
            q.setX(0);

        int limiteY=this.getHeight()-q.getHeight();
        if(q.getY()>limiteY)
            q.setY(limiteY);
        else if(q.getY()<0)
            q.setY(0);

        this.repaint();

    }

    public void spostaQuadratinoDelta(int deltaX,int deltaY){
        spostaQuadratino(q.getX()+deltaX, q.getY()+deltaY);
    }    
}
