#while
'''
contatore=0
while contatore <=10:
    contatore+=1
    if contatore==5:
        continue
    print(contatore)
'''
#while infinito e con la condizione di uscita
'''
while True:
    print(contatore)
    contatore+=1
    if contatore==1000:
        break
'''
#for
#dove parto/dove arrivo/incremento
for conta in range(0,11,2):
    print(conta)

for conta in range(11,0,-1):
    print(conta)