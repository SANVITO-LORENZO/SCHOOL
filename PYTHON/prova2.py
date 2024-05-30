# sanvito lorenzo
# 4cinf
# 14/10/2023

py_nome="pippo"
py_anni=1
py_frase=""
py_anni+=1

if py_anni>=18:
    py_frase=" anni e sono maggiorenne"
elif py_anni>3:
    py_frase=" anni "
elif py_anni==2:
    pass #non fa un cassssssssssssssssssssssssssssssoooooooooooooooooooooooooooooooooooooooooooooooooo
else:
    py_frase=" anno "

'''
py_out="ciao! il mio nome è "+py_nome+" ho "+str(py_anni)+" anni "
print(py_out)
'''

print("ciao! il mio nome è "+py_nome+" ho "+str(py_anni)+ py_frase)

#tutti gli input sono delle stringhe
utente_nome=input("tu come ti chiami? ")
utente_anni=input("quanti anni hai? ")

print("ciao! "+utente_nome+" hai "+utente_anni+" anni ")

print("abbiamo" + str(float(utente_anni)-py_anni) + "di differenza")

