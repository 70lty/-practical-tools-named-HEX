from random import *
caractere=['é','è','à','â','ë','ï','1','2','3','4','5','6','7','8','9','0','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','()',')(','-','_']
longueur=int(input("How many letters (12 recommend)"))
nb_mdp=int(input("How many password do you want create"))

def mdp(longueur):
    mdp=str()
    shuffle(caractere)
    for x in range(longueur):
        mdp+=caractere[x]
    print(mdp)
        
for x in range(nb_mdp):
    mdp(longueur)


input()