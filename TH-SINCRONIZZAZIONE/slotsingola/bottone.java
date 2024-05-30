import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

public class bottone {
    int x,y,w,h;

    public bottone(int x, int y, int w, int h) {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
    }

    boolean isPressed(int xM,int yM){
        if(x<xM && xM < x+w){
            if (y<yM && yM < y+w) {
                return true;
            }
        }
        return false;
    }

    void disegnati(Graphics g){
        g.setColor(Color.RED);
        g.fillRect(x, y, w, h);
        g.setColor(Color.BLACK);
        g.drawRect(x, y, w, h);

        g.setFont(new Font("arial",0,30));
        g.drawString("LUDOPATICO", x, y+h);
    }
}
