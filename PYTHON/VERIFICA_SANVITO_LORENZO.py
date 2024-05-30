#sanvito lorenzo
#4cinf
#18/11/2023

#importo la libreria con la quale potrò fare la grafica
import turtle

#inizializzo il vettore di temperature a 0
for numero in range(10):
    if(numero==0):
        vettore_temperature=[0]
    else:
        vettore_temperature.append(0)

#creo il menu e lo stampo
menu=""
menu+="1-inserire 10 temperature" +"\n"
menu+="2-modificare una temperatura" +"\n"
menu+="3-creare un grafico a linee" +"\n"
menu+="4-creare un istogramma" +"\n"
menu+="X-esci dal programma" +"\n"
print(menu)

#variabile che mi permettera di scegliere come procedere
scelta="0"
#creo il menu a 5 opzioni
while(scelta!="X"):
    scelta=input("cosa scegli: ")
    if(scelta=="1"): 
        #prendo il numero in input e lo inserisco in tutto il vettore
        for numero in range(10):
            num=input("quale numero si vuole inserire: ")
            vettore_temperature[numero]=num

    elif(scelta=="2"):
        #chiedo dove e con che numero si vuole sostituire
        indice=input("inserisci un indice: ")
        num=input("inserisci il numero: ") 
        vettore_temperature[int(indice)]=int(num)   
    elif(scelta=="3"):
        #creo la turtle
        t = turtle.Turtle()
        #gli imposto una velocita 0->piu veloce 10->piu lenta
        t.speed(0)
        t.home
        t.hideturtle

        #creo il piano cartesiano
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)

        #creo i punti del grafico
        for numero in range(10):
            t.penup()
            t.setpos(float((numero+1)*30),float(vettore_temperature[numero])*5)
            t.pendown()
            t.dot(10)
            t.penup()
        #pusiziono la turtle al primo punto
        t.setpos(float((0+1)*30),float(vettore_temperature[0])*5)
        t.color("red")
        t.pendown()
        #collego tutti i punti
        for numero in range(10):
            t.setpos(float((numero+1)*30),float(vettore_temperature[numero])*5)

        turtle.done()


    elif(scelta=="4"):
        #creo la turtle
        t = turtle.Turtle()
        #gli imposto una velocita 0->piu veloce 10->piu lenta
        t.speed(0)
        t.home
        t.hideturtle

        #creo il piano cartesiano
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)
        t.forward(350)
        t.write(t.pos())
        t.stamp()
        t.setpos(0,0)
        t.left(90)   

        #creo le barre dell'istogramma
        for numero in range(10):
            t.penup()
            t.home()
            t.left(90)
            t.setpos(float((numero+1)*30),0)
            t.pendown()
            t.forward(float(vettore_temperature[numero]))
            t.right(90)
            t.forward(30)
            t.right(90)
            t.forward(float(vettore_temperature[numero]))
            t.penup() 

        #colore  
        for numero in range(10):
            t.penup()
            t.home()
            t.left(90)
            t.setpos(float((numero+1)*30),0)
            t.color("red")
            t.begin_fill()
            t.forward(float(vettore_temperature[numero]))
            t.right(90)
            t.forward(30)
            t.right(90)
            t.forward(float(vettore_temperature[numero]))
            t.right(90)
            t.forward(30)
            t.end_fill()



        turtle.done()
    elif(scelta=="X"):
        exit
    else:
        print("valore inserite errato perfavore riprovare")
