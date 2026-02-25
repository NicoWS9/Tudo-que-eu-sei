import random
pergunta = 1
while pergunta == 1:
    numero = random.randint(1,10)
    numero2 = int(input("Escolha um numero de 1 a 10: "))
   
    if numero > numero2:
        print("Eu ganhei")
    else:
        print("Voce ganhou")
       
    pergunta = int(input("Deseja continuar? 1-sim 2-não: "))

   
    if pergunta != 1:
        break